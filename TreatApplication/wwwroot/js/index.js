﻿$(document).ready(function() {
    var x = 0;
    var s = "";

    console.log("Hello");

    var theForm = $("#theForm");
    theForm.hide();

    var button = $("#buybutton")
button.on("Click", function () {
        console.log("Buying Item");
    });

    var productInfo = $(".product-props li");
    productInfo.on("click", function () {
        console.log("You clicked on" + $(this).text());

    });
    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");
    $loginToggle.on("click", function () {
        $popupForm.toggle(1000);

    });

});