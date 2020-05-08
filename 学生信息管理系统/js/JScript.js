$(function () {
    $(".header .header_nav #changecolor").click(function () {
        $(".changecolor_menu").slideToggle(500);
    });

    $("#theme1").click(function () {
        $(".header").css("background", "teal");
        $(".header>.title a").css("color", "white");
        $(".header_bottom").css("background", "#f0ffff");
        $(".left-nav").css("background", "#e0ffff");
        $(".left-nav .title i").css("color", "#666")
        $(".left-nav .title span").css("color", "#666")
        $(".left-nav .one div").css("color", "#666")
        $(".left-nav .one div").css("color", "#666")
        $(".header .changecolor_menu .now .now_back").css("background", "teal");
    });

    $("#theme2").click(function () {
        $(".header").css("background", "tomato");
        $(".header>.title a").css("color", "white");
        $(".header_bottom").css("background", "#ffe4e1");
        $(".left-nav").css("background", "#ffa07a");
        $(".left-nav .title i").css("color", "white")
        $(".left-nav .title span").css("color", "white")
        $(".left-nav .one div").css("color", "white")
        $(".left-nav .one div").css("color", "white")
        $(".left-nav .one div .sub li i").css("color", "white")
        $(".header .changecolor_menu .now .now_back").css("background", "tomato");
    });

    $("#theme3").click(function () {
        $(".header").css("background", "#666");
        $(".header>.title a").css("color", "white");
        $(".header_bottom").css("background", "#f5f5f5");
        $(".left-nav").css("background", "#dcdcdc");
        $(".left-nav .title i").css("color", "#666")
        $(".left-nav .title span").css("color", "#666")
        $(".left-nav .one div").css("color", "#666")
        $(".left-nav .one div").css("color", "#666")
        $(".left-nav .menu li .sub li i").css("color", "#666")
        $(".header .changecolor_menu .now .now_back").css("background", "#666");
    });

    $("#theme4").click(function () {
        $(".header").css("background", "#54a0ff");
        $(".header>.title a").css("color", "white");
        $(".header_bottom").css("background", "#c4e1ff");
        $(".left-nav").css("background", "#d2e9ff");
        $(".left-nav .title i").css("color", "#666")
        $(".left-nav .title span").css("color", "#666")
        $(".left-nav .one div").css("color", "#666")
        $(".left-nav .one div").css("color", "#666")
        $(".left-nav .menu li .sub li i").css("color", "#666")
        $(".header .changecolor_menu .now .now_back").css("background", "#54a0ff");
    });
});