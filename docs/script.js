// DOM Ready
document.addEventListener('DOMContentLoaded', function () {
    // Initialize Highlight.js
    if (typeof hljs !== 'undefined') {
        hljs.highlightAll();
    }

    // Initialize Theme
    initTheme();

    // Initialize Search (if input exists)
    initSearch();

    // Initialize Progress Tracking (if article exists)
    initProgress();

    // Sidebar Rendering
    renderSidebar();

    // Sidebar Toggle
    const sidebarToggle = document.getElementById('sidebarToggle');
    const sidebar = document.getElementById('sidebar');

    if (sidebarToggle && sidebar) {
        sidebarToggle.addEventListener('click', () => {
            sidebar.classList.toggle('open');
        });

        // Close sidebar when clicking outside
        document.addEventListener('click', (e) => {
            if (!sidebar.contains(e.target) && !sidebarToggle.contains(e.target)) {
                sidebar.classList.remove('open');
            }
        });
    }

    // Smooth scroll for anchor links
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function (e) {
            e.preventDefault();
            const target = document.querySelector(this.getAttribute('href'));
            if (target) {
                target.scrollIntoView({
                    behavior: 'smooth',
                    block: 'start'
                });
                // Close sidebar on mobile
                sidebar.classList.remove('open');
            }
        });
    });

    // Highlight current section in sidebar based on scroll
    const sections = document.querySelectorAll('h2[id], h3[id]');

    if (sections.length > 0) {
        const observerOptions = {
            rootMargin: '-80px 0px -80% 0px',
            threshold: 0
        };

        const observer = new IntersectionObserver((entries) => {
            entries.forEach(entry => {
                if (entry.isIntersecting) {
                    const id = entry.target.getAttribute('id');
                    const navItems = document.querySelectorAll('.nav-item');
                    // Reset active state for sub-items
                    navItems.forEach(item => {
                        if (item.getAttribute('href').includes('#')) {
                            item.classList.remove('active');
                        }
                    });

                    const navLink = document.querySelector(`.nav-item[href*="#${id}"]`);
                    if (navLink) {
                        navLink.classList.add('active');
                    }
                }
            });
        }, observerOptions);

        sections.forEach(section => observer.observe(section));
    }
});

// Sidebar Navigation Data
const sidebarNavigation = [
    {
        title: "",
        items: [
            { text: "Wiki Ana Sayfa", url: "wiki.html", icon: "fas fa-book" },
            { text: "📊 İstatistikler", url: "stats.html", icon: "fas fa-chart-line" },
            { text: "← Tanıtım Sayfası", url: "index.html", icon: "fas fa-home" }
        ]
    },
    {
        title: "Modül 1: Giriş",
        icon: "fas fa-rocket",
        items: [
            { text: "Git ve GitHub Nedir?", url: "module1.html" },
            { text: "Student Developer Pack", url: "module1.html#student-pack" },
            { text: "GUI Araçları", url: "module1.html#gui" }
        ]
    },
    {
        title: "Modül 2: Temel Beceriler",
        icon: "fas fa-code",
        items: [
            { text: "Git Komutları", url: "module2.html" },
            { text: "Markdown", url: "module2.html#markdown" },
            { text: "Lisanslar", url: "module2.html#licenses" }
        ]
    },
    {
        title: "Modül 3: İş Akışı",
        icon: "fas fa-code-branch",
        items: [
            { text: "Branch Yönetimi", url: "module3.html" },
            { text: "Fork ve Clone", url: "module3.html#fork" },
            { text: "Conventional Commits", url: "module3.html#commits" }
        ]
    },
    {
        title: "Modül 4: Takım Çalışması",
        icon: "fas fa-users",
        items: [
            { text: "Organization", url: "module4.html" },
            { text: "Pull Request", url: "module4.html#pr" },
            { text: "Issues ve Projects", url: "module4.html#issues" }
        ]
    },
    {
        title: "Modül 5: İleri Seviye",
        icon: "fas fa-bolt",
        items: [
            { text: "Rebase ve Stash", url: "module5.html" },
            { text: "GitHub Actions", url: "module5.html#actions" }
        ]
    },
    {
        title: "Modül 6: Kariyer",
        icon: "fas fa-star",
        items: [
            { text: "Profile README", url: "module6.html" },
            { text: "GitHub Pages", url: "module6.html#pages" }
        ]
    },
    {
        title: "Referanslar",
        icon: "fas fa-book",
        items: [
            { text: "Git Cheat Sheet", url: "cheatsheet-git.html" },
            { text: "Markdown Cheat Sheet", url: "cheatsheet-markdown.html" },
            { text: "SSS", url: "faq.html" }
        ]
    }
];

