using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Service;
using DTOs;
using Domain.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace WebApi;

public static class EspecialidadEndpoints
{
    public static void MapEspecialidadEndpoints(this WebApplication app)
    {
            app.MapGet("/especialidades/{id}", (int id) =>
            {
                EspecialidadService espService = new EspecialidadService();
                EspecialidadDTO esp = espService.Get(id);
                if (esp != null)
                {
                    var dto = new EspecialidadDTO()
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
            .WithTags("Especialidades")
            .Produces<EspecialidadDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/especialidades", () =>
            {
                EspecialidadService EspService = new EspecialidadService();
                var especialidades = EspService.GetAll();
                var dtos = especialidades.Select(p => new EspecialidadDTO(p.Id, p.Descripcion)).ToList();
                return Results.Ok(dtos);
            })
            .WithName("GetAllEspecialidades")
            .WithTags("Especialidades")
            .Produces<List<EspecialidadDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/especialidades", (EspecialidadDTO esp) =>
            {
                try
                {
                    EspecialidadService espService = new EspecialidadService();
                    EspecialidadDTO especialidad = new EspecialidadDTO(esp.Id, esp.Descripcion);
                    espService.Add(especialidad);

                    var dtoResultado = new EspecialidadDTO(especialidad.Id, especialidad.Descripcion);

                    return Results.Created($"/especialidades/{dtoResultado.Id}", dtoResultado);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("Addespecialidad")
            .WithTags("Especialidades")
            .Produces<EspecialidadDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/especialidades/{id}", (int id, EspecialidadDTO dto) =>
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
            .WithTags("Especialidades")
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
            .WithTags("Especialidades")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

    }
}