$(document).ready(function () {
    
    const searchInput = $('#searchInput');
    const suggestions = $('#suggestions');

    searchInput.on('input', function (e) {
        e.preventDefault();
        const query = searchInput.val();

        if (query === '') {
            suggestions.empty();
        }

        // Realiza una solicitud al servidor o utiliza datos locales para obtener sugerencias.
        $.ajax({
            url: '/Alquiler/GetPerson', // Ruta del servidor para buscar sugerencias
            type: "GET",
            contentType: "application/json",
            data: { datoBusqueda: query }, // Parámetros de búsqueda
            success: function (data) {
                // Procesa los resultados y muestra las sugerencias en 'suggestions'
                suggestions.empty();

               
                data.forEach(function (result) {
                    var suggestionItem = $('<li>' + result.name + ' ' + result.lastName + '</li>'); // Supongamos que 'nombre' es un campo en los resultados
                    suggestions.append(suggestionItem);


                });

               
            },
            error: function () {
                // Maneja errores
            }
             });
        });
});