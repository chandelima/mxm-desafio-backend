using DesafioMxmBackend.Services.Interfaces;
using System.Net.Http.Headers;

namespace DesafioMxmBackend.Service;

public class HttpRequestService : IHttpRequestService
{
    private readonly string _baseUrl;

    public HttpRequestService(IConfiguration configuration)
    {
        _baseUrl = configuration.GetSection("BaseUrl").Value;
    }

    public async Task<string> Get(string endpoint, object payload)
    {
        return await RequestBase(HttpMethod.Get, endpoint, payload);
    }
    public async Task<string> Post(string endpoint, object payload)
    {
        return await RequestBase(HttpMethod.Post, endpoint, payload);
    }

    private async Task<string> RequestBase(
        HttpMethod method, string resourcePath, object payload)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string url = $"{_baseUrl}/{resourcePath}";

                HttpRequestMessage request = new HttpRequestMessage(method, url);
                request.Content = JsonContent.Create(payload);
                request.Content.Headers.ContentType = new MediaTypeHeaderValue("text/json");

                HttpResponseMessage response = await client.SendAsync(request);

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception e)
            {
                return $"ERRO NO MIDDLEWARE!!! \n ${e.Message}";
                throw new Exception(e.Message);
            }
        }
    }
}