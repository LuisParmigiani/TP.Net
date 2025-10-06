using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using Domain.Model;
using Data;
using DTOs;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Document = QuestPDF.Fluent.Document;

namespace Domain.Service
{
    
    public class UsuarioService
    {

        public UsuarioDTO Add(UsuarioDTO user)
        {
            var usuarioRepository = new UsuarioRepository();
            Usuario us = new Usuario(0,user.NombreUsuario,user.Clave,user.Habilitado,user.CambiaClave,user.IdPersona);
            try
            {
                usuarioRepository.Add(us);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            user.Id = us.Id;

            return user;
        }


        public bool Delete(int id)
        {
            var usuaRepository = new UsuarioRepository();
            return usuaRepository.Delete(id);
        }

        public UsuarioDTO Get(int id)
        {
            var usRepository = new UsuarioRepository();
            Usuario? usuario = usRepository.Get(id);
            if (usuario == null)
                return null;
            return new UsuarioDTO(
                usuario.Id,
                usuario.NombreUsuario,
                usuario.Clave,
                usuario.Habilitado,
                usuario.IdPersona,
                usuario.CambiaClave
                );
        }

        public IEnumerable<UsuarioDTO> GetAll()
        {
            var usRepo = new UsuarioRepository();
            return usRepo.GetAll().Select(usuario => new UsuarioDTO(
                usuario.Id,
                usuario.NombreUsuario,
                usuario.Clave,
                usuario.Habilitado,
                usuario.IdPersona,
                usuario.CambiaClave
            )).ToList();
        }

        public byte[] ReporteAlumnosPorCur(int cursoId)
        {
            var usRepo = new UsuarioRepository();
            var curRepo = new CursoRepository();
            var matRepo = new MateriaRepository();
            var comRepo = new ComisionRepository();

            static IContainer HeaderCellStyle(IContainer container) =>
                container
                    .PaddingVertical(5)
                    .Background(Colors.Grey.Lighten2)
                    .BorderBottom(1)
                    .BorderColor(Colors.Grey.Lighten1)
                    .AlignCenter()
                    .AlignMiddle();

// 🟦 Estilo para filas de datos (con color alterno)
            static IContainer DataCellStyle(IContainer container, bool isEvenRow) =>
                container
                    .PaddingVertical(4)
                    .Background(isEvenRow ? Colors.Grey.Lighten5 : Colors.White)
                    .BorderBottom(0.5f)
                    .BorderColor(Colors.Grey.Lighten3)
                    .AlignMiddle();  
            try
            {
                Curso curso = curRepo.Get(cursoId);
                Materia mat = matRepo.Get(curso.IdMateria);
                Comision com = comRepo.Get(curso.IdComision);
                QuestPDF.Settings.License = LicenseType.Community;  
                var alumnos = usRepo.GetAlumnosByIdCurso(cursoId).Select(aluInsc => new AlumnoInscripcion(
                    aluInsc.IdALumno,
                    aluInsc.LegajoAlumno,
                    aluInsc.NombreAlumno,
                    aluInsc.ApellidoAlumno,
                    aluInsc.IdInscripcion,
                    aluInsc.Nota
                )).ToList();
                using var stream = new MemoryStream();
                var doc = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Margin(40);
                        page.Header().Column(column =>
                        {
                            column.Item().Text("Reporte de Alumnos").FontSize(22).Bold().AlignCenter();
                            column.Item().Text($"Año: {curso.AnioCalendario}").AlignCenter();
                            column.Item().Text($"Materia: {mat.Descripcion} | Comisión: {com.Descripcion}").AlignCenter();
                            column.Item().PaddingTop(5).LineHorizontal(1).LineColor(Colors.Grey.Lighten1);
                        });
                        page.Content().Table(table =>
                        {
                            // 🔹 Definimos las columnas
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(40);   // #
                                columns.RelativeColumn(2);    // Legajo
                                columns.RelativeColumn(3);    // Nombre
                                columns.RelativeColumn(3);    // Apellido
                                columns.RelativeColumn(1);    // Nota
                            });

                            // 🔹 Encabezado
                            table.Header(header =>
                            {
                                header.Cell().Element(HeaderCellStyle).Text("#");
                                header.Cell().Element(HeaderCellStyle).Text("Legajo");
                                header.Cell().Element(HeaderCellStyle).Text("Nombre");
                                header.Cell().Element(HeaderCellStyle).Text("Apellido");
                                header.Cell().Element(HeaderCellStyle).Text("Nota");
                            });

                            // 🔹 Filas
                            int index = 1;
                            foreach (var i in alumnos)
                            {
                                bool isEven = index % 2 == 0; // Para alternar colores

                                table.Cell().Element(container => DataCellStyle(container, isEven)).Text((index++).ToString());
                                table.Cell().Element(container => DataCellStyle(container, isEven)).Text(i.LegajoAlumno.ToString());
                                table.Cell().Element(container => DataCellStyle(container, isEven)).Text(i.NombreAlumno ?? "-");
                                table.Cell().Element(container => DataCellStyle(container, isEven)).Text(i.ApellidoAlumno ?? "-");
                                table.Cell().Element(container => DataCellStyle(container, isEven)).Text(i.Nota == 0 ? "" : i.Nota.ToString());
                            }
                        });                        page.Footer().AlignRight().Text($"Reporte generado el: {DateTime.Now:g}");
                    });

                });
                doc.GeneratePdf(stream);
                return stream.ToArray();
            }
            catch (Exception e)
            {
                throw new Exception($"Ocurrió un error generando el report:{e.Message}");
            }
        }
        public IEnumerable<AlumnoInscripcion> GetAlumnosByIdCurso( int idCurso)
        {
            var usRepo = new UsuarioRepository();
            try
            {
                return usRepo.GetAlumnosByIdCurso(idCurso).Select(aluInsc => new AlumnoInscripcion(
                    aluInsc.IdALumno,
                    aluInsc.LegajoAlumno,
                    aluInsc.NombreAlumno,
                    aluInsc.ApellidoAlumno,
                    aluInsc.IdInscripcion,
                    aluInsc.Nota
                )).ToList();
            }
            catch (Exception ex)
                {
                    throw new Exception($"Hubo un error: {ex.Message}");
                }
            }
                

        public bool Update(UsuarioDTO usuario)
        {
            var usRepo = new UsuarioRepository();
            try
            {
                Usuario us = new Usuario(usuario.Id, usuario.NombreUsuario, usuario.Clave, usuario.Habilitado,
                    usuario.CambiaClave, usuario.IdPersona);
                return usRepo.Update(us);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public UsuarioDTO Login(string username, string password)
        {
            var usRepo = new UsuarioRepository();
            try
            {
                
                Usuario? user = usRepo.Login(username, password);
                UsuarioDTO usuarioDevuelto = new UsuarioDTO(
                    user.Id,
                    user.NombreUsuario,
                    user.Clave,
                    user.Habilitado,
                    user.IdPersona,
                    user.CambiaClave
                );
                return usuarioDevuelto;

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
