using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Model;
using Data;
using DTOs;

namespace Domain.Service
{
    public class PlanService
    {
        
        public PlanDTO Add(PlanDTO esp)
        {
            try
            {
                PlanRepository planRepo = new PlanRepository();
                Plan plan = new Plan(esp.Descripcion, esp.IdEspecialidad, 0);
                planRepo.Add(plan);
                esp.Id = plan.Id;
                return esp;
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }


        public bool Delete(int id)
        {
            PlanRepository planRepo = new PlanRepository();
            return planRepo.Delete(id);
        }

        public PlanDTO Get(int id)
        {
            PlanRepository planRepo = new PlanRepository();
            Plan? plan = planRepo.Get(id);
            if (plan == null)
                return null;
            return new PlanDTO(plan.Id,plan.Descripcion,plan.IdEspecialidad);
        }

        public IEnumerable<PlanDTO> GetAll()
        {
            var planRepo = new PlanRepository();
            return planRepo.GetAll().Select(e => new PlanDTO(e.Id, e.Descripcion,e.IdEspecialidad)).ToList();
        }

        public bool Update(Plan plan)
        {
            var planRepo = new PlanRepository();
            Plan planini = new Plan(plan.Descripcion,plan.IdEspecialidad,plan.Id);
            return planRepo.Update(planini);
            
        }
    }

 
}