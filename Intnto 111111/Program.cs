using Domain.Service;
using Domain.Model;
using DTOs;
using WebApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Your API", Version = "v1" });
    c.TagActionsBy(api => new[] { api.GroupName });
});

builder.Services.AddHttpLogging(o => { });

// Minimal CORS policy to allow calls from the WebApp development URL
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorWasm",
        policy =>
        {
            policy.WithOrigins("http://localhost:5246", "http://localhost:5183")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpLogging();
}

app.UseHttpsRedirection();

// Enable CORS so the Blazor app can call this API
app.UseCors("AllowBlazorWasm");
//Dictado
app.MapDictadoEndpoints();
//comision 
app.MapComisionEndpoints();
//Cursos 
app.MapCursoEndpoints();
//Materia
app.MapMateriaEndpoints();
//Plan 
app.MapPlanEndpoints();
//Persona 
app.MapPersonaEndpoints();
//Especialidades 
app.MapEspecialidadEndpoints();
//Inscripciones 
app.MapInscripcionEndpoints();
//Usuarios 
app.MapUsuarioEndpoints();
app.Run();
