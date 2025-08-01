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

app.MapPut("/materias/{id}", (int id, DTOs.Materia dto) =>
{
    try
    {
        MateriasService materiaService = new MateriasService();
        dto.Id = id; // Asegurar que el ID del DTO coincida con el ID de la ruta
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
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/materias/{id}", (int id) =>
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


// DocenteCurso endpoints

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

//comision 
app.MapGet("/comisiones/{id}", (int id) =>
{
    ComisionService comisionService = new ComisionService();
    Comision comision = comisionService.Get(id);
    if (comision != null)
    {
        var dto = new DTOs.Comision
        {
            Id = comision.Id,
            Descripcion = comision.Descripcion,
            AnioEspecialidad = comision.AnioEspecialidad,
            IDPlan = comision.IDPlan
        };
        return Results.Ok(dto);
    }
    else
    {
        return Results.NotFound();
    }
})
.WithName("GetComision")
.Produces<DTOs.Comision>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.MapGet("/comisiones", () =>
{
    ComisionService comisionService = new ComisionService();
    var comisiones = comisionService.GetAll();
    var dtos = comisiones.Select(c => new DTOs.Comision
    {
        Id = c.Id,
        Descripcion = c.Descripcion,
        AnioEspecialidad = c.AnioEspecialidad,
        IDPlan = c.IDPlan
    }).ToList();

    return Results.Ok(dtos);
})
.WithName("GetAllComisiones")
.Produces<List<DTOs.Comision>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/comisiones", (DTOs.Comision dto) =>
{
    try
    {
        ComisionService comisionService = new ComisionService();
        Comision comision = new Comision(dto.Id, dto.AnioEspecialidad, dto.Descripcion, dto.IDPlan);
        comisionService.Add(comision);

        var dtoResultado = new DTOs.Comision
        {
            Id = comision.Id,
            Descripcion = comision.Descripcion,
            AnioEspecialidad = comision.AnioEspecialidad,
            IDPlan = comision.IDPlan
        };

        return Results.Created($"/comisiones/{dtoResultado.Id}", dtoResultado);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddComision")
.Produces<DTOs.Comision>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/comisiones/{id}", (int id, DTOs.Comision dto) =>
{
    try
    {
        ComisionService comisionService = new ComisionService();
        dto.Id = id; // Asegurar que el ID del DTO coincida con el ID de la ruta
        Comision comision = new Comision(dto.Id, dto.AnioEspecialidad, dto.Descripcion, dto.IDPlan);

        var found = comisionService.Update(comision);
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
.WithName("UpdateComision")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/comisiones/{id}", (int id) =>
{
    ComisionService comisionService = new ComisionService();
    var deleted = comisionService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();
})
    .WithName("DeleteComision")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();


app.Run();