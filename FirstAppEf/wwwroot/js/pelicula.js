$(document).ready(function () {
    
    $('#buscarPeliculaBtn').click(function (e) {

        e.preventDefault(); 

        var datoABuscar = $("#buscarPeliculaInp").val();

        $.ajax({
            url: "/Pelicula/GetPeliculaByName", // La URL de la acci�n en tu controlador
            type: "GET",
            contentType: "application/json",
            data: { name: datoABuscar },
            success: function (data) {

               console.log(data)
            },
            error: function () {
                // Manejar errores aqu�
                console.error("Error en la solicitud AJAX.");


            }
        });

        console.log('persona', persona);



    })

});