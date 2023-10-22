$(document).ready(function () {

    $("#bntRow").click(function() {

        //editarPersona(this.attr.value);

        var valorAtributo = $(this).data("mi-dato");
        
    })

       
    $(".a-editar").on("click", function () {
        var id = $(this).data("id"); // Obtener el valor del atributo data-id del enlace
        console.log("a ver el id", id);
        $.ajax({
            url: "/Reports/GetById", // La URL de la acción en tu controlador
            type: "GET",
            data: { id: id }, // Enviar el ID como parámetro
            success: function (data) {
                $("#nombrePersona").empty();
                $("#apellidoPersona").empty();
                $("#dniPersona").empty();
                $("#edadPersona").empty();
                $("#errorMensaje").empty();
                // Manejar la respuesta exitosa aquí (por ejemplo, llenar un formulario con los datos recibidos)
                console.log(data); // Puedes mostrar los datos en la consola para verificar
                $("#detallePersonaModal").modal("show");
                $("#nombrePersona").val(data?.name);
                $("#apellidoPersona").val(data?.lastName);
                $("#dniPersona").val(data?.dni);
                $("#edadPersona").val(data?.age);
                $("#idPersona").val(data?.id);
                
            },
            error: function () {
                // Manejar errores aquí
                console.error("Error en la solicitud AJAX.");
                $("#detallePersonaModal").modal("show");
                $("#errorMensaje").text("Se produjo un error al cargar los datos.");

            }
        });
    });

    $('[data-dismiss="modal"]').click(function () {
        $('#detallePersonaModal').modal('hide')
    })

    $('#btnModalUpdate').click(function () {
        console.log('entre', $("#nombrePersona"));

        var persona = {
            Name: $("#nombrePersona").val(),
            LastName: $("#apellidoPersona").val(),
            Dni: $("#dniPersona").val(),
            Age: $("#edadPersona").val(),
            Id: $("#idPersona").val(),
        }

        $.ajax({
            url: "/Persona/Actualizar", // La URL de la acción en tu controlador
            type: "POST",
            contentType: "application/json",
            data: JSON.stringify(persona) , // Enviar el ID como parámetro
            success: function (data) {
             
                window.location.href = "/Reports/Index";
            },
            error: function () {
                // Manejar errores aquí
                console.error("Error en la solicitud AJAX.");
              

            }
        });

        console.log('persona', persona);



    })

    $('#btnModalDelete').click(function () {

        $.ajax({
           
            url: "/Persona/DeletePersona", // La URL de la acción en tu controlador
            type: "POST",
            contentType: "application/json",
            data: $("#idPersona").val(), // Enviar el ID como parámetro
            success: function (data) {

                alert(data);
             
                window.location.href = "/Reports/Index";
            },
            error: function () {
                // Manejar errores aquí
                console.error("Error en la solicitud AJAX.");
              

            }
        });
           
       

    })

    $(".link-opacity-10-hover").css("cursor", "pointer");
});

function editarPersona(p) {
    console.log('entro', p)
}

