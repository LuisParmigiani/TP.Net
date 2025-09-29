using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Service;
using DTOs;
using Domain.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace WebApi;

public static class UsuarioEndpoints
{

    public static void MapUsuarioEndpoints(this WebApplication app)
    {
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
                .WithTags("Usuarios")
                .Produces<UsuarioDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();
                app.MapGet("/usuarios/{username}/{password}", (string username, string password) =>
                    { 
                        UsuarioService userService = new UsuarioService();
                        var user = userService.Login(username, password);
                        return Results.Ok(user);
                    })
                    .WithName("LoginUsuario")
                    .WithTags("Usuarios")
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
                .WithName("GetAllUsuarios")
                .WithTags("Usuarios")
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
                .WithTags("Usuarios")
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
                .WithTags("Usuarios")
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
                .WithTags("Usuarios")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();
                }
}