using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Model;
using Data;
using DTOs;

namespace Domain.Service
{
    
    public class DictadoService
    {

        public DictadoDTO Add(DictadoDTO dic)
        {
            var dicRepo = new DictadoRepository();
            Dictado dictado = new Dictado(0,dic.Cargo,dic.IDCurso,dic.IDDocente);
            try
            {
                dicRepo.Add(dictado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            dic.Id = dictado.Id;

            return dic;
        }


        public bool Delete(int id)
        {
            var dicRepo = new DictadoRepository();
            return dicRepo.Delete(id);
        }

        public DictadoDTO Get(int id)
        {
            var dicRepo = new DictadoRepository();
            Dictado? dic = dicRepo.Get(id);
            if ( dic == null)
                return null;
            return new DictadoDTO(
                dic.Id,
                dic.Cargo,
                dic.IDCurso,
                dic.IDDocente
            );
        }

        public IEnumerable<DictadoDTO> GetAll()
        {
            var dicRepo = new DictadoRepository();
            return dicRepo.GetAll().Select(dic => new DictadoDTO(
                dic.Id,
                dic.Cargo,
                dic.IDCurso,
                dic.IDDocente
            )).ToList();
        }


        public bool Update(DictadoDTO dic)
        {
            var dicRepo = new DictadoRepository();
            try{
                Dictado dictado = new Dictado(0,dic.Cargo,dic.IDCurso,dic.IDDocente);
                return dicRepo.Update(dictado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
};