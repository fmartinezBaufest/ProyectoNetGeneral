$(document).ready(function () {
    $('#mostrarAlerta').click(function () {
        alert('Este es un mensaje de alerta con jQuery.');
    });


    // Obtiene el div de éxito por su ID
    var alertSuccess = $("#alertSuccess");

    // Espera 5 segundos (5000 milisegundos) y luego oculta el div
    setTimeout(function () {
        alertSuccess.fadeOut("slow"); // Puedes ajustar la velocidad de desvanecimiento
    }, 3000); // 5000 milisegundos = 5 segundos

    // Obtiene el div de éxito por su ID
    var alertError = $("#alertError");

    // Espera 5 segundos (5000 milisegundos) y luego oculta el div
    setTimeout(function () {
        alertError.fadeOut("slow"); // Puedes ajustar la velocidad de desvanecimiento
    }, 3000); // 5000 milisegundos = 5 segundos

});