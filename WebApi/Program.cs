using Domain.Service;
using Domain.Model;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(options => { });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpLogging();
}

app.UseHttpsRedirection();

app.MapGet("/materias/{id}", (int id) =>
{
    MateriasService materiaService = new MateriasService();
    Materia materia = materiaService.Get(id);
    if (materia != null)
    {
        return Results.Ok(materia);
    }
    else
    {
        return Results.NotFound();
    }
})
.WithName("GetMateriaById")
.Produces<DTOs.Materia>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapGet("/materia", () =>
{
    MateriasService materiaService = new MateriasService();

    var materias = materiaService.GetAll();

    var dtos = materias.Select(m => new DTOs.Materia
    {
        Id = m.Id,
        Descripcion = m.Descripcion,
        HSSemanales = m.HSSemanales,
        HSTotales = m.HSTotales,
        IdPlan = m.IDPlan 
    }).ToList();

    return Results.Ok(dtos);
})
.WithName("GetAllMaterias")
.Produces<List<DTOs.Materia>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/materia", (DTOs.Materia dto) =>
{
    try
    {
        MateriasService materiaService = new MateriasService();

        Materia materia = new Materia(dto.Descripcion, dto.HSSemanales, dto.HSTotales, dto.IdPlan); // Cambiado: usar IdPlan

        materiaService.Add(materia);

        var dtoResultado = new DTOs.Materia
        {
            Id = materia.Id,
            Descripcion = materia.Descripcion,
            HSSemanales = materia.HSSemanales,
            HSTotales = materia.HSTotales,
            IdPlan = materia.IDPlan // Cambiado: usar IdPlan del DTO
        };

        return Results.Created($"/materia/{dtoResultado.Id}", dtoResultado);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddMateria")
.Produces<DTOs.Materia>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/materia/{id}", (int id, DTOs.Materia dto) =>
{
    try
    {
        MateriasService materiaService = new MateriasService();

        Materia materia = new Materia(dto.Descripcion, dto.HSSemanales, dto.HSTotales, dto.IdPlan); // Cambiado: usar IdPlan
        materia.Id = id;

        var found = materiaService.Update(materia);

        if (!found)
        {
            return Results.NotFound();
        }

        return Results.NoContent();
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("UpdateMateria")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/materia/{id}", (int id) =>
{
    MateriasService materiaService = new MateriasService();

    var deleted = materiaService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();
})
.WithName("DeleteMateria")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();



app.Run();
