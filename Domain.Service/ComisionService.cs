using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Model;
using Data;
using DTOs;

namespace Domain.Service
{
    
    public class ComisionService
    {

        public ComisionDTO Add(ComisionDTO com)
        {
            var comRepo = new ComisionRepository();
            Comision comi = new Comision(0,com.AnioEspecialidad,com.Descripcion,com.IDPlan);
            try
            {
                comRepo.Add(comi);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            com.Id = comi.Id;

            return com;
        }


        public bool Delete(int id)
        {
            var comRepo = new ComisionRepository();
            return comRepo.Delete(id);
        }

        public ComisionDTO Get(int id)
        {
            var comRepository = new ComisionRepository();
            Comision? comi = comRepository.Get(id);
            if (comi == null)
                return null;
            return new ComisionDTO(
                comi.Id,
                comi.AnioEspecialidad,
                comi.Descripcion,
                comi.IDPlan
            );
        }

        public IEnumerable<ComisionDTO> GetAll()
        {
            var comRepo = new ComisionRepository();
            return comRepo.GetAll().Select(comi => new ComisionDTO(
                comi.Id,
                comi.AnioEspecialidad,
                comi.Descripcion,
                comi.IDPlan
            )).ToList();
        }

        public bool Update(ComisionDTO com)
        {
            var comRepo = new ComisionRepository();
            try
            {
            Comision comi = new Comision(0,com.AnioEspecialidad,com.Descripcion,com.IDPlan);
                return comRepo.Update(comi);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
};