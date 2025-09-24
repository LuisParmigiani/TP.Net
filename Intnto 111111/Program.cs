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
    UsuarioDTO user = userService.Get(id);
    if (user != null)
    {
        var dto = new UsuarioDTO(user.Id,user.NombreUsuario,user.Clave,user.Habilitado,user.IdPersona,user.CambiaClave);
        return Results.Ok(dto);
    }
    else
    {
        return Results.NotFound();
    }
})
.WithName("GetUsuario")
.Produces<UsuarioDTO>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.MapGet("/usuarios", () =>
{
    UsuarioService userService = new UsuarioService();
    var usuarios = userService.GetAll();
    var dtos = usuarios.Select(p => new UsuarioDTO(p.Id,p.NombreUsuario,p.Clave,p.Habilitado,p.IdPersona,p.CambiaClave)).ToList();
    return Results.Ok(dtos);
})
.WithName("GetAllusuarios")
.Produces<List<UsuarioDTO>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/usuarios", (UsuarioDTO user) =>
{
    try
    {
        UsuarioService userService = new UsuarioService();
        UsuarioDTO usuario = new UsuarioDTO(user.Id,user.NombreUsuario,user.Clave,user.Habilitado,user.IdPersona,user.CambiaClave);
        userService.Add(usuario);

        var dtoResultado = new UsuarioDTO(user.Id,user.NombreUsuario,user.Clave,user.Habilitado,user.IdPersona,user.CambiaClave);

        return Results.Created($"/usuarios/{dtoResultado.Id}", dtoResultado);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddUsuario")
.Produces<UsuarioDTO>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/usuarios/{id}", (int id, UsuarioDTO user) =>
{
    try
    {
        UsuarioService usuarioService = new UsuarioService();
        UsuarioDTO usuario = new UsuarioDTO(user.Id,user.NombreUsuario,user.Clave,user.Habilitado,user.IdPersona,user.CambiaClave);

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
app.MapModuloEndpoints();
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
