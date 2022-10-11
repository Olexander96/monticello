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

    $('.news-slider').slick({
        infinite: true,
        dots: true,
        slidesToShow: 3,
        slidesToScroll: 1,
        prevArrow: '<img src="img/news-arrow-left.svg" alt="slick-arrow" class="arrow-left">',
        nextArrow: '<img src="img/news-arrow-right.svg" alt="slick-arrow" class="arrow-right">',
        centerMode: false,
        autoplay: true,
        autoplaySpeed: 5000,
        responsive: [
            {
                breakpoint: 1200,
                settings: {
                    autoplay: true,
                    centerMode: false,
                    arrows: true,
                    dots: true,
                    centerMode: false,
                    slidesToShow: 2,
                    slidesToScroll: 1,
                    infinite: true,
                }
            },
            {
                breakpoint: 768,
                settings: {
                    autoplay: true,
                    centerMode: false,
                    arrows: false,
                    dots: true,
                    centerMode: false,
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    infinite: true,
                }
            }
          ]

    });


})
