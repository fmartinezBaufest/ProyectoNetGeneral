$(document).ready(function () {

    var miLista = ["Elemento 1", "Elemento 2", "Elemento 3"];

    // Crear una instancia del ViewModel

    const searchInput = $('#searchInput');
    const suggestions = $('#suggestions');
    const suggestions2 = $('#suggestions2');

   

    var d = new ViewModel();

    function ViewModel() {
        var self = this;

        // Observable array para la lista de elementos
        self.listaDeElementos = ko.observableArray([]);

        self.selectedPerson = ko.observable({});

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
                                });
                            });
                            self.listaDeElementos(characters);

                            console.log("veddr", characters)

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
            var name = $(this).find('td:eq(0)').text();
            var lastName = $(this).find('td:eq(1)').text();
            var dni = $(this).find('td:eq(2)').text();


            self.selectedPerson({ name: name, lastName: lastName, dni: dni });

            self.listaDeElementos([]);

            console.log(self.selectedPerson().name)
            
        });
    }

    ko.applyBindings(d);
    
});