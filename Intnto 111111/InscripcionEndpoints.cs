using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Service;
using DTOs;
using Domain.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace WebApi;

public static class InscripcionEndpoints
{
    public static void MapInscripcionEndpoints(this WebApplication app)
    {
                app.MapGet("/inscripciones/{id}", (int id) =>
                { 
                    InscripcionService InscService = new InscripcionService();
                    InscripcionDTO esp = InscService.Get(id);
                    if (esp != null)
                    {
                        var dto = new InscripcionDTO(esp.Id,esp.IdAlumno,esp.IdCurso,esp.Nota,esp.Condicion);
                        return Results.Ok(dto);
                    }
                    else
                    {
                        return Results.NotFound();
                    }
                })
                .WithName("GetInscripcion")
                .WithTags("Inscripciones")
                .Produces<InscripcionDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();

                app.MapGet("/inscripciones", () =>
                {
                    InscripcionService InscService = new InscripcionService();
                    var inscripciones = InscService.GetAll();
                    var dtos = inscripciones.Select(p => new InscripcionDTO(p.Id, p.IdAlumno,p.IdCurso,p.Nota,p.Condicion)).ToList();
                    return Results.Ok(dtos);
                })
                .WithName("GetAllInscripciones")
                .WithTags("Inscripciones")
                .Produces<List<InscripcionDTO>>(StatusCodes.Status200OK)
                .WithOpenApi();

                app.MapGet("/inscripciones/estadoOfAlumno/{idAlumno}", (int idAlumno) =>
                    {
                        InscripcionService InscService = new InscripcionService();
                        try
                        {
                            var estados = InscService.GetEstadoAcademicoOfAlumno(idAlumno);
                            var dtos = estados.Select(p => new EstadoAcedemico(
                                    p.Id_Inscripcion,
                                    p.Id_Alumno,
                                    p.Condicion,
                                    p.Nota,
                                    p.Id_Curso,
                                    p.AnioCalendario,
                                    p.Id_Comision,
                                    p.Descripcion_Comision,
                                    p.Id_Materia,
                                    p.Descripcion_Materia
                                )
                            ).ToList();
                            return Results.Ok(dtos);
                        }
                        catch (Exception ex)
                        {
                            return Results.NotFound(ex.Message);
                        }
                    })
                    .WithName("GetEstadoAcademicoOfAlumno")
                    .WithTags("Inscripciones")
                    .Produces<List<EstadoAcedemico>>(StatusCodes.Status200OK)
                    .Produces(StatusCodes.Status404NotFound)
                    .WithOpenApi();
                app.MapPost("/inscripciones", (InscripcionDTO insc) =>
                {
                    try
                    {
                        InscripcionService inscService = new InscripcionService();
                        InscripcionDTO inscripcion = new InscripcionDTO(insc.Id, insc.IdAlumno,insc.IdCurso,insc.Nota,insc.Condicion);
                        inscService.Add(inscripcion);

                        var dtoResultado = new InscripcionDTO(insc.Id, insc.IdAlumno,insc.IdCurso,insc.Nota,insc.Condicion);

                        return Results.Created($"/inscripciones/{dtoResultado.Id}", dtoResultado);
                    }
                    catch (ArgumentException ex)
                    {
                        return Results.BadRequest(new { error = ex.Message });
                    }
                })
                .WithName("AddInscripcion")
                .WithTags("Inscripciones")
                .Produces<InscripcionDTO>(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

                app.MapPut("/inscripciones/{id}", (int id, InscripcionDTO dto) =>
                {
                    try
                    {
                        InscripcionService inscService = new InscripcionService();
                        InscripcionDTO insc = new InscripcionDTO(dto.Id, dto.IdAlumno,dto.IdCurso,dto.Nota,dto.Condicion);

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
                .WithTags("Inscripciones")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

                app.MapDelete("/inscripciones/{id}", (int id) =>
                {
                    InscripcionService inscService = new InscripcionService();
                    var deleted = inscService.Delete(id);

                    if (!deleted)
                    {
                        return Results.NotFound();
                    }

                    return Results.NoContent();
                })
                .WithName("DeleteInscripcion")
                .WithTags("Inscripciones")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();
    }
}