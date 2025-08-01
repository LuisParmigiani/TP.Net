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
    app.UseHttpLogging();
}

app.UseHttpsRedirection();



app.MapGet("/docentecursos/{id}", (int id) =>
{
    DocenteCursoService docenteCursoService = new DocenteCursoService();
    DocenteCurso docenteCurso = docenteCursoService.Get(id);
    if (docenteCurso != null)
    {
        var dto = new DTOs.DocenteCurso
        {
            Id = docenteCurso.Id,
            Cargo = docenteCurso.Cargo,
            IDCurso = docenteCurso.IDCurso,
            IDDocente = docenteCurso.IDDocente
        };
        return Results.Ok(dto);
    }
    else
    {
        return Results.NotFound();
    }
})
.WithName("GetDocenteCurso")
.Produces<DTOs.DocenteCurso>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.MapGet("/docentecursos", () =>
{
    DocenteCursoService docenteCursoService = new DocenteCursoService();
    var docenteCursos = docenteCursoService.GetAll();
    var dtos = docenteCursos.Select(dc => new DTOs.DocenteCurso
    {
        Id = dc.Id,
        Cargo = dc.Cargo,
        IDCurso = dc.IDCurso,
        IDDocente = dc.IDDocente
    }).ToList();

    return Results.Ok(dtos);
})
.WithName("GetAllDocenteCursos")
.Produces<List<DTOs.DocenteCurso>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/docentecursos", (DTOs.DocenteCurso dto) =>
{
    try
    {
        DocenteCursoService docenteCursoService = new DocenteCursoService();
        DocenteCurso docenteCurso = new DocenteCurso(dto.Id, dto.Cargo, dto.IDCurso, dto.IDDocente);
        docenteCursoService.Add(docenteCurso);

        var dtoResultado = new DTOs.DocenteCurso
        {
            Id = docenteCurso.Id,
            Cargo = docenteCurso.Cargo,
            IDCurso = docenteCurso.IDCurso,
            IDDocente = docenteCurso.IDDocente
        };

        return Results.Created($"/docentecursos/{dtoResultado.Id}", dtoResultado);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddDocenteCurso")
.Produces<DTOs.DocenteCurso>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/docentecursos/{id}", (int id, DTOs.DocenteCurso dto) =>
{
    try
    {
        DocenteCursoService docenteCursoService = new DocenteCursoService();
        dto.Id = id; // Asegurar que el ID del DTO coincida con el ID de la ruta
        DocenteCurso docenteCurso = new DocenteCurso(dto.Id, dto.Cargo, dto.IDCurso, dto.IDDocente);

        var found = docenteCursoService.Update(docenteCurso);
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
.WithName("UpdateDocenteCurso")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/docentecursos/{id}", (int id) =>
{
    DocenteCursoService docenteCursoService = new DocenteCursoService();
    var deleted = docenteCursoService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();
})
    .WithName("DeleteDocenteCurso")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.Run();