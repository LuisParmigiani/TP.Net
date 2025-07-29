using Domain.Service;
using Domain.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //Falta configurar de manera correcta        
    app.UseHttpLogging();
}

app.UseHttpsRedirection();

app.MapGet("/materias/{id}", (int id) =>
{
    MateriasService materiaService = new MateriasService();
    Materia materia = materiaService.Get(id);
    if (materia != null)
    {
        var dto = new DTOs.Materia
        {
            Id = materia.Id,
            Descripcion = materia.Descripcion,
            HSSemanales = materia.HSSemanales,
            HSTotales = materia.HSTotales,
            IdPlan = materia.IDPlan
        };
        return Results.Ok(dto);
    }
    else
    {
        return Results.NotFound();
    }
})
.WithName("GetMateria")
.Produces<DTOs.Materia>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.MapGet("/materias", () =>
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

app.MapPost("/materias", (DTOs.Materia dto) =>
{
    try
    {
        MateriasService materiaService = new MateriasService();
        Materia materia = new Materia(dto.Id, dto.Descripcion, dto.HSSemanales, dto.HSTotales, dto.IdPlan);
        materiaService.Add(materia);

        var dtoResultado = new DTOs.Materia
        {
            Id = materia.Id,
            Descripcion = materia.Descripcion,
            HSSemanales = materia.HSSemanales,
            HSTotales = materia.HSTotales,
            IdPlan = materia.IDPlan
        };

        return Results.Created($"/materias/{dtoResultado.Id}", dtoResultado);
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
        Materia materia = new Materia(dto.Id, dto.Descripcion, dto.HSSemanales, dto.HSTotales, dto.IdPlan);

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