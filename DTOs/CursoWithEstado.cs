using System.Net.Sockets;

namespace DTOs;
using DTOs;
using Domain.Model;
public class CursoWithEstado: CursoDTO
{
    public bool Estado { get; set; }

    public CursoWithEstado()
    {
        
    }

    public CursoWithEstado(Curso cursoDTO, bool state): base(cursoDTO.Id,cursoDTO.AnioCalendario,cursoDTO.Cupo,cursoDTO.Descripcion,cursoDTO.IdComision,cursoDTO.IdMateria)
    {
        Estado = state;
    }
}