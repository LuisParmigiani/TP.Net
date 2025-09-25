using Domain.Service;
using DTOs;
using Domain.Model;

namespace WebApi;

public static class PersonaEndpoints
{
    public static void MapPersonaEndpoints(this WebApplication app)
    {
                app.MapGet("/personas/{id}", (int id) =>
                {
                    PersonaService personaService = new PersonaService();
                    PersonaDTO persona = personaService.Get(id);
                    if (persona != null)
                    {
                        var dto =new PersonaDTO(persona.Id, persona.Nombre, persona.Apellido, persona.Direccion,
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
                .WithTags("Personas")
                .Produces<PersonaDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();

                app.MapGet("/personas", () =>
                {
                    PersonaService personaService = new PersonaService();
                    var personas = personaService.GetAll();
                    var dtos = personas.Select(p => new PersonaDTO(p.Id, p.Nombre, p.Apellido, p.Direccion, p.Email,
                        p.Telefono, p.FechaNacimiento, p.Legajo, p.TipoPersona, p.IdPlan)).ToList();

                    return Results.Ok(dtos);
                })
                .WithName("GetAllPersonas")
                .WithTags("Personas")
                .Produces<List<PersonaDTO>>(StatusCodes.Status200OK)
                .WithOpenApi();

                app.MapPost("/personas", (PersonaDTO dto) =>
                {
                    try
                    {
                        PersonaService personaService = new PersonaService();
                        PersonaDTO persona = new PersonaDTO(dto.Id,dto.Nombre, dto.Apellido, dto.Direccion, 
                            dto.Email, dto.Telefono, dto.FechaNacimiento, dto.Legajo, 
                            dto.TipoPersona, dto.IdPlan);
                        personaService.Add(persona);

                        var dtoResultado = new PersonaDTO(persona.Id, persona.Nombre, persona.Apellido, persona.Direccion,
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
                .WithTags("Personas")
                .Produces<PersonaDTO>(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

                app.MapPut("/personas/{id}", (int id, PersonaDTO dto) =>
                {
                    try
                    {
                        PersonaService personaService = new PersonaService();
                        PersonaDTO persona = new PersonaDTO(id,dto.Nombre, dto.Apellido, dto.Direccion,
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
                .WithTags("Personas")
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
                .WithTags("Personas")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();
             
    }
}