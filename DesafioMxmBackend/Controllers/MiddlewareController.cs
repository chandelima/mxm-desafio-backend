using DesafioMxmBackend.Service;
using DesafioMxmBackend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesafioMxmBackend.Controllers;

[ApiController]
[Route("")]
public class MiddlewareController : Controller
{
    private readonly IHttpRequestService _httpRequestService;

    public MiddlewareController(IHttpRequestService httpRequestService)
    {
        _httpRequestService = httpRequestService;
    }

    /// <summary>
    /// Endpoint responsável pelo consumo de requisições do tipo GET a API da MXM.
    /// </summary>
    [HttpPost]
    [Route("GET")]
    public async Task<string> Get([FromQuery] string resourcePath, [FromBody] object payload)
    {
        return await _httpRequestService.Get(resourcePath, payload);
    }

    /// <summary>
    /// Endpoint responsável pelo consumo de requisições do tipo POST a API da MXM.
    /// </summary>
    [HttpPost]
    [Route("POST")]
    public async Task<string> Post([FromQuery] string resourcePath, [FromBody] object payload)
    {
        return await _httpRequestService.Post(resourcePath, payload);
    }
}
