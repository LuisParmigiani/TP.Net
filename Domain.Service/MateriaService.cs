using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Model;
using Data;
using DTOs;

namespace Domain.Service
{
    public class MateriaService
    {
        
        public MateriaDTO Add(MateriaDTO mat)
        {
            try
            {
                MateriaRepository matRepo = new MateriaRepository();
                Materia materia = new Materia(0, mat.Descripcion, mat.HSSemanales, mat.HSTotales, mat.IdPlan);
                matRepo.Add(materia);
                mat.Id = materia.Id;
                return mat;
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }


        public bool Delete(int id)
        {
            MateriaRepository matRepo = new MateriaRepository();
            return matRepo.Delete(id);
        }

        public MateriaDTO Get(int id)
        {
            MateriaRepository matRepo = new MateriaRepository();
            Materia? mat = matRepo.Get(id);
            if (mat == null)
                return null;
            return new MateriaDTO(mat.Id,mat.Descripcion,mat.HSSemanales,mat.HSTotales,mat.IDPlan);
        }

        public IEnumerable<MateriaDTO> GetAll()
        {
            var matRepo = new MateriaRepository();
            return matRepo.GetAll().Select(mat => new MateriaDTO(mat.Id,mat.Descripcion,mat.HSSemanales,mat.HSTotales,mat.IDPlan)).ToList();
        }

        public bool Update(Materia mat)
        {
            var matRepo = new MateriaRepository();
            Materia materini = new Materia(mat.Id,mat.Descripcion,mat.HSSemanales,mat.HSTotales,mat.IDPlan);
            return matRepo.Update(materini);
        }
    }

 
}