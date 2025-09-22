using Domain.Service;
using Domain.Model;
using DTOs;
using Microsoft.AspNetCore.Components.Web;
using Alumno_Inscripcion = Domain.Model.Alumno_Inscripcion;
using Comision = Domain.Model.Comision;
using Curso = Domain.Model.Curso;
using DocenteCurso = Domain.Model.DocenteCurso;
using Especialidad = Domain.Model.Especialidad;
using Materia = Domain.Model.Materia;
using ModuloUsuario = Domain.Model.ModuloUsuario;
using Persona = Domain.Model.Persona;
using Plan = Domain.Model.Plan;
using Usuario = Domain.Model.Usuario;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

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
//Persona 
app.MapGet("/personas/{id}", (int id) =>
{
    PersonaService personaService = new PersonaService();
    Persona persona = personaService.Get(id);
    if (persona != null)
    {
        var dto =new DTOs.Persona(persona.Id, persona.Nombre, persona.Apellido, persona.Direccion,
            persona.Email,
            persona.Telefono, persona.FechaNacimiento, persona.Legajo, persona.TipoPersona, persona.IdPlan);
        return Results.Ok(dto);
    }
    else
    {
        return Results.NotFound();
    }
})
.WithName("GetPersona")
.Produces<DTOs.Persona>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.MapGet("/personas", () =>
{
    PersonaService personaService = new PersonaService();
    var personas = personaService.GetAll();
    var dtos = personas.Select(p => new DTOs.Persona(p.Id, p.Nombre, p.Apellido, p.Direccion, p.Email,
        p.Telefono, p.FechaNacimiento, p.Legajo, p.TipoPersona, p.IdPlan)).ToList();

    return Results.Ok(dtos);
})
.WithName("GetAllPersonas")
.Produces<List<DTOs.Persona>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/personas", (DTOs.Persona dto) =>
{
    try
    {
        PersonaService personaService = new PersonaService();
        Persona persona = new Persona(dto.Id,dto.Nombre, dto.Apellido, dto.Direccion, 
            dto.Email, dto.Telefono, dto.FechaNacimiento, dto.Legajo, 
            dto.TipoPersona, dto.IdPlan);
        personaService.Add(persona);

        var dtoResultado = new DTOs.Persona(persona.Id, persona.Nombre, persona.Apellido, persona.Direccion,
            persona.Email,
            persona.Telefono, persona.FechaNacimiento, persona.Legajo, persona.TipoPersona, persona.IdPlan);

        return Results.Created($"/personas/{dtoResultado.Id}", dtoResultado);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddPersona")
.Produces<DTOs.Persona>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/personas/{id}", (int id, DTOs.Persona dto) =>
{
    try
    {
        PersonaService personaService = new PersonaService();
        Persona persona = new Persona(dto.Id,dto.Nombre, dto.Apellido, dto.Direccion,
            dto.Email, dto.Telefono, dto.FechaNacimiento, dto.Legajo,
            dto.TipoPersona, dto.IdPlan);

        var found = personaService.Update(persona);
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
.WithName("UpdatePersona")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/personas/{id}", (int id) =>
{
    PersonaService personaService = new PersonaService();
    var deleted = personaService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();
})
.WithName("DeletePersona")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();


//Especialidades 
app.MapGet("/especialidades/{id}", (int id) =>
{
    EspecialidadService espService = new EspecialidadService();
    Especialidad esp = espService.Get(id);
    if (esp != null)
    {
        var dto = new DTOs.Especialidad()
        {
            Id = esp.Id,
            Descripcion = esp.Descripcion,
        };
        return Results.Ok(dto);
    }
    else
    {
        return Results.NotFound();
    }
})
.WithName("GetEspecialidad")
.Produces<DTOs.Especialidad>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.MapGet("/especialidades", () =>
{
    EspecialidadService EspService = new EspecialidadService();
    var especialidades = EspService.GetAll();
    var dtos = especialidades.Select(p => new DTOs.Especialidad(p.Id, p.Descripcion)).ToList();
    return Results.Ok(dtos);
})
.WithName("GetAllEspecialidades")
.Produces<List<DTOs.Especialidad>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/especialidades", (DTOs.Especialidad esp) =>
{
    try
    {
        EspecialidadService espService = new EspecialidadService();
        Especialidad especialidad = new Especialidad(esp.Id, esp.Descripcion);
        espService.Add(especialidad);

        var dtoResultado = new DTOs.Especialidad(especialidad.Id, especialidad.Descripcion);

        return Results.Created($"/especialidades/{dtoResultado.Id}", dtoResultado);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("Addespecialidad")
.Produces<DTOs.Especialidad>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/especialidades/{id}", (int id, DTOs.Especialidad dto) =>
{
    try
    {
        EspecialidadService espService = new EspecialidadService();
        Especialidad esp = new Especialidad(dto.Id, dto.Descripcion);

        var found = espService.Update(esp);
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
.WithName("UpdateEspecialidad") 
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/especialidades/{id}", (int id) =>
{
    EspecialidadService espService = new EspecialidadService();
    var deleted = espService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();
})
.WithName("DeleteEspecialidad")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

//Inscripciones 
app.MapGet("/inscripciones/{id}", (int id) =>
{ 
    AlumnoInscripcionService InscService = new AlumnoInscripcionService();
    Alumno_Inscripcion esp = InscService.Get(id);
    if (esp != null)
    {
        var dto = new DTOs.Alumno_Inscripcion(esp.Id,esp.IdAlumno,esp.IdCurso,esp.Nota,esp.Condicion);
        return Results.Ok(dto);
    }
    else
    {
        return Results.NotFound();
    }
})
.WithName("GetInscripcion")
.Produces<DTOs.Alumno_Inscripcion>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.MapGet("/inscripciones", () =>
{
    AlumnoInscripcionService InscService = new AlumnoInscripcionService();
    var inscripciones = InscService.GetAll();
    var dtos = inscripciones.Select(p => new DTOs.Alumno_Inscripcion(p.Id, p.IdAlumno,p.IdCurso,p.Nota,p.Condicion)).ToList();
    return Results.Ok(dtos);
})
.WithName("GetAllInscripciones")
.Produces<List<DTOs.Alumno_Inscripcion>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/inscripciones", (DTOs.Alumno_Inscripcion insc) =>
{
    try
    {
        AlumnoInscripcionService inscService = new AlumnoInscripcionService();
        Alumno_Inscripcion inscripcion = new Alumno_Inscripcion(insc.Id, insc.IdAlumno,insc.IdCurso,insc.Nota,insc.Condicion);
        inscService.Add(inscripcion);

        var dtoResultado = new DTOs.Alumno_Inscripcion(insc.Id, insc.IdAlumno,insc.IdCurso,insc.Nota,insc.Condicion);

        return Results.Created($"/inscripciones/{dtoResultado.Id}", dtoResultado);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddInscripcion")
.Produces<DTOs.Alumno_Inscripcion>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/inscripciones/{id}", (int id, DTOs.Alumno_Inscripcion dto) =>
{
    try
    {
        AlumnoInscripcionService inscService = new AlumnoInscripcionService();
        Alumno_Inscripcion insc = new Alumno_Inscripcion(dto.Id, dto.IdAlumno,dto.IdCurso,dto.Nota,dto.Condicion);

        var found = inscService.Update(insc);
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
.WithName("UpdateInscripcion") 
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/inscripciones/{id}", (int id) =>
{
    AlumnoInscripcionService inscService = new AlumnoInscripcionService();
    var deleted = inscService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();
})
.WithName("DeleteInscripcion")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

//Usuarios 
app.MapGet("/usuarios/{id}", (int id) =>
{ 
    UsuarioService userService = new UsuarioService();
    Usuario user = userService.Get(id);
    if (user != null)
    {
        var dto = new DTOs.Usuario(user.Id,user.NombreUsuario,user.Clave,user.Habilitado,user.IdPersona,user.CambiaClave);
        return Results.Ok(dto);
    }
    else
    {
        return Results.NotFound();
    }
})
.WithName("GetUsuario")
.Produces<DTOs.Usuario>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.MapGet("/usuarios", () =>
{
    UsuarioService userService = new UsuarioService();
    var usuarios = userService.GetAll();
    var dtos = usuarios.Select(p => new DTOs.Usuario(p.Id,p.NombreUsuario,p.Clave,p.Habilitado,p.IdPersona,p.CambiaClave)).ToList();
    return Results.Ok(dtos);
})
.WithName("GetAllusuarios")
.Produces<List<DTOs.Usuario>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/usuarios", (DTOs.Usuario user) =>
{
    try
    {
        UsuarioService userService = new UsuarioService();
        Usuario usuario = new Usuario(user.Id,user.NombreUsuario,user.Clave,user.Habilitado,user.CambiaClave,user.IdPersona);
        userService.Add(usuario);

        var dtoResultado = new DTOs.Usuario(user.Id,user.NombreUsuario,user.Clave,user.Habilitado,user.IdPersona,user.CambiaClave);

        return Results.Created($"/usuarios/{dtoResultado.Id}", dtoResultado);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddUsuario")
.Produces<DTOs.Usuario>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/usuarios/{id}", (int id, DTOs.Usuario user) =>
{
    try
    {
        UsuarioService usuarioService = new UsuarioService();
        Usuario usuario = new Usuario(user.Id,user.NombreUsuario,user.Clave,user.Habilitado,user.CambiaClave,user.IdPersona);

        var found = usuarioService.Update(usuario);
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
.WithName("UpdateUsuario") 
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/usuarios/{id}", (int id) =>
{
    UsuarioService usuarioService = new UsuarioService();
    var deleted = usuarioService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();
})
.WithName("DeleteUsuario")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();
//Modulos 
app.MapGet("/modulos/{id}", (int id) =>
{
    ModuloService ModService = new ModuloService();
    ModuloDTO mod = ModService.Get(id);
    if (mod != null)
    {
        return Results.Ok(mod);
    }
    else
    {
        return Results.NotFound();
    }
})
.WithName("GetModulo")
.Produces<ModuloDTO>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.MapGet("/modulos", () =>
{
    ModuloService ModService = new ModuloService();
    var modulos = ModService.GetAll();
    return Results.Ok(modulos);
})
.WithName("GetAllModulos")
.Produces<List<ModuloDTO>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/modulos", (ModuloDTO mod) =>
{
    try
    {
        ModuloService ModService = new ModuloService();
        ModuloDTO dto = ModService.Add(mod);
        return Results.Created($"/modulos/{dto.Id}", dto);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddModulo")
.Produces<ModuloDTO>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/modulos/{id}", (int id, ModuloDTO dto) =>
{
    try
    {
        ModuloService modService = new ModuloService();
        var found = modService.Update(dto);
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
.WithName("UpdateModulo") 
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/modulos/{id}", (int id) =>
{
    ModuloService moduloService = new ModuloService();
    var deleted = moduloService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();
})
.WithName("DeleteModulo")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();
//Modulos Usuarios
app.MapGet("/modulo-usuario/{id}", (int id) =>
{
    ModuloUsuarioService ModService = new ModuloUsuarioService();
    ModuloUsuario mod = ModService.Get(id);
    if (mod != null)
    {
        var dto = new DTOs.ModuloUsuario()
        {
            Id = mod.Id,
            IdModulo = mod.IdModulo,
            IdUsuario = mod.IdUsuario,
            Alta = mod.Alta,
            Baja = mod.Baja,
            Modificacion = mod.Modificacion,
            Consulta = mod.Consulta
        };
        return Results.Ok(dto);
    }
    else
    {
        return Results.NotFound();
    }
})
.WithName("GetModuloUsuario")
.Produces<DTOs.ModuloUsuario>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();
app.MapGet("/modulo-usuario", () =>
{
    ModuloUsuarioService ModService = new ModuloUsuarioService();
    var modulos = ModService.GetAll();
    var dtos = modulos.Select(p => new DTOs.ModuloUsuario(p.Id,p.IdModulo,p.IdUsuario,p.Alta,p.Baja,p.Modificacion,p.Consulta)).ToList();
    return Results.Ok(dtos);
})
.WithName("GetAllModuloUsuarios")
.Produces<List<DTOs.ModuloUsuario>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/modulo-usuario", (DTOs.ModuloUsuario mod) =>
{
    try
    {
        ModuloUsuarioService ModService = new ModuloUsuarioService();
        ModuloUsuario modulo = new ModuloUsuario(mod.Id, mod.IdModulo,mod.IdUsuario,mod.Alta,mod.Baja,mod.Modificacion,mod.Consulta);
        ModService.Add(modulo);

        var dtoResultado = new DTOs.ModuloUsuario(modulo.Id,modulo.IdModulo,modulo.IdUsuario,modulo.Alta,modulo.Baja,modulo.Modificacion,modulo.Consulta);

        return Results.Created($"/modulos/{dtoResultado.Id}", dtoResultado);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddModuloUsuario")
.Produces<DTOs.ModuloUsuario>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/modulo-usuario/{id}", (int id, DTOs.ModuloUsuario dto) =>
{
    try
    {
        ModuloUsuarioService modService = new ModuloUsuarioService();
        ModuloUsuario esp = new ModuloUsuario(dto.Id,dto.IdModulo,dto.IdUsuario,dto.Alta,dto.Baja,dto.Modificacion,dto.Consulta);

        var found = modService.Update(esp);
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
.WithName("UpdateModuloUsuario") 
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/modulo-usuario/{id}", (int id) =>
{
    ModuloUsuarioService moduloService = new ModuloUsuarioService();
    var deleted = moduloService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();
})
.WithName("DeleteModuloUsuario")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();
app.Run();
