$(document).ready(function () {
    
    const searchInput = $('#searchInput');
    const suggestions = $('#suggestions');
    const suggestions2 = $('#suggestions2');

    searchInput.on('input', function (e) {
        e.preventDefault();
        const query = searchInput.val();

        if (query === '') {
            suggestions.empty();
            suggestions2.empty();
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
                    response?.data?.forEach(result => {
                        var suggestionItem = $(`<option value="${result.name}">${result.name}</option>`);

                        suggestions2.append(suggestionItem);

                        //suggestions.append($("<option>").attr('value', result.id).text(result.name));

                        



                    });

                    
                }
                

               
            },
            error: function () {
                // Maneja errores
            }
             });
        });
});