$(document).ready(function () {
    $(".home-left-btn").mouseenter(function () {
        $(this).animate({ width: "200%"});
        $(this).css("background-color", "red");
        $('.home-right-btn').fadeOut();
    });
    $(".home-left-btn").mouseleave(function () {
        $(this).animate({ width: "100%" });
        $('.home-right-btn').fadeIn();
    });

    $(".home-right-btn").mouseenter(function () {
        //$(this).animate({ width: "-10px" });
        $('.home-left-btn').fadeOut();
    });
    $(".home-right-btn").mouseleave(function () {
        $(this).animate({ width: "toggle" });
        //$(this).animate({ width: "100%" });
        $('.home-left-btn').fadeIn();
    });


});
//{
//    $(".home-left-btn").on("click", function () {
//        alert("dsdsaw");
//        //$.ajax({
//        //    url: "@Url.Action(.../Home/_Students)",
//        //    type: "GET",
//        //    success: function (data) {
//        //        var htmlx = data; // the View

//        //        $("#content").append(htmlx);
//        //        $("#content").slideDown('slow');
//        //    }
//        //});
//    });
//}

