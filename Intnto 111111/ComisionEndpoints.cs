using Domain.Service;
using DTOs;
using Domain.Model;

namespace WebApi;

public static class ComisionEndpoints
{
    public static void MapComisionEndpoints(this WebApplication app)
    {
                app.MapGet("/comisiones/{id}", (int id) =>
                {
                    ComisionService comisionService = new ComisionService();
                    ComisionDTO comision = comisionService.Get(id);
                    if (comision != null)
                    {
                        var dto = new ComisionDTO
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
                .WithTags("Comisiones")
                .Produces<ComisionDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();

                app.MapGet("/comisiones", () =>
                {
                    ComisionService comisionService = new ComisionService();
                    var comisiones = comisionService.GetAll();
                    var dtos = comisiones.Select(c => new ComisionDTO
                    {
                        Id = c.Id,
                        Descripcion = c.Descripcion,
                        AnioEspecialidad = c.AnioEspecialidad,
                        IDPlan = c.IDPlan
                    }).ToList();

                    return Results.Ok(dtos);
                })
                .WithName("GetAllComisiones")
                .WithTags("Comisiones")
                .Produces<List<ComisionDTO>>(StatusCodes.Status200OK)
                .WithOpenApi();

                app.MapPost("/comisiones", (ComisionDTO dto) =>
                {
                    try
                    {
                        ComisionService comisionService = new ComisionService();
                        ComisionDTO comision = new ComisionDTO(dto.Id, dto.AnioEspecialidad, dto.Descripcion, dto.IDPlan);
                        comisionService.Add(comision);

                        var dtoResultado = new ComisionDTO
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
                .WithTags("Comisiones")
                .Produces<ComisionDTO>(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

                app.MapPut("/comisiones/{id}", (int id, ComisionDTO dto) =>
                {
                    try
                    {
                        ComisionService comisionService = new ComisionService();
                        dto.Id = id; // Asegurar que el ID del DTO coincida con el ID de la ruta
                        ComisionDTO comision = new ComisionDTO(dto.Id, dto.AnioEspecialidad, dto.Descripcion, dto.IDPlan);

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
                .WithTags("Comisiones")
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
                .WithTags("Comisiones")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();


                             
    }
}