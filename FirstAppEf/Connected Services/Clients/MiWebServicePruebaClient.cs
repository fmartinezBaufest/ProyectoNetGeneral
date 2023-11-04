using WebServicePrueba;

public class MiWebServiceClient : IMiWebServiceDePrueba
{
    private MiWebServiceDePruebaClient _client;

    public MiWebServiceClient()
    {
        _client = new MiWebServiceDePruebaClient(MiWebServiceDePruebaClient.EndpointConfiguration.BasicHttpBinding_IMiWebServiceDePrueba);
    }

    public async Task<string> DevolvemeElNombreAsync()
    {
        return await _client.DevolvemeElNombreAsync();
    }
}
