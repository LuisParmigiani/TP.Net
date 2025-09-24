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
});builder.Services.AddHttpLogging(o => { });

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorWasm",
        policy =>
        {
            policy.WithOrigins("http://localhost:7170", "https://localhost:5076")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpLogging();
}
app.UseHttpsRedirection();
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
