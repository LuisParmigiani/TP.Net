using Domain.Model;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Data;
public class PlanRepository
{
    private TPIContext CreateContext()
    {
        return new TPIContext();
    }

    public void Add(Plan p)
    {
        using var context = CreateContext();
        //Checkeamos si existe la especialidad con el Id que me pasan 
        var espExists =context.Especialidades.Any(e => e.Id == p.IdEspecialidad);
        if (!espExists)
        {
            throw new InvalidOperationException($"No existe una especialidad con el id: {p.IdEspecialidad}");
        }
        context.Planes.Add(p);
        context.SaveChanges();
        
    }

    public bool Delete(int id)
    {
        using var context = CreateContext();
        var p = context.Planes.Find(id);
        if (p != null)
        {
            context.Planes.Remove(p);
            context.SaveChanges();
            return true;
        }
        return false;
    }

    public Plan? Get(int id)
    {
        using var context = CreateContext();

        var p = context.Planes.Find(id);
        return p;
    }

    public IEnumerable<Plan> GetAll()
    {
        const string sql = "SELECT Id, Descripcion, IdEspecialidad FROM Planes";
        var planes = new List<Plan>();
        string connectionString = new TPIContext().Database.GetConnectionString();

        using var connection = new MySqlConnection(connectionString);
        using var command = new MySqlCommand(sql, connection);

        connection.Open();
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            var plan = new Plan(
                reader.GetString("Descripcion"),      
                reader.GetInt32("IdEspecialidad"),    
                reader.GetInt32("Id")                 
            );

            planes.Add(plan);
        }

        return planes;
    }

    public bool Update(Plan p)
    {
        using var context = CreateContext();
        var pExistente = context.Planes.Find(p.Id);
        if (pExistente != null)
        {
            //El id no se toca
            pExistente.SetDescripcion(p.Descripcion);
            pExistente.SetIdEspecialidad(p.IdEspecialidad);
            context.SaveChanges();
            return true;
        }

        return false;
    }
    //Aca se van a seguir agregando todos los métodos que creamos necesarios
   

}