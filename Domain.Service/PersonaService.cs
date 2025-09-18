
using Domain.Model;
using Data;

namespace Domain.Service
{
    public class PersonaService
    {

        public void Add(Persona per)
        {
            PersonaInMemory.Personas.Add(per);
        }


        public bool Delete(int id)
        {
            Persona? perToDelete = PersonaInMemory.Personas.Find(x => x.Id == id);
            if (perToDelete != null)
            {
                PersonaInMemory.Personas.Remove(perToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Persona Get(int id)
        {
            return PersonaInMemory.Personas.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Persona> GetAll()
        {
            return PersonaInMemory.Personas.ToList();
        }

        public bool Update(Persona persona)
        {
            var personaToUpdate = PersonaInMemory.Personas.FirstOrDefault(x => x.Id == persona.Id);
            if (personaToUpdate != null)
            {
                personaToUpdate.SetNombre(persona.Nombre);
                personaToUpdate.SetApellido(persona.Apellido);
                personaToUpdate.SetDireccion(persona.Direccion);
                personaToUpdate.SetTelefono(persona.Telefono);
                personaToUpdate.SetEmail(persona.Email);
                personaToUpdate.SetFechaNacimiento(persona.FechaNacimiento);
                personaToUpdate.SetIdPlan(persona.IdPlan);
                personaToUpdate.SetLegajo(persona.Legajo);
                personaToUpdate.SetTipoPersona(persona.TipoPersona);
                
            
                return true;
            }
            else
            {
                return false;
            }
        }
    }

 
}
 