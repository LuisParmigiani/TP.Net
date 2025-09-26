using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Service;
using DTOs;
using Domain.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace WebApi;

public static class PlanEndpoints
{
    public static void MapPlanEndpoints(this WebApplication app)
    {
       app.MapGet("/planes/{id}", (int id) =>
            {
                PlanService planService = new PlanService();
                PlanDTO plan = planService.Get(id);
                if (plan != null)
                {
                    var dto = new PlanDTO()
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
            .WithTags("Planes")
            .Produces<PlanDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/planes", () =>
            {
                PlanService planService = new PlanService();
                var planes = planService.GetAll();
                var dtos = planes.Select(p => new PlanDTO
                {
                    Id = p.Id,
                    Descripcion = p.Descripcion,
                    IdEspecialidad = p.IdEspecialidad
                }).ToList();

                return Results.Ok(dtos);
            })
            .WithName("GetAllPlanes")
            .WithTags("Planes")
            .Produces<List<PlanDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/planes", (PlanDTO dto) =>
            {
                try
                {
                    PlanService planService = new PlanService();
                    PlanDTO plan = new PlanDTO(dto.Id, dto.Descripcion, dto.IdEspecialidad);
                    planService.Add(plan);

                    var dtoResultado = new PlanDTO
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
            .WithTags("Planes")
            .Produces<PlanDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/planes/{id}", (int id, PlanDTO dto) =>
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
            .WithTags("Planes")
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
            .WithTags("Planes")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();
             
    }
}