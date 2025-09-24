using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;    

namespace Data
{
    public class PersonaRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(Persona per)
        {
            using var context = CreateContext();
            if (context.Planes.Any(p => p.Id == per.IdPlan) != true)
            {
                throw new Exception("No se encontró un plan con el ID ingresado");
            }
            context.Personas.Add(per);
            context.SaveChanges();
        }
        
        public bool Delete(int id)
        {
            using var context = CreateContext();
            var per = context.Personas.Find(id);
            if (per != null)
            {
                context.Personas.Remove(per);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public Persona? Get(int id)
        {
            using var context = CreateContext();
            var per = context.Personas.Find(id);
            return per;
        }
        public IEnumerable<Persona> GetAll()
        {
            using var context = CreateContext();
            return context.Personas.ToList();
        }
        public bool Update(Persona persona)
        {
            using var context = CreateContext();
            var perExists = context.Personas.Find(persona.Id);
            if (perExists != null)
            {
                try
                {
                    perExists.SetNombre(persona.Nombre);
                    perExists.SetApellido(persona.Apellido);
                    perExists.SetDireccion(persona.Direccion);
                    perExists.SetEmail(persona.Email);
                    perExists.SetTelefono(persona.Telefono);
                    perExists.SetFechaNacimiento(persona.FechaNacimiento);
                    perExists.SetLegajo(persona.Legajo);
                    perExists.SetTipoPersona(persona.TipoPersona);
                    if (context.Planes.Any(p => p.Id == persona.IdPlan) == true)
                    {
                        perExists.SetIdPlan(persona.IdPlan);
                    }
                    else
                    {
                        throw new Exception("No se encontró un plan con ese ID");
                    }
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            return false;
        }
        //Puede que en un futuro tengamos más 
    }
}