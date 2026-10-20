// Lakbay: small progressive enhancements. Everything works without this file.
(function () {
    "use strict";

    // Header gets a soft shadow once the page scrolls.
    function onScroll() {
        document.documentElement.setAttribute("data-scrolled", window.scrollY > 8 ? "true" : "false");
    }
    window.addEventListener("scroll", onScroll, { passive: true });
    document.addEventListener("DOMContentLoaded", onScroll);

    // Called from Blazor when a drawer or reader opens/closes.
    window.lakbay = {
        openOverlay: function (id) {
            document.body.classList.add("is-locked");
            var el = document.getElementById(id);
            if (el) { el.focus({ preventScroll: true }); el.scrollTop = 0; }
        },
        closeOverlay: function () {
            document.body.classList.remove("is-locked");
        }
    };
})();
