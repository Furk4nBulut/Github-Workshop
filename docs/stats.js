// Stats Page JavaScript

document.addEventListener('DOMContentLoaded', function () {
    // Initialize theme
    initStatsTheme();

    // Load and display stats
    loadStats();

    // Setup search
    setupSearch();

    // Setup sort
    setupSort();
});

// Theme initialization for stats page
function initStatsTheme() {
    const themeToggle = document.getElementById('themeToggle');
    const html = document.documentElement;

    const savedTheme = localStorage.getItem('theme');
    const systemTheme = window.matchMedia('(prefers-color-scheme: dark)').matches ? 'dark' : 'light';
    let currentTheme = savedTheme || systemTheme;

    html.setAttribute('data-theme', currentTheme);
    updateStatsThemeIcon(currentTheme);

    if (themeToggle) {
        themeToggle.addEventListener('click', () => {
            currentTheme = html.getAttribute('data-theme') === 'dark' ? 'light' : 'dark';
            html.setAttribute('data-theme', currentTheme);
            localStorage.setItem('theme', currentTheme);
            updateStatsThemeIcon(currentTheme);
        });
    }
}

function updateStatsThemeIcon(theme) {
    const themeToggle = document.getElementById('themeToggle');
    if (!themeToggle) return;

    const icon = themeToggle.querySelector('i');
    icon.className = theme === 'dark' ? 'fas fa-moon' : 'fas fa-sun';
}

// Global data store
let statsData = null;

// Load stats from JSON
async function loadStats() {
    try {
        const response = await fetch('data/scores.json');
        if (!response.ok) throw new Error('Failed to load stats');

        statsData = await response.json();
        displayStats(statsData);
    } catch (error) {
        console.error('Error loading stats:', error);
        showEmptyState();
    }
}

// Display all statistics
function displayStats(data) {
    // Update overview cards
    document.getElementById('totalStudents').textContent = data.statistics.totalStudents;
    document.getElementById('totalSubmissions').textContent = data.statistics.totalSubmissions;
    document.getElementById('averageScore').textContent = data.statistics.averageScore.toFixed(1);
    document.getElementById('highestScore').textContent = data.statistics.highestScore;

    // Update problem stats
    updateProblemStats(data.statistics.problemStats);

    // Update leaderboard
    updateLeaderboard(data.students);

    // Update last updated time
    updateLastUpdated(data.lastUpdated);
}

// Update problem statistics
function updateProblemStats(problemStats) {
    for (let i = 1; i <= 4; i++) {
        const key = `problem${i}`;
        const stats = problemStats[key];

        if (stats) {
            document.getElementById(`p${i}-attempts`).textContent = stats.attempts;
            document.getElementById(`p${i}-avg`).textContent = stats.avgScore.toFixed(1);
            document.getElementById(`p${i}-pass`).textContent = `${stats.passRate}%`;
            document.getElementById(`p${i}-progress`).style.width = `${stats.passRate}%`;
        }
    }
}

// Update leaderboard table
function updateLeaderboard(students, sortBy = 'rank') {
    const tbody = document.getElementById('leaderboardBody');
    const emptyState = document.getElementById('emptyState');
    const table = document.getElementById('leaderboardTable');

    if (!students || students.length === 0) {
        showEmptyState();
        return;
    }

    // Sort students
    let sortedStudents = [...students];
    switch (sortBy) {
        case 'studentNo':
            sortedStudents.sort((a, b) => a.studentNo.localeCompare(b.studentNo));
            break;
        case 'recent':
            sortedStudents.sort((a, b) => new Date(b.lastSubmission) - new Date(a.lastSubmission));
            break;
        case 'rank':
        default:
            sortedStudents.sort((a, b) => b.total - a.total);
    }

    // Generate table rows
    tbody.innerHTML = sortedStudents.map((student, index) => {
        const rank = index + 1;
        const rankClass = rank === 1 ? 'gold' : rank === 2 ? 'silver' : rank === 3 ? 'bronze' : 'normal';

        const p1 = student.scores.problem1 || 0;
        const p2 = student.scores.problem2 || 0;
        const p3 = student.scores.problem3 || 0;
        const p4 = student.scores.problem4 || 0;

        const total = student.total || 0;

        // Determine status
        let status, statusClass;
        if (total === 100) {
            status = '🎉 Tam Puan';
            statusClass = 'complete';
        } else if (total >= 50) {
            status = '📈 Devam Ediyor';
            statusClass = 'partial';
        } else {
            status = '🚀 Başladı';
            statusClass = 'started';
        }

        return `
            <tr>
                <td><span class="rank ${rankClass}">${rank}</span></td>
                <td><strong>${student.studentNo}</strong></td>
                <td class="score-cell ${getScoreClass(p1, 25)}">${p1}</td>
                <td class="score-cell ${getScoreClass(p2, 25)}">${p2}</td>
                <td class="score-cell ${getScoreClass(p3, 25)}">${p3}</td>
                <td class="score-cell ${getScoreClass(p4, 25)}">${p4}</td>
                <td class="total-col"><span class="total-score">${total}</span>/100</td>
                <td><span class="status-badge ${statusClass}">${status}</span></td>
            </tr>
        `;
    }).join('');

    // Show table, hide empty state
    table.style.display = 'table';
    emptyState.classList.remove('show');
}

// Get score class for styling
function getScoreClass(score, max) {
    if (score === max) return 'full';
    if (score > 0) return 'partial';
    return 'zero';
}

// Show empty state
function showEmptyState() {
    const table = document.getElementById('leaderboardTable');
    const emptyState = document.getElementById('emptyState');

    table.style.display = 'none';
    emptyState.classList.add('show');
}

// Update last updated time
function updateLastUpdated(timestamp) {
    const updateTime = document.getElementById('updateTime');
    if (!timestamp) {
        updateTime.textContent = '-';
        return;
    }

    const date = new Date(timestamp);
    const options = {
        year: 'numeric',
        month: 'long',
        day: 'numeric',
        hour: '2-digit',
        minute: '2-digit'
    };
    updateTime.textContent = date.toLocaleDateString('tr-TR', options);
}

// Setup search functionality
function setupSearch() {
    const searchInput = document.getElementById('searchStudent');
    if (!searchInput) return;

    searchInput.addEventListener('input', (e) => {
        const query = e.target.value.trim();

        if (!statsData || !statsData.students) return;

        if (query.length === 0) {
            updateLeaderboard(statsData.students);
            return;
        }

        const filtered = statsData.students.filter(student =>
            student.studentNo.includes(query)
        );

        updateLeaderboard(filtered);
    });
}

// Setup sort functionality
function setupSort() {
    const sortSelect = document.getElementById('sortSelect');
    if (!sortSelect) return;

    sortSelect.addEventListener('change', (e) => {
        if (!statsData || !statsData.students) return;
        updateLeaderboard(statsData.students, e.target.value);
    });
}

// Mobile nav toggle
const navToggle = document.getElementById('navToggle');
const navMenu = document.getElementById('navMenu');

if (navToggle && navMenu) {
    navToggle.addEventListener('click', () => {
        navMenu.classList.toggle('open');
    });
}

// Console Easter Egg
console.log('%c📊 GitHub Workshop - İstatistikler', 'font-size: 18px; font-weight: bold; color: #6366f1;');
console.log('%cÖğrenci liderlik tablosu ve puan takibi', 'font-size: 12px; color: #8b949e;');
