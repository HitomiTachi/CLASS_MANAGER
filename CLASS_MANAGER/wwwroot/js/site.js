// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// wwwroot/js/site.js
(function () {
    'use strict';

    // Initialize tooltips if any
    function initTooltips() {
        const tooltips = document.querySelectorAll('[data-toggle="tooltip"]');
        if (tooltips.length > 0) {
            Array.from(tooltips).forEach(function (tooltip) {
                tooltip.addEventListener('mouseover', function () {
                    const title = this.getAttribute('title');
                    if (title) {
                        const tooltipEl = document.createElement('div');
                        tooltipEl.className = 'tooltip';
                        tooltipEl.innerHTML = title;
                        document.body.appendChild(tooltipEl);

                        const rect = this.getBoundingClientRect();
                        tooltipEl.style.top = (rect.top - tooltipEl.offsetHeight - 10) + 'px';
                        tooltipEl.style.left = (rect.left + (rect.width / 2) - (tooltipEl.offsetWidth / 2)) + 'px';

                        this.onmouseout = function () {
                            document.body.removeChild(tooltipEl);
                        };
                    }
                });
            });
        }
    }

    // Toggle mobile menu
    function initMobileMenu() {
        const menuToggle = document.querySelector('.menu-toggle');
        if (menuToggle) {
            menuToggle.addEventListener('click', function () {
                const menuList = document.querySelector('.menu-list');
                if (menuList) {
                    menuList.classList.toggle('show');
                }
            });
        }
    }

    // Add active class to current menu item
    function setActiveMenuItem() {
        const currentPath = window.location.pathname;
        const menuItems = document.querySelectorAll('.menu-list li a');

        menuItems.forEach(function (item) {
            const href = item.getAttribute('href');
            if (href === currentPath || (currentPath.includes(href) && href !== '#' && href !== '/')) {
                item.parentElement.classList.add('active');
            }
        });
    }

    // Form validation
    function initFormValidation() {
        const forms = document.querySelectorAll('form.needs-validation');
        Array.from(forms).forEach(function (form) {
            form.addEventListener('submit', function (event) {
                if (!form.checkValidity()) {
                    event.preventDefault();
                    event.stopPropagation();
                }
                form.classList.add('was-validated');
            }, false);
        });
    }

    // Document ready
    document.addEventListener('DOMContentLoaded', function () {
        initTooltips();
        initMobileMenu();
        setActiveMenuItem();
        initFormValidation();
    });
})();