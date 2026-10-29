"use strict";

// ====================================
// 1. LIGHT / DARK THEME
// ====================================

const themeToggle = document.getElementById("theme-toggle");
const themeIcon = document.getElementById("theme-icon");

const savedTheme = localStorage.getItem("portfolio-theme");

const systemPrefersDark = window.matchMedia(
"(prefers-color-scheme: dark)"
).matches;

const initialTheme =
savedTheme || (systemPrefersDark ? "dark" : "light");

function applyTheme(theme) {
const isDark = theme === "dark";

```
document.documentElement.setAttribute("data-theme", theme);

themeIcon.textContent = isDark ? "☀" : "☾";

themeToggle.setAttribute(
    "aria-label",
    isDark ? "Switch to light theme" : "Switch to dark theme"
);

themeToggle.setAttribute("aria-pressed", String(isDark));

const themeColor = document.querySelector(
    'meta[name="theme-color"]'
);

if (themeColor) {
    themeColor.setAttribute(
        "content",
        isDark ? "#10111c" : "#f8f9ff"
    );
}
```

}

applyTheme(initialTheme);

themeToggle.addEventListener("click", function () {
const currentTheme =
document.documentElement.getAttribute("data-theme");

```
const nextTheme =
    currentTheme === "dark" ? "light" : "dark";

applyTheme(nextTheme);

try {
    localStorage.setItem("portfolio-theme", nextTheme);
} catch (error) {
    // Theme switching still works if storage is unavailable.
}
```

});

// ====================================
// 2. RESPONSIVE MOBILE NAVIGATION
// ====================================

const menuToggle = document.getElementById("menu-toggle");
const navigation = document.getElementById("navigation");

const navLinks = navigation.querySelectorAll("a");

function closeNavigation() {
navigation.classList.remove("is-open");

```
menuToggle.setAttribute("aria-expanded", "false");
menuToggle.setAttribute("aria-label", "Open navigation menu");
```

}

menuToggle.addEventListener("click", function () {
const isOpen =
menuToggle.getAttribute("aria-expanded") === "true";

```
menuToggle.setAttribute("aria-expanded", String(!isOpen));

menuToggle.setAttribute(
    "aria-label",
    isOpen ? "Open navigation menu" : "Close navigation menu"
);

navigation.classList.toggle("is-open", !isOpen);
```

});

navLinks.forEach(function (link) {
link.addEventListener("click", closeNavigation);
});

document.addEventListener("keydown", function (event) {
if (event.key === "Escape") {
const menuWasOpen =
menuToggle.getAttribute("aria-expanded") === "true";

```
    closeNavigation();

    if (menuWasOpen) {
        menuToggle.focus();
    }
}
```

});

window.addEventListener("resize", function () {
if (window.innerWidth > 720) {
closeNavigation();
}
});

// ====================================
// 3. AUTOMATIC FOOTER YEAR
// ====================================

const yearElement = document.getElementById("current-year");

yearElement.textContent = new Date().getFullYear();

// ====================================
// 4. CONTACT FORM VALIDATION
// ====================================

const contactForm = document.getElementById("contact-form");
const formStatus = document.getElementById("form-status");

contactForm.addEventListener("submit", function (event) {
event.preventDefault();

```
formStatus.textContent = "";

if (!contactForm.checkValidity()) {
    contactForm.reportValidity();

    formStatus.textContent =
        "Please check the form fields and correct any errors.";

    return;
}

const name = document.getElementById("name").value.trim();
const email = document.getElementById("email").value.trim();
const message = document.getElementById("message").value.trim();

if (name.length < 2 || email.length === 0 || message.length < 10) {
    formStatus.textContent =
        "Please provide a valid name, email, and message.";

    return;
}

formStatus.textContent =
    "Form validated successfully! This demo does not send messages.";

contactForm.reset();
```

});