function renderSidebar() {
    const container = document.getElementById('sidebar-nav-container');
    if (!container) return; // Might be on a page without sidebar container

    // Search container
    let html = `
        <div class="search-container">
            <input type="text" id="searchInput" class="search-input" placeholder="Wiki'de ara...">
            <div id="searchResults"></div>
        </div>
    `;

    const currentPage = window.location.pathname.split('/').pop() || 'index.html';
    const currentHash = window.location.hash;

    sidebarNavigation.forEach(section => {
        html += `<div class="nav-section">`;

        // Section Title
        if (section.title) {
            if (section.icon) {
                html += `
                    <div class="nav-section-title">
                        <i class="${section.icon}"></i>
                        <span>${section.title}</span>
                    </div>
                `;
            } else {
                html += `<div class="nav-section-title"><span>${section.title}</span></div>`;
            }
        }

        // Section Items
        section.items.forEach(item => {
            let isActive = false;

            // Exact match for pages
            if (item.url === currentPage) {
                isActive = true;
            }
            // Handle hash links if on same page
            else if (item.url.includes('#')) {
                const [itemPage, itemHash] = item.url.split('#');
                if (itemPage === currentPage && itemHash === currentHash.replace('#', '')) {
                    // This logic is simple, intersection observer will handle scrolling updates
                }
            }

            // If main page is active, ensure main link is active (handled better below)

            const activeClass = isActive ? 'active' : '';
            const iconHtml = item.icon ? `<i class="${item.icon}"></i>` : '';

            html += `
                <a href="${item.url}" class="nav-item ${activeClass}">
                    ${iconHtml}
                    <span>${item.text}</span>
                </a>
            `;
        });

        html += `</div>`;
    });

    container.innerHTML = html;

    // Initial Active State Logic (Simple)
    const navItems = container.querySelectorAll('.nav-item');
    navItems.forEach(item => {
        const itemHref = item.getAttribute('href');
        if (itemHref === currentPage || (itemHref === 'index.html' && currentPage === '')) {
            item.classList.add('active');
        } else if (itemHref.startsWith(currentPage + '#')) {
            // Sub-items of current page, active if hash matches or if it's the first execution
            if (window.location.hash && itemHref.endsWith(window.location.hash)) {
                item.classList.add('active');
            }
        }
    });
}

// Copy code functionality
function copyCode(button) {
    const codeBlock = button.closest('.code-block');
    const code = codeBlock.querySelector('code').textContent;

    navigator.clipboard.writeText(code).then(() => {
        const icon = button.querySelector('i');
        icon.classList.remove('fa-copy');
        icon.classList.add('fa-check');
        button.classList.add('copied');

        setTimeout(() => {
            icon.classList.remove('fa-check');
            icon.classList.add('fa-copy');
            button.classList.remove('copied');
        }, 2000);
    }).catch(err => {
        console.error('Failed to copy:', err);
    });
}

// Table of contents scroll spy
function updateTOC() {
    const toc = document.querySelector('.toc');
    if (!toc) return;

    const headings = document.querySelectorAll('h2[id], h3[id]');
    const tocLinks = toc.querySelectorAll('a');

    let current = '';

    headings.forEach(heading => {
        const rect = heading.getBoundingClientRect();
        if (rect.top <= 100) {
            current = heading.getAttribute('id');
        }
    });

    tocLinks.forEach(link => {
        link.classList.remove('active');
        if (link.getAttribute('href') === `#${current}`) {
            link.classList.add('active');
        }
    });
}

window.addEventListener('scroll', updateTOC);

// Console Easter Egg
console.log('%c🎓 GitHub Workshop Wiki', 'font-size: 20px; font-weight: bold; color: #6366f1;');
console.log('%cKapsamlı Git ve GitHub Eğitimi', 'font-size: 14px; color: #8b949e;');
console.log('%c👉 https://github.com/Furk4nBulut/Github-Workshop', 'font-size: 12px; color: #10b981;');

