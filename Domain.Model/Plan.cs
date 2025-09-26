using System;
using System.Collections.Generic;

namespace Domain.Model
{
    public class Plan : BusinessEntity
    {
        public string Descripcion { get; private set; }
        public int IdEspecialidad { get;  private set; }
        
        public ICollection<Materia> Materias { get; set; }
        public ICollection<Comision> Comisiones { get; set; }
        
        public ICollection<Persona> Alumnos { get; set; }

        public Plan()
        {
            
        }
        public Plan(string desc, int idEspecialidad, int id) : base(id)
        {
            SetDescripcion(desc);
            SetIdEspecialidad(idEspecialidad);
        
        }


        public void SetDescripcion(string descripcion)
        {
            if (string.IsNullOrEmpty(descripcion))
            {
                Console.WriteLine("La descripcion no puede ser vacía o nula");
            }
            else
            {
                Descripcion = descripcion;
            }
        }

        public void SetIdEspecialidad(int idEspecialidad)
        {
            if (idEspecialidad < 0 )
            {
                Console.WriteLine("El id de especialidad no puede ser menor a 0");
            }
            else
            {
                IdEspecialidad = idEspecialidad;
            }
        }
    }
}

