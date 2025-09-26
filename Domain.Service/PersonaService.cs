using Domain.Model;
using Data;
using DTOs;

namespace Domain.Service
{
    
    public class PersonaService
    {

        public PersonaDTO Add(PersonaDTO per)
        {
            var perRepo = new PersonaRepository();
            Persona persona = new Persona(0,per.Nombre,per.Apellido,per.Direccion,per.Email,per.Telefono,per.FechaNacimiento,per.Legajo,per.TipoPersona,per.IdPlan);
            try
            {
                perRepo.Add(persona);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            per.Id = persona.Id;

            return per;
        }


        public bool Delete(int id)
        {
            var usuaRepository = new PersonaRepository();
            return usuaRepository.Delete(id);
        }

        public PersonaDTO Get(int id)
        {
            var perRepo = new PersonaRepository();
            Persona? persona = perRepo.Get(id);
            if (persona == null)
                return null;
            return new PersonaDTO(
                persona.Id,
                persona.Nombre,
                persona.Apellido,
                persona.Direccion,
                persona.Email,
                persona.Telefono,
                persona.FechaNacimiento,
                persona.Legajo,
                persona.TipoPersona,
                persona.IdPlan
            );
        }

        public IEnumerable<PersonaDTO> GetAll()
        {
            var perRepo = new PersonaRepository();
            return perRepo.GetAll().Select(persona => new PersonaDTO(
                persona.Id,
                persona.Nombre,
                persona.Apellido,
                persona.Direccion,
                persona.Email,
                persona.Telefono,
                persona.FechaNacimiento,
                persona.Legajo,
                persona.TipoPersona,
                persona.IdPlan
            )).ToList();
        }
        public IEnumerable<PersonaDTO> GetByCurso(int idCurso)
        {
            var perRepo = new PersonaRepository();
            try
            {
                return perRepo.GetByCurso(idCurso).Select(persona => new PersonaDTO(
                    persona.Id,
                    persona.Nombre,
                    persona.Apellido,
                    persona.Direccion,
                    persona.Email,
                    persona.Telefono,
                    persona.FechaNacimiento,
                    persona.Legajo,
                    persona.TipoPersona,
                    persona.IdPlan
                )).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(PersonaDTO per)
        {
            var perRepo = new PersonaRepository();
            try
            {
                Persona persona = new Persona(per.Id, per.Nombre, per.Apellido, per.Direccion, per.Email, per.Telefono,
                    per.FechaNacimiento, per.Legajo, per.TipoPersona, per.IdPlan);
                return perRepo.Update(persona);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
};