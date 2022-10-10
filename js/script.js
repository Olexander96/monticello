document.addEventListener('DOMContentLoaded', function() {

    const HEADER = document.querySelector('.header');
    const NAV = document.querySelector('.header__nav');
    const CONTACTS = document.querySelector('.header__contacts');
    const MENU_BUTTON = document.querySelector('.header__menu-button');

    function addActiveClasses() {
        HEADER.classList.toggle('header--active');
        NAV.classList.toggle('header__nav--active');
        CONTACTS.classList.toggle('header__contacts--active');
        MENU_BUTTON.classList.toggle('header__menu-button--active');
        document.body.classList.toggle('no-scroll');
    }

    MENU_BUTTON.addEventListener('click', addActiveClasses)

    $('.hero__slider').slick({
        arrows: false,
        dots: true,
        infinite: true,
        slidesToShow: 1,
        slidesToScroll: 1,
        vertical: true,
        // autoplay:true,
        // autoplaySpeed: 5000,
        verticalSwiping: true,
    });


})
