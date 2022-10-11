html,
body,
div,
span,
applet,
object,
iframe,
h1,
h2,
h3,
h4,
h5,
h6,
p,
blockquote,
pre,
a,
abbr,
acronym,
address,
big,
cite,
code,
del,
dfn,
em,
img,
ins,
kbd,
q,
s,
samp,
small,
strike,
strong,
sub,
sup,
tt,
var,
b,
u,
i,
center,
dl,
dt,
dd,
ol,
ul,
li,
fieldset,
form,
label,
legend,
table,
caption,
tbody,
tfoot,
thead,
tr,
th,
td,
article,
aside,
canvas,
details,
embed,
figure,
figcaption,
footer,
header,
hgroup,
menu,
nav,
output,
ruby,
section,
summary,
time,
mark,
audio,
video {
  margin: 0;
  padding: 0;
  border: 0;
  font-size: 100%;
  font: inherit;
  vertical-align: baseline;
}

/* HTML5 display-role reset for older browsers */
article,
aside,
details,
figcaption,
figure,
footer,
header,
hgroup,
menu,
nav,
section {
  display: block;
}

body {
  line-height: 1;
}

ol,
ul {
  list-style: none;
}

blockquote,
q {
  quotes: none;
}

blockquote:before,
blockquote:after,
q:before,
q:after {
  content: "";
  content: none;
}

table {
  border-collapse: collapse;
  border-spacing: 0;
}

* {
  box-sizing: border-box;
  line-height: 1;
  scroll-behavior: smooth;
}

.container {
  max-width: 1200px;
  margin: 0 auto;
}

.visually-hidden {
  position: absolute;
  width: 1px;
  height: 1px;
  margin: -1px;
  padding: 0;
  border: 0;
  clip: rect(0 0 0 0);
  overflow: hidden;
}

.no-scroll {
  overflow: hidden;
}

.header {
  width: 100%;
  padding: 53px 15px 10px;
  background-color: transparent;
  z-index: 10;
  transition: 1s;
}
.header .container {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  max-width: 1200px;
  align-items: center;
}
.header__logo {
  width: 180px;
  height: 40px;
}
.header__nav {
  display: none;
}
.header__nav-list {
  display: flex;
  flex-direction: column;
  align-items: center;
}
.header__nav-list .nav-item {
  text-transform: uppercase;
  display: flex;
  flex-direction: row;
}
.header__nav-list .nav-item__link {
  font-style: normal;
  font-weight: 400;
  font-size: 14px;
  color: #fff;
  font-family: "Source Sans Pro", "Arial", sans-serif;
  text-decoration: none;
}
.header__nav-list .nav-item__link::before {
  content: "";
  display: inline-block;
  width: 9px;
  height: 9px;
  border: 1px solid #fff;
  border-radius: 50%;
  margin-right: 14px;
  background-color: transparent;
}
.header__nav-list .nav-item__link:hover::before {
  background-color: #fff;
}
.header__nav-list .nav-item:not(:last-child) {
  margin-bottom: 25px;
}
.header__contacts {
  display: none;
  flex-direction: row;
}
.header__contacts .contact-link {
  display: flex;
  align-items: center;
  justify-content: center;
  width: 40px;
  height: 40px;
  border-radius: 50%;
  border: 1px solid #fff;
}
.header__contacts .contact-link .facebook {
  width: 10px;
  height: 18px;
}
.header__contacts .contact-link .twitter {
  width: 16px;
  height: 18px;
}
.header__contacts .contact-link .instagram {
  width: 14px;
  height: 18px;
}
.header__contacts .contact-link:not(:last-child) {
  margin-right: 20px;
}

.header--active {
  height: 100vh;
  background-color: #7E5AFF;
  z-index: 12;
}

.header__nav--active {
  position: absolute;
  left: calc(50% - 43px);
  top: 150px;
  display: flex;
  z-index: 15;
}

.header__contacts--active {
  position: absolute;
  display: flex;
  left: calc(50% - 80px);
  top: calc(100vh - 100px);
  z-index: 15;
}

.header__menu-button {
  position: relative;
  height: 42px;
  width: 42px;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: space-between;
  background-color: transparent;
  cursor: pointer;
  border: 1px solid #fff;
  border-radius: 5px;
  transition: all 0.3s ease;
  padding: 10px;
  overflow: hidden;
}
.header__menu-button .menu-button__item {
  height: 2px;
  width: 25px;
  background-color: #fff;
  transition: all 0.3s ease;
}
.header__menu-button .menu-button__item:nth-of-type(2) {
  position: absolute;
  top: calc(50% - 1px);
  z-index: 1;
}
.header__menu-button .menu-button__item:nth-of-type(3) {
  position: relative;
  z-index: 2;
}

.header__menu-button--active .menu-button__item:nth-of-type(1) {
  transform: translateY(-800%);
}
.header__menu-button--active .menu-button__item:nth-of-type(2) {
  transform-origin: center;
  transform: rotate(45deg) translateY(-50%);
}
.header__menu-button--active .menu-button__item:nth-of-type(3) {
  transform-origin: center;
  transform: rotate(-45deg);
}
.header__menu-button--active .menu-button__item:nth-of-type(4) {
  transform: translateY(800%);
}

