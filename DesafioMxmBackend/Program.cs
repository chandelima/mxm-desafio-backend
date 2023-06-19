using DesafioMxmBackend.Service;
using DesafioMxmBackend.Services.Interfaces;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Dependencies Injection
builder.Services.AddScoped<IHttpRequestService, HttpRequestService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = "Desafio MXM - Middleware",
            Version = "v1",
            Description = "API desenvolvida para o Desafio MXM, com o " +
                "objetivo de interceptar as requisições feitas a API da " +
                "MXM, devido a limitação de consumo de requisições do tipo " +
                "GET com body, a partir do XmlHttpRequest - objeto da API " +
                "dos browsers modernos respons pelo consumo HTTP."
        });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(opt =>
    opt.SwaggerEndpoint("v1/swagger.json", "Desafio MXM - Middleware"));

app.UseHttpsRedirection();

app.UseCors(x => x.AllowAnyHeader()
                  .AllowAnyMethod()
                  .AllowAnyOrigin());

app.MapControllers();

app.Run();
