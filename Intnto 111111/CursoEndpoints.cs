using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Service;
using DTOs;
using Domain.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace WebApi;

public static class CursoEndpoints
{
    public static void MapCursoEndpoints(this WebApplication app)
    {
                app.MapGet("/cursos/{id}", (int id) =>
                {
                    CursoService cursoService = new CursoService();
                    CursoDTO cur = cursoService.Get(id);
                    if (cur != null)
                    {
                        var dto = new CursoDTO()
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
                .WithTags("Cursos")
                .Produces<CursoDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();
                app.MapGet("/cursos", () =>
                    {
                        CursoService cursoService = new CursoService();
                        var cursos = cursoService.GetAll();
                        var dtos = cursos.Select(c => new CursoDTO
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
                    .WithTags("Cursos")
                    .Produces<List<CursoDTO>>(StatusCodes.Status200OK)
                    .WithOpenApi();

                app.MapGet("/cursos/Byprofesor/{profId}", (int profId) =>
                {
                    CursoService cursoService = new CursoService();
                    var cursos = cursoService.GetByProfesor(profId);
                    var dtos = cursos.Select(c => new CursoDTO
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
                .WithName("GetCursosByProfId")
                .WithTags("Cursos")
                .Produces<List<CursoDTO>>(StatusCodes.Status200OK)
                .WithOpenApi();
                app.MapGet("/cursos/ByMateria/{matId}", (int matId) =>
                    {
                        CursoService cursoService = new CursoService();
                        try
                        {
                            var cursos = cursoService.GetByMateriaId(matId);
                            if (!cursos.Any())
                            {
                                return Results.NotFound(new { error = "No courses found for this materia" });
                            }

                            var dtos = cursos.Select(c => new CursoWithEstado
                            {
                                Id = c.Id,
                                AnioCalendario = c.AnioCalendario,
                                Cupo = c.Cupo,
                                Descripcion = c.Descripcion,
                                IdComision = c.IdComision,
                                IdMateria = c.IdMateria,
                                Estado = c.Estado
                            }).ToList();

                            return Results.Ok(dtos);
                        }
                        catch (ArgumentException ex)
                        {
                            return Results.BadRequest(new { error = ex.Message });
                        }
                        catch (Exception ex)
                        {
                            return TypedResults.Problem(ex.Message);
                        }
                    })
                    .WithName("GetCursosByMatId")
                    .WithTags("Cursos")
                    .Produces<List<CursoWithEstado>>(StatusCodes.Status200OK)
                    .Produces(StatusCodes.Status400BadRequest)
                    .Produces(StatusCodes.Status404NotFound)
                    .Produces(StatusCodes.Status500InternalServerError)
                    .WithOpenApi();


                app.MapPost("/cursos", (CursoDTO dto) =>
                {
                    try
                    {
                        CursoService cursoService = new CursoService();
                        CursoDTO curso = new CursoDTO(dto.Id,dto.AnioCalendario,dto.Cupo, dto.Descripcion, dto.IdComision, dto.IdMateria);
                        cursoService.Add(curso);

                        var dtoResultado = new CursoDTO
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
                .WithTags("Cursos")
                .Produces<CursoDTO>(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

                app.MapPut("/cursos/{id}", (int id, CursoDTO dto) =>
                {
                    try
                    {
                        CursoService cursoService = new CursoService();
                        CursoDTO curso = new CursoDTO(id,dto.AnioCalendario,dto.Cupo, dto.Descripcion, dto.IdComision, dto.IdMateria);
                        var found = cursoService.Update(curso);
                        if (!found)
                        {
                            return Results.NotFound();
                        }

                        return Results.Ok(curso);
                    }
                    catch (ArgumentException ex)
                    {
                        return Results.BadRequest(new { error = ex.Message });
                    }
                })
                .WithName("UpdateCurso") 
                .WithTags("Cursos")
                .Produces(StatusCodes.Status200OK)
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
                    .WithTags("Cursos")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();
    }
}