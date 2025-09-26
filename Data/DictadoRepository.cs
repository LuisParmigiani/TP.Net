using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;    

namespace Data
{
    public class DictadoRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(Dictado dic)
        {
            using var context = CreateContext();
            if (context.Personas.Any(p => p.Id == dic.IDDocente && p.TipoPersona == 1) != true)
            {
                throw new Exception("No se encontró un docente con el ID ingresado");
            }
            if (context.Cursos.Any(c => c.Id == dic.IDCurso) != true)
            {
                throw new Exception("No se encontró un curso con el ID ingresado");
            }
            context.Dictados.Add(dic);
            context.SaveChanges();
        }
        
        public bool Delete(int id)
        {
            using var context = CreateContext();
            var dic = context.Dictados.Find(id);
            if (dic != null)
            {
                context.Dictados.Remove(dic);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public Dictado? Get(int id)
        {
            using var context = CreateContext();
            var dic = context.Dictados.Find(id);
            return dic;
        }
        public IEnumerable<Dictado> GetAll()
        {
            using var context = CreateContext();
            return context.Dictados.ToList();
        }

        public bool Update(Dictado dictado)
        {
            using var context = CreateContext();
            var dicExists = context.Dictados.Find(dictado.Id);
            if (dicExists != null)
            {
                try
                {
                    dicExists.SetCargo(dictado.Cargo);
                    if (context.Personas.Any(p => p.Id == dictado.IDDocente && p.TipoPersona == 1) != true)
                    {
                        throw new Exception("No se encontró un docente con el ID ingresado");
                    }
                    dicExists.SetIDDocente(dictado.IDDocente);
                    if (context.Cursos.Any(c => c.Id == dictado.IDCurso) != true)
                    {
                        throw new Exception("No se encontró un curso con el ID ingresado");
                    }
                    dicExists.SetIDCurso(dictado.IDCurso);
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