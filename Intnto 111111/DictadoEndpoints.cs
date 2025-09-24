using Domain.Service;
using DTOs;
using Domain.Model;

namespace WebApi;

public static class DictadoEndpoints
{
    public static void MapDictadoEndpoints(this WebApplication app)
    {
                app.MapGet("/dictados/{id}", (int id) =>
                {
                    DictadoService dictadoService = new DictadoService();
                    DictadoDTO dictado = dictadoService.Get(id);
                    if (dictado != null)
                    {
                        var dto = new DictadoDTO
                        {
                            Id = dictado.Id,
                            Cargo = dictado.Cargo,
                            IDCurso = dictado.IDCurso,
                            IDDocente = dictado.IDDocente
                        };
                        return Results.Ok(dto);
                    }
                    else
                    {
                        return Results.NotFound();
                    }
                })
                .WithName("GetDocenteCurso")
                .WithTags("Dictado")
                .Produces<DictadoDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();

                app.MapGet("/dictados", () =>
                {
                    DictadoService dictadoService = new DictadoService();
                    var docenteCursos = dictadoService.GetAll();
                    var dtos = docenteCursos.Select(dc => new DictadoDTO
                    {
                        Id = dc.Id,
                        Cargo = dc.Cargo,
                        IDCurso = dc.IDCurso,
                        IDDocente = dc.IDDocente
                    }).ToList();

                    return Results.Ok(dtos);
                })
                .WithName("GetAllDocenteCursos")
                .WithTags("Dictado")
                .Produces<List<DictadoDTO>>(StatusCodes.Status200OK)
                .WithOpenApi();

                app.MapPost("/dictados", (DictadoDTO dto) =>
                {
                    try
                    {
                        DictadoService dictadoService = new DictadoService();
                        DictadoDTO dictado = new DictadoDTO(dto.Id, dto.Cargo, dto.IDCurso, dto.IDDocente);
                        dictadoService.Add(dictado);

                        var dtoResultado = new DictadoDTO
                        {
                            Id = dictado.Id,
                            Cargo = dictado.Cargo,
                            IDCurso = dictado.IDCurso,
                            IDDocente = dictado.IDDocente
                        };

                        return Results.Created($"/dictados/{dtoResultado.Id}", dtoResultado);
                    }
                    catch (ArgumentException ex)
                    {
                        return Results.BadRequest(new { error = ex.Message });
                    }
                })
                .WithName("AddDocenteCurso")
                .WithTags("Dictado")
                .Produces<DictadoDTO>(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

                app.MapPut("/dictados/{id}", (int id, DictadoDTO dto) =>
                {
                    try
                    {
                        DictadoService dictadoService = new DictadoService();
                        dto.Id = id; // Asegurar que el ID del DTO coincida con el ID de la ruta
                        DictadoDTO dictado = new DictadoDTO(dto.Id, dto.Cargo, dto.IDCurso, dto.IDDocente);

                        var found = dictadoService.Update(dictado);
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
                .WithTags("Dictado")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

                app.MapDelete("/dictados/{id}", (int id) =>
                {
                    DictadoService dictadoService = new DictadoService();
                    var deleted = dictadoService.Delete(id);

                    if (!deleted)
                    {
                        return Results.NotFound();
                    }

                    return Results.NoContent();
                })
                    .WithName("DeleteDocenteCurso")
                    .WithTags("Dictado")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();
    }
}