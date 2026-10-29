/* =========================================

1. CSS VARIABLES AND THEMING
   ========================================= */

:root {
color-scheme: light;

```
--primary: #6c5ce7;
--primary-hover: #5142c4;
--accent: #00bfa6;

--bg: #f8f9ff;
--surface: #ffffff;
--surface-soft: #f0efff;

--text: #20243a;
--text-muted: #626980;
--border: #e2e5f0;

--header-bg: rgba(255, 255, 255, 0.88);
--footer-bg: #17182d;
--footer-text: #f7f7ff;

--shadow-sm: 0 5px 20px rgba(30, 35, 70, 0.05);
--shadow-lg: 0 20px 60px rgba(30, 35, 70, 0.12);

--radius-sm: 10px;
--radius-md: 18px;
--radius-lg: 28px;

--container: 1160px;
--header-height: 76px;

--transition: 220ms ease;
```

}

/* Dark Theme */

html[data-theme="dark"] {
color-scheme: dark;

```
--bg: #10111c;
--surface: #191b2b;
--surface-soft: #24213d;

--text: #f0f1ff;
--text-muted: #b7bbd0;
--border: #34364b;

--header-bg: rgba(16, 17, 28, 0.92);
--footer-bg: #090a12;
--footer-text: #f7f7ff;

--shadow-sm: 0 5px 20px rgba(0, 0, 0, 0.15);
--shadow-lg: 0 20px 60px rgba(0, 0, 0, 0.25);
```

}

/* =========================================
2. RESET AND BASE STYLES
========================================= */

*,
*::before,
*::after {
box-sizing: border-box;
}

html {
scroll-behavior: smooth;
scroll-padding-top: calc(var(--header-height) + 20px);
}

body {
margin: 0;
font-family:
Inter,
"Segoe UI",
Arial,
sans-serif;

```
font-size: 16px;
line-height: 1.7;

color: var(--text);
background: var(--bg);

transition:
    background-color var(--transition),
    color var(--transition);
```

}

h1,
h2,
h3,
p {
margin-top: 0;
}

h1,
h2,
h3 {
line-height: 1.2;
color: var(--text);
}

h1 {
font-size: clamp(2.7rem, 7vw, 5.4rem);
letter-spacing: -0.055em;
margin-bottom: 24px;
}

h2 {
font-size: clamp(2rem, 4.5vw, 3.4rem);
letter-spacing: -0.035em;
margin-bottom: 20px;
}

h3 {
font-size: 1.3rem;
margin-bottom: 12px;
}

p {
color: var(--text-muted);
}

a {
color: inherit;
text-underline-offset: 4px;
}

button,
input,
textarea {
font: inherit;
}

button,
a {
-webkit-tap-highlight-color: transparent;
}

button:focus-visible,
a:focus-visible,
input:focus-visible,
textarea:focus-visible {
outline: 3px solid #ffbf47;
outline-offset: 4px;
}

button {
color: inherit;
}

.container {
width: min(var(--container), calc(100% - 40px));
margin-inline: auto;
}

.section {
padding-block: clamp(76px, 10vw, 125px);
}

.skip-link {
position: fixed;
top: 12px;
left: 12px;
z-index: 2000;

```
padding: 12px 18px;
border-radius: var(--radius-sm);

color: #ffffff;
background: #20243a;

transform: translateY(-160%);
```

}

.skip-link:focus {
transform: translateY(0);
}

.eyebrow {
margin-bottom: 14px;

```
color: var(--primary);
font-size: 0.78rem;
font-weight: 800;
letter-spacing: 2.5px;
```

}