.hero {
  height: 100vh;
  display: flex;
  align-items: center;
  justify-content: center;
}
.hero .container {
  min-width: 100%;
  height: 100%;
}
.hero__slider {
  position: relative;
  min-width: 100%;
  height: 100%;
}
.hero__slider .slider-item {
  position: relative;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  background-size: cover;
  background-repeat: no-repeat;
  background-position: center;
  height: 100vh;
}
.hero__slider .slider-item h2 {
  text-align: center;
  text-transform: uppercase;
  font-style: normal;
  color: #FFFFFF;
  font-family: "Montserrat", "Arial", sans-serif;
  z-index: 10;
  font-weight: 700;
  font-size: 20px;
  letter-spacing: 0.1em;
  margin-bottom: 10px;
}
.hero__slider .slider-item p {
  text-align: center;
  text-transform: uppercase;
  font-style: normal;
  color: #FFFFFF;
  font-family: "Montserrat", "Arial", sans-serif;
  z-index: 10;
  font-weight: 400;
  font-size: 14px;
  max-width: 280px;
}
.hero__slider .first-slide {
  background-image: url("/img/first-build.jpg");
}
.hero__slider .first-slide::before {
  content: "";
  width: 100%;
  height: 100%;
  left: 0;
  top: 0;
  position: absolute;
  opacity: 0.96;
  background: linear-gradient(243.43deg, rgb(126, 90, 255) 16.9%, rgb(85, 183, 255) 83.27%);
}
.hero__slider .second-slide {
  background-image: url("/img/second-bild.jpg");
}
.hero__slider .second-slide::before {
  content: "";
  width: 100%;
  height: 100%;
  left: 0;
  top: 0;
  position: absolute;
  opacity: 0.96;
  background: linear-gradient(243.43deg, rgb(40, 110, 40) 16.9%, rgb(161, 68, 157) 83.27%);
}
.hero__slider .third-slide {
  background-image: url("/img/third-build.jpg");
}
.hero__slider .third-slide::before {
  content: "";
  width: 100%;
  height: 100%;
  left: 0;
  top: 0;
  position: absolute;
  opacity: 0.96;
  background: linear-gradient(243.43deg, rgb(51, 51, 46) 16.9%, rgb(253, 119, 126) 83.27%);
}
.hero__slider .fourth-slide {
  background-image: url("/img/fourth-build.jpg");
}
.hero__slider .fourth-slide::before {
  content: "";
  width: 100%;
  height: 100%;
  left: 0;
  top: 0;
  position: absolute;
  opacity: 0.96;
  background: linear-gradient(243.43deg, rgb(51, 109, 96) 16.9%, rgb(94, 252, 94) 83.27%);
}
.hero__slider .fifth-slide {
  background-image: url("/img/fivth-build.jpg");
}
.hero__slider .fifth-slide::before {
  content: "";
  width: 100%;
  height: 100%;
  left: 0;
  top: 0;
  position: absolute;
  opacity: 0.96;
  background: linear-gradient(243.43deg, rgb(43, 52, 104) 16.9%, rgb(227, 245, 69) 83.27%);
}

.slick-dots {
  position: absolute;
  top: 50%;
  right: 15px;
  transform: translateY(-50%);
  display: flex;
  flex-direction: column;
  justify-content: center;
  width: fit-content;
  height: fit-content;
  z-index: 10;
}
.slick-dots li {
  display: block;
  border: 1px solid #FFFFFF;
  border-radius: 50%;
  margin: 0;
  width: 10px;
  height: 10px;
}
.slick-dots li:not(:last-child) {
  margin-bottom: 30px;
}
.slick-dots li button:before {
  content: "";
  width: 100%;
  height: 100%;
  border-radius: 50%;
  opacity: 1;
}
.slick-dots li.slick-active button:before {
  background-color: #FFFFFF;
  opacity: 1;
}

.hero__arrow {
  display: flex;
  justify-content: center;
  align-items: center;
  position: absolute;
  bottom: 50px;
  width: 40px;
  height: 40px;
  border: 1px solid #FFFFFF;
  opacity: 0.7;
  left: calc(50% - 20px);
  border-radius: 50%;
}

.hero__arrow-icon {
  width: 12px;
  height: 17px;
}

