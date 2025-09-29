namespace DTOs;

public class EstadoAcademico
{
    public int IdMateria { get; set; }

    public string DescMateria { get; set; }
    public string? Condicion { get; set; }
    public int? Nota { get; set; }
    public int? AnioCalendarioCursado { get; set; }
    public int? IdComCursada { get; set; }
    public string? DescComisionCursada { get; set; }
    public int? AnioEspecialidadCursada { get; set; }
    

    public EstadoAcademico()
    {
        
    }

    public EstadoAcademico(int idMat,string descMat,string? cond,int? nota, int? anioCal,int idCom,string? comDesc,int? anioEsp)
    {
        IdMateria = idMat;
        DescMateria = descMat;
        Condicion = cond;
        Nota = nota;
        AnioCalendarioCursado = anioCal;
        IdComCursada = idCom;
        DescComisionCursada = comDesc;
        AnioEspecialidadCursada = anioEsp;
    }
    
    
    
    
}