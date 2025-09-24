using Domain.Service;
using DTOs;
using Domain.Model;

namespace WebApi;

public static class MateriaEndpoints
{
    public static void MapMateriaEndpoints(this WebApplication app)
    {
        app.MapGet("/materias/{id}", (int id) =>
        {
            MateriaService materiaService = new MateriaService();
            MateriaDTO materia = materiaService.Get(id);
            if (materia != null)
            {
                var dto = new MateriaDTO
                {
                    Id = materia.Id,
                    Descripcion = materia.Descripcion,
                    HSSemanales = materia.HSSemanales,
                    HSTotales = materia.HSTotales,
                    IdPlan = materia.IdPlan
                };
                return Results.Ok(dto);
            }
            else
            {
                return Results.NotFound();
            }
        })
            .WithName("GetMateria")
            .WithTags("Materias")
            .Produces<MateriaDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

        app.MapGet("/materias", () =>
        {
            MateriaService materiaService = new MateriaService();
            var materias = materiaService.GetAll();
            var dtos = materias.Select(m => new MateriaDTO
            {
                Id = m.Id,
                Descripcion = m.Descripcion,
                HSSemanales = m.HSSemanales,
                HSTotales = m.HSTotales,
                IdPlan = m.IdPlan
            }).ToList();

            return Results.Ok(dtos);
        })
            .WithName("GetAllMaterias")
            .WithTags("Materias")
            .Produces<List<MateriaDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

        app.MapPost("/materias", (MateriaDTO mat) =>
        {
            try
            {
                MateriaService matServ = new MateriaService();
                MateriaDTO dto = matServ.Add(mat);
                return Results.Created($"/materias/{dto.Id}", dto);
            }
            catch (ArgumentException ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        })
            .WithName("AddMateria")
            .WithTags("Materias")
            .Produces<MateriaDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

        app.MapPut("/materias/{id}", (int id, MateriaDTO dto) =>
        {
            try
            {
                MateriaService materiaService = new MateriaService();
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
        .WithTags("Materias")
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status400BadRequest)
        .WithOpenApi();

        app.MapDelete("/materias/{id}", (int id) =>
        {
            MateriaService materiaService = new MateriaService();
            var deleted = materiaService.Delete(id);

            if (!deleted)
            {
                return Results.NotFound();
            }

            return Results.NoContent();
        })
        .WithName("DeleteMateria")
        .WithTags("Materias")
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)
        .WithOpenApi();

        
    }
}