.gradient-text {
color: var(--primary);
background: linear-gradient(100deg, #7967ff, #00a994);
background-clip: text;
-webkit-background-clip: text;
-webkit-text-fill-color: transparent;
}

/* =========================================
3. HEADER AND FLEXBOX NAVIGATION
========================================= */

.header {
position: sticky;
top: 0;
z-index: 1000;

```
min-height: var(--header-height);

background: var(--header-bg);
border-bottom: 1px solid var(--border);

-webkit-backdrop-filter: blur(18px);
backdrop-filter: blur(18px);
```

}

.navbar {
min-height: var(--header-height);

```
display: flex;
align-items: center;
justify-content: space-between;
gap: 24px;
```

}

.logo {
color: var(--text);
font-size: 1.55rem;
font-weight: 900;
letter-spacing: -1px;
text-decoration: none;
white-space: nowrap;
}

.logo span {
color: var(--primary);
}

.nav-links {
display: flex;
align-items: center;
gap: clamp(16px, 2.5vw, 32px);

```
margin: 0;
padding: 0;
list-style: none;
```

}

.nav-links a {
position: relative;

```
color: var(--text-muted);
font-size: 0.94rem;
font-weight: 650;

text-decoration: none;
transition: color var(--transition);
```

}

.nav-links a::after {
position: absolute;
right: 0;
bottom: -7px;
left: 0;

```
height: 2px;
content: "";

background: var(--primary);

transform: scaleX(0);
transform-origin: left;

transition: transform var(--transition);
```

}

.nav-links a:hover {
color: var(--primary);
}

.nav-links a:hover::after {
transform: scaleX(1);
}

.nav-actions {
display: flex;
align-items: center;
gap: 12px;
}

.theme-toggle,
.menu-toggle {
width: 44px;
height: 44px;

```
display: grid;
place-items: center;

border: 1px solid var(--border);
border-radius: 12px;

background: var(--surface);
cursor: pointer;

transition:
    background-color var(--transition),
    border-color var(--transition),
    transform var(--transition);
```

}

.theme-toggle {
font-size: 1.4rem;
}

.theme-toggle:hover,
.menu-toggle:hover {
transform: translateY(-2px);
border-color: var(--primary);
}

.menu-toggle {
display: none;
padding: 10px;
}

.menu-toggle span {
display: block;
width: 100%;
height: 2px;
border-radius: 2px;
background: var(--text);
}

/* =========================================
4. HERO SECTION — CSS GRID
========================================= */

.hero {
position: relative;
isolation: isolate;
overflow: clip;

```
background:
    radial-gradient(
        ellipse at 5% 10%,
        rgba(108, 92, 231, 0.10),
        transparent 42%
    ),
    var(--bg);
```

}

.hero-grid {
display: grid;
grid-template-columns: minmax(0, 1.1fr) minmax(300px, 0.9fr);
align-items: center;
gap: clamp(40px, 7vw, 95px);
}

.badge {
display: inline-flex;
align-items: center;
gap: 8px;

```
padding: 8px 14px;
margin-bottom: 28px;

color: var(--primary);
background: var(--surface-soft);

border: 1px solid var(--border);
border-radius: 100px;

font-size: 0.8rem;
font-weight: 750;
```

}

.hero-content h1 {
overflow-wrap: anywhere;
}

.hero-content h1 .gradient-text {
display: block;
margin-top: 10px;
}

.hero-description {
max-width: 570px;
margin-bottom: 32px;

```
font-size: clamp(1rem, 2vw, 1.12rem);
line-height: 1.9;
```

}

.hero-actions {
display: flex;
flex-wrap: wrap;
align-items: center;
gap: 14px;
}

.btn {
min-height: 50px;

```
display: inline-flex;
justify-content: center;
align-items: center;
gap: 10px;

padding: 13px 23px;

border: 1px solid transparent;
border-radius: 12px;

font-size: 0.95rem;
font-weight: 750;
text-decoration: none;

cursor: pointer;

transition:
    transform var(--transition),
    background-color var(--transition),
    box-shadow var(--transition);
```

}

.btn:hover {
transform: translateY(-3px);
}

.btn-primary {
color: #ffffff;
background: var(--primary);
box-shadow: 0 8px 24px rgba(108, 92, 231, 0.23);
}

.btn-primary:hover {
color: #ffffff;
background: var(--primary-hover);
box-shadow: 0 12px 30px rgba(108, 92, 231, 0.3);
}

.btn-outline {
color: var(--text);
background: var(--surface);
border-color: var(--border);
}

.btn-outline:hover {
border-color: var(--primary);
}

.hero-stats {
display: flex;
flex-wrap: wrap;
gap: 34px;

```
margin-top: 50px;
padding-top: 25px;

border-top: 1px solid var(--border);
```

}

.hero-stats div {
display: flex;
flex-direction: column;
gap: 3px;
}

.hero-stats strong {
color: var(--text);
font-size: 1.65rem;
line-height: 1.3;
}

.hero-stats span {
color: var(--text-muted);
font-size: 0.8rem;
}

/* =========================================
5. HERO VISUAL
========================================= */

.hero-visual {
position: relative;
isolation: isolate;

```
display: grid;
place-items: center;

min-width: 0;
padding: 35px 10px;
```

}

.visual-glow {
position: absolute;
z-index: -1;

```
width: min(90%, 400px);
aspect-ratio: 1;

background: linear-gradient(
    135deg,
    rgba(108, 92, 231, 0.35),
    rgba(0, 191, 166, 0.25)
);

border-radius: 50%;
filter: blur(65px);
```

}

.profile-card {
width: min(100%, 365px);
padding: 26px;

```
text-align: center;

background: var(--surface);
border: 1px solid var(--border);
border-radius: var(--radius-lg);

box-shadow: var(--shadow-lg);

transform: rotate(2deg);
transition: transform 350ms ease;
```

}

.profile-card:hover {
transform: rotate(0deg) translateY(-5px);
}

.profile-top {
display: flex;
align-items: center;
gap: 6px;

```
margin-bottom: 30px;
```

}

.window-dot {
width: 9px;
height: 9px;
border-radius: 50%;
background: var(--border);
}

.profile-label {
margin-left: auto;
color: var(--text-muted);
font-size: 0.68rem;
font-weight: 800;
letter-spacing: 1.3px;
}

.avatar {
width: 115px;
aspect-ratio: 1;

```
display: grid;
place-items: center;

margin: 0 auto 20px;

color: #ffffff;
background: linear-gradient(135deg, #7967ff, #00bfa6);

border: 6px solid var(--surface-soft);
border-radius: 50%;

font-size: 2.6rem;
font-weight: 900;
```

}

.profile-card h2 {
margin-bottom: 8px;
font-size: 1.65rem;
}

.profile-card > p {
margin-bottom: 25px;
}

.code-card {
padding: 17px;

```
text-align: left;

background: var(--surface-soft);
border: 1px solid var(--border);
border-radius: 12px;

overflow-wrap: anywhere;
```

}

.code-card p {
margin-bottom: 5px;
color: var(--text);
font-family: "Courier New", monospace;
font-size: 0.78rem;
}

.code-card p:last-child {
margin-bottom: 0;
}

.code-purple {
color: #9b70ff;
}

.code-green {
color: #00a994;
}

.code-orange {
color: #d98c35;
}

.floating-card {
position: absolute;

```
display: flex;
align-items: center;
gap: 9px;

padding: 12px 17px;

color: var(--text);
background: var(--surface);
border: 1px solid var(--border);
border-radius: 13px;

box-shadow: var(--shadow-lg);

font-size: 0.85rem;
font-weight: 750;
```

}

.floating-card span {
color: var(--primary);
font-size: 1.1rem;
}

.floating-one {
top: 15%;
left: -3%;
}

.floating-two {
right: -2%;
bottom: 15%;
}

/* =========================================
6. SECTION HEADINGS
========================================= */

.section-heading {
max-width: 720px;
margin: 0 auto 55px;
text-align: center;
}

.section-heading h2 {
margin-bottom: 18px;
}

.section-heading > p:last-child {
max-width: 570px;
margin-inline: auto;
margin-bottom: 0;
}

/* =========================================
7. ABOUT — CSS GRID
========================================= */

.about-section {
background: var(--surface);
}

.about-grid {
display: grid;
grid-template-columns: repeat(2, minmax(0, 1fr));
gap: 25px;
}

.glass-card {
background: var(--bg);
border: 1px solid var(--border);
border-radius: var(--radius-md);
}

.about-card {
padding: clamp(25px, 4vw, 40px);
transition:
transform var(--transition),
box-shadow var(--transition);
}

.about-card:hover {
transform: translateY(-5px);
box-shadow: var(--shadow-sm);
}

.card-icon {
width: 55px;
height: 55px;

```
display: grid;
place-items: center;

margin-bottom: 23px;

color: var(--primary);
background: var(--surface-soft);

border-radius: 15px;
font-size: 1.6rem;
```

}

.about-card p {
margin-bottom: 0;
}

/* =========================================
8. SKILLS — AUTO-FIT GRID
========================================= */

.skills-grid {
display: grid;

```
grid-template-columns: repeat(
    auto-fit,
    minmax(min(100%, 210px), 1fr)
);

gap: 20px;
```

}

.skill-card {
min-width: 0;
padding: 30px 20px;

```
text-align: center;

background: var(--surface);
border: 1px solid var(--border);
border-radius: var(--radius-md);

transition:
    transform var(--transition),
    box-shadow var(--transition),
    border-color var(--transition);
```

}

.skill-card:hover {
transform: translateY(-7px);
border-color: var(--primary);
box-shadow: var(--shadow-sm);
}

.skill-icon {
width: 68px;
height: 68px;

```
display: grid;
place-items: center;

margin: 0 auto 22px;

border-radius: 20px;

color: #ffffff;
font-size: 1.5rem;
font-weight: 900;
```

}

.html-icon {
background: linear-gradient(135deg, #f16529, #e44d26);
}

.css-icon {
background: linear-gradient(135deg, #2965f1, #1746b2);
}

.js-icon {
color: #20243a;
background: linear-gradient(135deg, #f7df1e, #f0c800);
}

.ui-icon {
background: linear-gradient(135deg, #8b5cf6, #6c5ce7);
}

.skill-card h3 {
margin-bottom: 8px;
}

.skill-card p {
margin-bottom: 0;
font-size: 0.9rem;
}

/* =========================================
9. PROJECTS — RESPONSIVE GRID
========================================= */

.projects-section {
background: var(--surface);
}

.projects-grid {
display: grid;
grid-template-columns: repeat(3, minmax(0, 1fr));
gap: 25px;
}

.project-card {
min-width: 0;
overflow: hidden;

```
background: var(--bg);
border: 1px solid var(--border);
border-radius: var(--radius-md);

box-shadow: var(--shadow-sm);

transition:
    transform var(--transition),
    box-shadow var(--transition);
```

}

.project-card:hover {
transform: translateY(-7px);
box-shadow: var(--shadow-lg);
}

.project-art {
position: relative;
min-height: 210px;

```
display: grid;
place-items: center;

overflow: hidden;
```

}

.project-art::before,
.project-art::after {
position: absolute;
content: "";
border: 1px solid rgba(255, 255, 255, 0.3);
border-radius: 50%;
}

.project-art::before {
width: 220px;
height: 220px;
}

.project-art::after {
width: 150px;
height: 150px;
}

.project-art-one {
background: linear-gradient(135deg, #5142c4, #a29bfe);
}

.project-art-two {
background: linear-gradient(135deg, #087f8c, #00bfa6);
}

.project-art-three {
background: linear-gradient(135deg, #c24178, #fb7185);
}

.project-number {
position: absolute;
top: 18px;
left: 20px;

```
color: rgba(255, 255, 255, 0.9);
font-size: 0.8rem;
font-weight: 800;
```

}

.project-symbol {
z-index: 1;
color: #ffffff;
font-size: 4rem;
font-weight: 900;
}

.project-info {
padding: 26px;
}

.project-category {
margin-bottom: 12px;

```
color: var(--primary);
font-size: 0.72rem;
font-weight: 850;
letter-spacing: 1.5px;
```

}

.project-info h3 {
font-size: 1.4rem;
}

.project-info > p:not(.project-category) {
font-size: 0.93rem;
}

.tag-list {
display: flex;
flex-wrap: wrap;
gap: 8px;

```
padding: 0;
margin: 22px 0;

list-style: none;
```

}

.tag-list li {
padding: 5px 10px;

```
color: var(--primary);
background: var(--surface-soft);

border: 1px solid var(--border);
border-radius: 7px;

font-size: 0.75rem;
font-weight: 750;
```

}

.project-link {
display: inline-flex;
align-items: center;
gap: 8px;

```
color: var(--primary);
font-size: 0.9rem;
font-weight: 800;

text-decoration: none;
```

}

.project-link:hover {
text-decoration: underline;
}

/* =========================================
10. CONTACT — CSS GRID + FLEXBOX
========================================= */

.contact-grid {
display: grid;
grid-template-columns: minmax(0, 0.8fr) minmax(0, 1.2fr);
align-items: start;
gap: clamp(35px, 7vw, 90px);
}

.contact-content h2 {
max-width: 500px;
}

.contact-content > p:not(.eyebrow) {
max-width: 440px;
margin-bottom: 30px;
}

.contact-email {
display: inline-block;
max-width: 100%;

```
color: var(--primary);
font-weight: 800;

overflow-wrap: anywhere;
```

}

.contact-form {
min-width: 0;
padding: clamp(22px, 4vw, 38px);

```
box-shadow: var(--shadow-sm);
```

}

.form-row {
display: grid;
grid-template-columns: repeat(2, minmax(0, 1fr));
gap: 18px;
}

.form-group {
min-width: 0;
margin-bottom: 22px;
}

.form-group label {
display: block;
margin-bottom: 8px;

```
color: var(--text);
font-size: 0.9rem;
font-weight: 750;
```

}

.form-group input,
.form-group textarea {
display: block;
width: 100%;
min-height: 50px;

```
padding: 13px 15px;

color: var(--text);
background: var(--surface);

border: 1px solid var(--border);
border-radius: 10px;

transition:
    border-color var(--transition),
    box-shadow var(--transition);
```

}

.form-group textarea {
min-height: 145px;
resize: vertical;
}

.form-group input::placeholder,
.form-group textarea::placeholder {
color: var(--text-muted);
opacity: 1;
}

.form-group input:focus,
.form-group textarea:focus {
border-color: var(--primary);
box-shadow: 0 0 0 3px rgba(108, 92, 231, 0.12);
}

.submit-btn {
width: 100%;
}

.form-status {
margin: 15px 0 0;
font-weight: 700;
}

.form-note {
margin: 12px 0 0;
font-size: 0.8rem;
}

/* =========================================
11. FOOTER — FLEXBOX
========================================= */

.footer {
padding-block: 28px;
background: var(--footer-bg);
}

.footer-inner {
display: flex;
align-items: center;
justify-content: space-between;
gap: 24px;
}

.footer-logo {
color: var(--footer-text);
}

.footer-inner p {
margin: 0;
color: var(--footer-text);
font-size: 0.85rem;
}

.back-top {
color: var(--footer-text);
font-size: 0.85rem;
font-weight: 750;
text-decoration: none;
}

.back-top:hover {
text-decoration: underline;
}

/* =========================================
12. TABLET RESPONSIVE LAYOUT
========================================= */

@media (max-width: 960px) {

```
:root {
    --header-height: 72px;
}

.hero-grid {
    grid-template-columns: minmax(0, 1fr) minmax(260px, 0.8fr);
    gap: 30px;
}

.hero-stats {
    gap: 22px;
}

.projects-grid {
    grid-template-columns: repeat(2, minmax(0, 1fr));
}

.projects-grid .project-card:last-child {
    grid-column: 1 / -1;
    width: min(100%, 520px);
    justify-self: center;
}

.contact-grid {
    gap: 35px;
}
```

}

/* =========================================
13. MOBILE NAVIGATION AND LAYOUT
========================================= */

@media (max-width: 720px) {

```
.container {
    width: min(var(--container), calc(100% - 32px));
}

.menu-toggle {
    display: flex;
    flex-direction: column;
    justify-content: center;
    gap: 5px;
}

.menu-toggle span {
    flex: 0 0 2px;
    transition:
        transform var(--transition),
        opacity var(--transition);
}

.menu-toggle[aria-expanded="true"] span:first-child {
    transform: translateY(7px) rotate(45deg);
}

.menu-toggle[aria-expanded="true"] span:nth-child(2) {
    opacity: 0;
}

.menu-toggle[aria-expanded="true"] span:last-child {
    transform: translateY(-7px) rotate(-45deg);
}

.navigation {
    position: absolute;
    top: 100%;
    right: 0;
    left: 0;

    display: none;

    padding: 16px 20px 24px;

    background: var(--surface);
    border-bottom: 1px solid var(--border);
    box-shadow: var(--shadow-lg);
}

.navigation.is-open {
    display: block;
}

.nav-links {
    flex-direction: column;
    align-items: stretch;
    gap: 0;
}

.nav-links li {
    width: 100%;
}

.nav-links a {
    display: block;
    padding: 12px 8px;
}

.nav-links a::after {
    display: none;
}

.hero-grid {
    grid-template-columns: minmax(0, 1fr);
    gap: 35px;
}

.hero-content {
    text-align: center;
}

.hero-description {
    margin-inline: auto;
}

.hero-actions {
    justify-content: center;
}

.hero-stats {
    justify-content: center;
    text-align: left;
}

.hero-visual {
    width: min(100%, 460px);
    margin-inline: auto;
}

.about-grid {
    grid-template-columns: minmax(0, 1fr);
}

.contact-grid {
    grid-template-columns: minmax(0, 1fr);
}

.contact-content {
    text-align: center;
}

.contact-content h2,
.contact-content > p:not(.eyebrow) {
    margin-inline: auto;
}
```

}

/* =========================================
14. SMALL MOBILE SCREENS
========================================= */

@media (max-width: 480px) {

```
.section {
    padding-block: 72px;
}

.hero-content h1 {
    font-size: clamp(2.45rem, 12vw, 3.5rem);
}

.hero-actions {
    flex-direction: column;
    align-items: stretch;
}

.hero-actions .btn {
    width: 100%;
}

.hero-stats {
    gap: 18px;
}

.hero-stats strong {
    font-size: 1.35rem;
}

.hero-stats span {
    font-size: 0.72rem;
}

.profile-card {
    padding: 20px;
}

.floating-card {
    padding: 9px 12px;
    font-size: 0.75rem;
}

.floating-one {
    left: 0;
}

.floating-two {
    right: 0;
}

.projects-grid {
    grid-template-columns: minmax(0, 1fr);
}

.projects-grid .project-card:last-child {
    grid-column: auto;
    width: 100%;
}

.form-row {
    grid-template-columns: minmax(0, 1fr);
    gap: 0;
}

.footer-inner {
    flex-direction: column;
    text-align: center;
    gap: 14px;
}
```

}

/* =========================================
15. ACCESSIBILITY: REDUCED MOTION
========================================= */

@media (prefers-reduced-motion: reduce) {

```
html {
    scroll-behavior: auto;
}

*,
*::before,
*::after {
    animation-duration: 0.01ms !important;
    animation-iteration-count: 1 !important;
    transition-duration: 0.01ms !important;
    scroll-behavior: auto !important;
}
```

}
