namespace DesafioMxmBackend.Services.Interfaces;

public interface IHttpRequestService
{
    Task<string> Get(string endpoint, object payload);
    Task<string> Post(string endpoint, object payload);
}
