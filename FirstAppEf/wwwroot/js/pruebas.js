$(document).ready(function () {

    $('#paragraph1').mouseenter(function () {

        $(this).css('color', 'red')
    })

    $('#paragraph1').mouseleave(function () {

        $(this).css('color', 'black')
    })
    function tablaDatos() {
        var self = this;

        self.datosPrueba = ko.observable({
            nombre: ko.observable("Juan"),
            edad: ko.observable(30),
            correo: ko.observable("juan@example.com")
        });

        self.infoRickAndMorty = ko.observableArray([]);

        var apiUrl = "https://rickandmortyapi.com/api/character";

        self.cargarDatos = $.ajax({
            url: apiUrl,
            type: "GET",
            dataType: "json", // Especificar el tipo de datos esperados
            success: function (data) {
                // Manejar la respuesta exitosa aqu�
                console.log(data);

                var table = $("#characterTable");
                var tbody = table.find("tbody");

                // Iterar a trav�s de los personajes y agregar filas a la tabla

                var characters = [];
                $.each(data.results, function (index, character) {
                    characters.push({
                        name: character.name,
                        species: character.species,
                        gender: character.gender,
                        origin: character.origin.name
                    });
                });

                self.infoRickAndMorty(characters);
            },
            error: function () {
                // Manejar errores aqu�
                console.error("Error en la solicitud AJAX.");
            }
        });

        setTimeout(function () {
            self.datosPrueba().nombre("Pepito");
        }, 5000); // 5000 milisegundos = 5 segundos
    }
   
    // Activates knockout.js
    ko.applyBindings(new tablaDatos());
});