document.addEventListener('DOMContentLoaded', function() {

    //для бургер меню
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

    //закривання бургера після натистання на ссилку та розблокування скролу
    const NAV_ITEM = document.querySelectorAll('.nav-item');

    function removeActiveClasses() {
        HEADER.classList.remove('header--active');
        NAV.classList.remove('header__nav--active');
        CONTACTS.classList.remove('header__contacts--active');
        MENU_BUTTON.classList.remove('header__menu-button--active');
        document.body.classList.remove('no-scroll');
    }

    NAV_ITEM.forEach(item => {
        item.addEventListener('click', removeActiveClasses)
    })

    //слайдери
    $('.hero__slider').slick({
        arrows: false,
        dots: true,
        infinite: true,
        slidesToShow: 1,
        slidesToScroll: 1,
        vertical: true,
        autoplay:true,
        autoplaySpeed: 5000,
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

    //google maps
        let CENTER = { lat: 40.66792059277497, lng: -73.87318649683662 };
        let ADRESS = { lat: 40.67875856475177, lng: -73.89727512510254 };
        
        const MARKER_IMG = {
            url: "./img/map-flag-icon.svg",
            size: new google.maps.Size(106, 106),
        };
    
        let MAP = new google.maps.Map(document.getElementById("map"), {
            center: CENTER,
            zoom: 13.5
        });

        let marker = new google.maps.Marker({
            position: ADRESS,
            map: MAP,
            icon: MARKER_IMG,
            title: ADRESS,
            animation: google.maps.Animation.DROP
        });    

        const INFO = new google.maps.InfoWindow({
            content: '<h3 class="info-wondow-text">Monticello</h3>'
        })

        marker.addListener('click', function () {
            INFO.open(MAP, marker);
        })
    
})
