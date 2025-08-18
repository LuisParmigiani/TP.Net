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

//Cursos 
app.MapGet("/cursos/{id}", (int id) =>
{
    CursoService cursoService = new CursoService();
    Curso cur = cursoService.Get(id);
    if (cur != null)
    {
        var dto = new DTOs.Curso()
        {
             AnioCalendario=cur.AnioCalendario, 
             Cupo=cur.Cupo,
             Descripcion = cur.Descripcion,
             IdComision = cur.IdComision,
             IdMateria = cur.IdMateria
        };
        return Results.Ok(dto);
    }
    else
    {
        return Results.NotFound();
    }
})
.WithName("GetCursos")
.Produces<DTOs.Curso>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.MapGet("/cursos", () =>
{
    CursoService cursoService = new CursoService();
    var cursos = cursoService.GetAll();
    var dtos = cursos.Select(c => new DTOs.Curso
    {
        Id = c.Id,
        AnioCalendario = c.AnioCalendario,
        Cupo = c.Cupo, 
        Descripcion = c.Descripcion,
        IdComision = c.IdComision,
        IdMateria = c.IdMateria
    }).ToList();

    return Results.Ok(dtos);
})
.WithName("GetAllCursos")
.Produces<List<DTOs.Curso>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/cursos", (DTOs.Curso dto) =>
{
    try
    {
        CursoService cursoService = new CursoService();
        Curso curso = new Curso(dto.AnioCalendario, dto.Cupo, dto.Descripcion, dto.IdComision, dto.IdMateria,dto.Id);
        cursoService.Add(curso);

        var dtoResultado = new DTOs.Curso
        {
            Id = dto.Id,
            AnioCalendario = curso.AnioCalendario,
            Cupo = curso.Cupo,
            Descripcion = curso.Descripcion,
            IdComision = curso.IdComision,
            IdMateria = curso.IdMateria
        };

        return Results.Created($"/cursos/{dtoResultado.IdMateria}", dtoResultado);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddCurso")
.Produces<DTOs.Curso>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/cursos/{id}", (int id, DTOs.Curso dto) =>
{
    try
    {
        CursoService cursoService = new CursoService();
        Curso curso = new Curso(dto.AnioCalendario, dto.Cupo, dto.Descripcion, dto.IdComision, dto.IdMateria,id);

        var found = cursoService.Update(curso);
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
.WithName("UpdateCurso") 
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/cursos/{id}", (int id) =>
{
    CursoService cursoService = new CursoService();
    var deleted = cursoService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();
})
    .WithName("DeleteCurso")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

//Plan 
app.MapGet("/planes/{id}", (int id) =>
{
    PlanService planService = new PlanService();
    Plan plan = planService.Get(id);
    if (plan != null)
    {
        var dto = new DTOs.Plan()
        {
            Id = plan.Id,
            Descripcion = plan.Descripcion,
            IdEspecialidad = plan.IdEspecialidad
        };
        return Results.Ok(dto);
    }
    else
    {
        return Results.NotFound();
    }
})
.WithName("GetPlan")
.Produces<DTOs.Plan>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.MapGet("/planes", () =>
{
    PlanService planService = new PlanService();
    var planes = planService.GetAll();
    var dtos = planes.Select(p => new DTOs.Plan
    {
        Id = p.Id,
        Descripcion = p.Descripcion,
        IdEspecialidad = p.IdEspecialidad
    }).ToList();

    return Results.Ok(dtos);
})
.WithName("GetAllPlanes")
.Produces<List<DTOs.Plan>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/planes", (DTOs.Plan dto) =>
{
    try
    {
        PlanService planService = new PlanService();
        Plan plan = new Plan(dto.Descripcion, dto.IdEspecialidad, dto.Id);
        planService.Add(plan);

        var dtoResultado = new DTOs.Plan
        {
            Id = plan.Id,
            Descripcion = plan.Descripcion,
            IdEspecialidad = plan.IdEspecialidad
        };

        return Results.Created($"/planes/{dtoResultado.Id}", dtoResultado);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddPlan")
.Produces<DTOs.Plan>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/planes/{id}", (int id, DTOs.Plan dto) =>
{
    try
    {
        PlanService planService = new PlanService();
        Plan plan = new Plan(dto.Descripcion, dto.IdEspecialidad, id);

        var found = planService.Update(plan);
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
.WithName("UpdatePlan") 
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/planes/{id}", (int id) =>
{
    PlanService planService = new PlanService();
    var deleted = planService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();
})
.WithName("DeletePlan")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();
app.Run();
