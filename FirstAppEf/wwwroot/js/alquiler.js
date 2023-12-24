$(document).ready(function () {

    const searchInput = $('#searchInput');
    const crearAlquilerBtn = $('#crearAlquilerBtn');
    

    var d = new ViewModel();

    function ViewModel() {
        var self = this;

        self.idPelicula = $('#idPelicula').val();

        // Observable array para la lista de elementos
        self.listaDeElementos = ko.observableArray([]);

        self.selectedPerson = ko.observable({});

        self.incrementClickCounter = function () {
            alquilar();
        }

        searchInput.on('input', function (e) {
            e.preventDefault();
            const query = searchInput.val();

            if (query === '') {
            }

            // Realiza una solicitud al servidor o utiliza datos locales para obtener sugerencias.
            $.ajax({
                url: '/Alquiler/GetPerson', // Ruta del servidor para buscar sugerencias
                type: "GET",
                contentType: "application/json",
                data: { datoBusqueda: query }, // Parámetros de búsqueda
                success: function (response) {
                    // Procesa los resultados y muestra las sugerencias en 'suggestions'
                    //suggestions.empty();


                    if (response) {

                            var characters = [];
                            $.each(response?.data, function (index, character) {
                                characters.push({
                                    name: character.name,
                                    lastName: character.lastName,
                                    dni: character.dni,
                                    id: character.id,
                                });
                            });
                            self.listaDeElementos(characters);

                     }
                },
                error: function () {
                    // Maneja errores
                }
            });
        });

        self.listaVacia = ko.computed(function () {
            return self.listaDeElementos().length === 0;
        });

        $('#personsAlquiler').on('click', 'tr.mi-fila', function () {
            // Obtén los datos asociados al elemento seleccionado

            searchInput.val('');

            var name = $(this).find('td:eq(0)').text();
            var lastName = $(this).find('td:eq(1)').text();
            var dni = $(this).find('td:eq(2)').text();
            var id = $(this).find('td:eq(3)').text();


            self.selectedPerson({ name: name, lastName: lastName, dni: dni, id: id });

            self.listaDeElementos([]);
            
        });

        crearAlquilerBtn.click(function () {

            alert('hola')
            // Tu código para manejar el evento de clic va aquí
        });

        function alquilar() {
            $.ajax({
                url: '/Alquiler/CrearAlquiler', // Ruta del servidor para buscar sugerencias
                type: "POST",
                contentType: "application/json",
                data: JSON.stringify({ peliculaId: self.idPelicula, personaId: self.selectedPerson().id }),  // Parámetros de búsqueda
                success: success => {
                    // Procesa los resultados y muestra las sugerencias en 'suggestions'
                    //suggestions.empty();

                    if (success.result === 'ok') {
                        alert("Se realizó el alquiler.");
                        window.location.href = '/';
                    }

                },
                error: err => {

                    if (err.status === 400) {
                        var errorData = JSON.parse(err.responseText);
                        console.log('Detalles del error:', errorData);
                        // Puedes hacer algo con los detalles del error aquí

                        if (errorData.error === "errorModel") {
                            alert("error de modelo")
                        }

                    }
                }
            });
        }
    }



    ko.applyBindings(d);
    
});