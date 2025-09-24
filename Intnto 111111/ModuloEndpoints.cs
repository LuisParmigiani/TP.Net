using Domain.Service;
using DTOs;
using Domain.Model;

namespace WebApi;

public static class ModuloEndpoints
{
    public static void MapModuloEndpoints(this WebApplication app)
    {
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
                .WithTags("Modulos")
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
                .WithTags("Modulos")
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
                .WithTags("Modulos")
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
                .WithTags("Modulos")
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
                .WithTags("Modulos")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();
    }
}