/* ===== Theme Logic ===== */
function initTheme() {
    const themeToggle = document.getElementById('themeToggle');
    const html = document.documentElement;
    const highlightTheme = document.getElementById('highlight-theme');

    // Check local storage or system preference
    const savedTheme = localStorage.getItem('theme');
    const systemTheme = window.matchMedia('(prefers-color-scheme: dark)').matches ? 'dark' : 'light';

    let currentTheme = savedTheme || systemTheme;
    html.setAttribute('data-theme', currentTheme);
    updateThemeIcon(currentTheme);
    updateHighlightTheme(highlightTheme, currentTheme);

    if (themeToggle) {
        themeToggle.addEventListener('click', () => {
            currentTheme = html.getAttribute('data-theme') === 'dark' ? 'light' : 'dark';
            html.setAttribute('data-theme', currentTheme);
            localStorage.setItem('theme', currentTheme);
            updateThemeIcon(currentTheme);
            updateHighlightTheme(highlightTheme, currentTheme);
        });
    }
}

function updateHighlightTheme(linkElement, theme) {
    if (!linkElement) return;
    const newTheme = theme === 'dark' ? 'github-dark' : 'github';
    linkElement.href = `https://cdnjs.cloudflare.com/ajax/libs/highlight.js/11.9.0/styles/${newTheme}.min.css`;
}

function updateThemeIcon(theme) {
    const themeToggle = document.getElementById('themeToggle');
    if (!themeToggle) return;

    const icon = themeToggle.querySelector('i');
    if (theme === 'dark') {
        icon.className = 'fas fa-moon';
    } else {
        icon.className = 'fas fa-sun';
    }
}

/* ===== Search Logic ===== */
function initSearch() {
    const searchInput = document.getElementById('searchInput');
    const searchResults = document.getElementById('searchResults');

    if (!searchInput || !searchResults) return;

    // Index content (h2, h3 in article)
    const headings = Array.from(document.querySelectorAll('.article h2, .article h3')).map(h => ({
        id: h.id,
        text: h.textContent,
        type: h.tagName.toLowerCase()
    }));

    searchInput.addEventListener('input', (e) => {
        const query = e.target.value.toLowerCase();

        if (query.length < 2) {
            searchResults.style.display = 'none';
            return;
        }

        const filtered = headings.filter(h => h.text.toLowerCase().includes(query));

        if (filtered.length > 0) {
            searchResults.innerHTML = filtered.map(item => `
                <a href="#${item.id}" class="search-result-item">
                    <span class="badgee ${item.type}">${item.type.toUpperCase()}</span>
                    ${item.text}
                </a>
            `).join('');
            searchResults.style.display = 'block';
        } else {
            searchResults.innerHTML = '<div class="no-results">Sonuç bulunamadı</div>';
            searchResults.style.display = 'block';
        }
    });

    // Close search on outside click
    document.addEventListener('click', (e) => {
        if (!searchInput.contains(e.target) && !searchResults.contains(e.target)) {
            searchResults.style.display = 'none';
        }
    });
}

/* ===== Progress Logic ===== */
function initProgress() {
    const article = document.querySelector('.article');
    if (!article) return;

    // Create progress bar
    const bar = document.createElement('div');
    bar.className = 'progress-bar';
    document.body.appendChild(bar);

    window.addEventListener('scroll', () => {
        const winScroll = document.body.scrollTop || document.documentElement.scrollTop;
        const height = document.documentElement.scrollHeight - document.documentElement.clientHeight;
        const scrolled = (winScroll / height) * 100;
        bar.style.width = scrolled + "%";

        // Mark as completed in local storage if > 80%
        if (scrolled > 80) {
            const page = window.location.pathname.split('/').pop() || 'index.html';
            if (page.startsWith('module')) {
                const completed = JSON.parse(localStorage.getItem('completedModules') || '[]');
                if (!completed.includes(page)) {
                    completed.push(page);
                    localStorage.setItem('completedModules', JSON.stringify(completed));
                    markCompletedSidebar();
                }
            }
        }
    });

    markCompletedSidebar();
}

function markCompletedSidebar() {
    const completed = JSON.parse(localStorage.getItem('completedModules') || '[]');
    completed.forEach(page => {
        const link = document.querySelector(`.nav-item[href="${page}"]`);
        if (link && !link.querySelector('.check-icon')) {
            const check = document.createElement('i');
            check.className = 'fas fa-check-circle check-icon';
            check.style.marginLeft = 'auto';
            check.style.color = 'var(--secondary)';
            link.appendChild(check);
        }
    });
}