.projects {
  position: relative;
  background-color: #E5E5E5;
}
.projects .container {
  padding: 70px 5px 75px;
}
.projects__title {
  font-family: "Montserrat", "Arial", sans-serif;
  font-style: normal;
  font-weight: 700;
  text-transform: uppercase;
  color: #2C4058;
  font-size: 30px;
  text-align: center;
  margin-bottom: 50px;
}
.projects__list {
  display: flex;
  flex-direction: column;
}
.projects__item {
  display: flex;
  flex-direction: column;
  justify-content: flex-start;
  align-items: center;
}
.projects__item:nth-of-type(2) {
  flex-direction: column-reverse;
}
.projects__item .project-img {
  max-width: 280px;
  height: auto;
  z-index: 5;
  margin-bottom: 20px;
}
.projects__item .project-info {
  max-width: 476px;
  display: flex;
  flex-direction: column;
}
.projects__item .project-info span {
  font-family: "Montserrat", "Arial", sans-serif;
  font-style: normal;
  font-weight: 400;
  text-transform: uppercase;
  color: #2C4058;
  font-size: 22px;
  margin-bottom: 17px;
}
.projects__item .project-info h3 {
  font-family: "Montserrat", "Arial", sans-serif;
  font-style: normal;
  font-weight: 700;
  text-transform: uppercase;
  color: #2C4058;
  font-size: 30px;
  margin-bottom: 30px;
}
.projects__item .project-info p {
  font-family: "Open Sans", "Arial", sans-serif;
  font-style: normal;
  font-weight: 400;
  font-size: 18px;
  line-height: 30px;
  color: #2C4058;
  margin-bottom: 40px;
}
.projects__item .project-info a {
  display: flex;
  align-items: center;
  justify-content: center;
  max-width: 190px;
  min-height: 50px;
  border: 1px solid #2C4058;
  font-family: "Montserrat", "Arial", sans-serif;
  font-style: normal;
  font-weight: 400;
  font-size: 14px;
  color: #000000;
  text-decoration: none;
  text-transform: uppercase;
  margin-bottom: 60px;
}
.projects__item .project-info a:hover {
  border: transparent;
  background: linear-gradient(243.43deg, #7E5AFF 16.9%, #55B7FF 83.27%);
  color: #FFFFFF;
}
.projects__item .project-info__place {
  display: flex;
  flex-direction: row;
}
.projects__item .project-info__place .icon {
  width: 9px;
  height: 17px;
  margin-right: 10px;
}
.projects__item .project-info__place span {
  font-family: "Open Sans", "Arial", sans-serif;
  text-transform: none;
  font-style: italic;
  font-weight: 400;
  font-size: 15px;
  color: #000000;
}
.projects__item:not(:last-child) {
  margin-bottom: 60px;
}
.projects .projects-decore-one {
  display: none;
  top: 274px;
  left: 0;
  position: absolute;
  min-width: 585px;
  min-height: 470px;
  background-color: #55B7FF;
}
.projects .projects-decore-two {
  display: none;
  bottom: 207px;
  right: 0;
  position: absolute;
  min-width: 585px;
  min-height: 470px;
  background-color: #7E5AFF;
}

@media only screen and (min-width: 576px) {
  .hero__slider .slider-item h2 {
    text-align: center;
    text-transform: uppercase;
    font-style: normal;
    color: #FFFFFF;
    font-family: "Montserrat", "Arial", sans-serif;
    z-index: 10;
    font-size: 40px;
    margin-bottom: 30px;
  }
  .hero__slider .slider-item p {
    text-align: center;
    text-transform: uppercase;
    font-style: normal;
    color: #FFFFFF;
    font-family: "Montserrat", "Arial", sans-serif;
    z-index: 10;
    font-size: 16px;
    letter-spacing: 0.3em;
    max-width: 450px;
  }
  .slick-dots {
    right: 25px;
  }
  .projects__item .project-img {
    max-width: 450px;
  }
}
@media only screen and (min-width: 1170px) {
  .header .container {
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
  }
  .header__logo {
    width: 241px;
    height: 54px;
  }
  .header__nav {
    display: block;
    margin-bottom: 0px;
  }
  .header__nav-list {
    flex-direction: row;
    align-items: center;
  }
  .header__nav-list .nav-item:not(:last-child) {
    margin-bottom: 0px;
    margin-right: 70px;
  }
  .header__contacts {
    display: flex;
    flex-direction: row;
  }
  .header__menu-button {
    display: none;
  }
  .hero__slider .slider-item h2 {
    text-align: center;
    text-transform: uppercase;
    font-style: normal;
    color: #FFFFFF;
    font-family: "Montserrat", "Arial", sans-serif;
    z-index: 10;
    font-size: 80px;
  }
  .hero__slider .slider-item p {
    text-align: center;
    text-transform: uppercase;
    font-style: normal;
    color: #FFFFFF;
    font-family: "Montserrat", "Arial", sans-serif;
    z-index: 10;
    font-size: 18px;
    max-width: fit-content;
  }
  .slick-dots {
    right: 52px;
  }
  .slick-dots li:not(:last-child) {
    margin-bottom: 40px;
  }
  .projects .container {
    padding: 135px 15px 150px;
  }
  .projects__title {
    font-size: 44px;
    margin-bottom: 153px;
  }
  .projects__item {
    flex-direction: row;
    justify-content: space-between;
    align-items: flex-end;
  }
  .projects__item:nth-of-type(2) {
    flex-direction: row;
  }
  .projects__item .project-img {
    margin-bottom: 0px;
    max-width: 630px;
  }
  .projects__item .project-info h3 {
    font-size: 44px;
  }
  .projects__item:not(:last-child) {
    margin-bottom: 178px;
  }
  .projects .projects-decore-one, .projects .projects-decore-two {
    display: block;
  }
}

/*# sourceMappingURL=style.cs.map */
