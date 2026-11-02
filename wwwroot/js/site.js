// Site-wide JavaScript. Bootstrap's bundle (with Popper) and jQuery are loaded from /lib.
$(function () {
    // Highlight the nav link that matches the current URL
    var path = window.location.pathname.toLowerCase();
    $('.gv-navbar .nav-link').each(function () {
        var href = ($(this).attr('href') || '').toLowerCase();
        if (href !== '' && (href === path || (href !== '/' && path.indexOf(href) === 0))) {
            $(this).addClass('active');
        }
    });
});
