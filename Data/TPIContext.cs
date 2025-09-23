using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Domain.Model;
namespace Data;

public class TPIContext : DbContext
{
    public DbSet<Modulo> Modulos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    internal TPIContext()
    {
        this.Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Modulo>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Ejecuta)
                .IsRequired()
                .HasMaxLength(50);

        });
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NombreUsuario).HasMaxLength(50).IsRequired();
            entity.Property(e => e.Clave).HasMaxLength(50).IsRequired();
            entity.Property(e => e.Habilitado).HasDefaultValue(true);
            entity.Property(e => e.CambiaClave).HasDefaultValue(false);
            //No me queda claro como es la relación entre personas y usuarios
            entity.HasOne<Persona>()
                .WithMany(p => p.Usuarios)
                .HasForeignKey(u => u.IdPersona)
                .IsRequired();
        });
        modelBuilder.Entity<ModuloUsuario>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasOne<Usuario>()
                .WithMany()
                .HasForeignKey(e => e.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .IsRequired();
            entity.HasOne<Modulo>()
                .WithMany()
                .HasForeignKey(e => e.IdModulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .IsRequired();
            entity.Property(mu => mu.Alta).HasDefaultValue(false);
            entity.Property(mu => mu.Baja).HasDefaultValue(false);
            entity.Property(mu => mu.Modificacion).HasDefaultValue(false);
            entity.Property(mu => mu.Consulta).HasDefaultValue(false);
            
        });
        modelBuilder.Entity<Especialidad>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion).HasMaxLength(50).IsRequired();
        });
        modelBuilder.Entity<Plan>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion).HasMaxLength(50).IsRequired();
            entity.HasOne<Especialidad>()
                .WithMany(e=>e.Planes)
                .HasForeignKey(p=>p.IdEspecialidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .IsRequired();
            
        });
        modelBuilder.Entity<Materia>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion).HasMaxLength(50).IsRequired();
            entity.Property(e => e.HSSemanales).IsRequired();
            entity.Property(e => e.HSTotales).IsRequired();
            entity.HasOne<Plan>()
                .WithMany(p => p.Materias)
                .HasForeignKey(m => m.IDPlan)
                .IsRequired();

        });
        modelBuilder.Entity<Comision>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion).HasMaxLength(50).IsRequired();
            entity.Property(e => e.AnioEspecialidad).IsRequired();
            entity.HasOne<Plan>()
                .WithMany(p => p.Comisiones)
                .HasForeignKey(c => c.IDPlan)
                .IsRequired();

        });
        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion).HasMaxLength(50).IsRequired();
            entity.Property(e => e.AnioCalendario).IsRequired();
            entity.HasOne<Comision>()
                .WithMany(com => com.Cursos)
                .HasForeignKey(cur => cur.IdComision)
                .IsRequired();
            entity.HasOne<Materia>()
                .WithMany(mat => mat.Cursos)
                .HasForeignKey(cur => cur.IdMateria)
                .IsRequired();
        });
        modelBuilder.Entity<DocenteCurso>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(i => i.Cargo).IsRequired();
            entity.HasOne<Curso>()
                .WithMany(cur => cur.DocentesCursos)
                .HasForeignKey(dc => dc.IDCurso)
                .IsRequired();
            entity.HasOne<Persona>()
                .WithMany(cur => cur.Dictados)
                .HasForeignKey(dc => dc.IDDocente)
                .IsRequired();
        });
        modelBuilder.Entity<Alumno_Inscripcion>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(i => i.Condicion).HasMaxLength(50).IsRequired();
            entity.Property(i => i.Nota).IsRequired();
            entity.HasOne<Curso>()
                .WithMany(cur => cur.Alumnos)
                .HasForeignKey(ins => ins.IdCurso)
                .IsRequired();
            entity.HasOne<Persona>()
                .WithMany(alu => alu.Incripciones)
                .HasForeignKey(ins => ins.IdAlumno)
                .IsRequired();
        });
        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Nombre).IsRequired().HasMaxLength(50);
            entity.Property(e => e.Apellido).IsRequired().HasMaxLength(50);
            entity.Property(e => e.Email).IsRequired().HasMaxLength(50);
            entity.Property(e => e.Telefono).IsRequired().HasMaxLength(50);
            entity.Property(e => e.FechaNacimiento);
            entity.Property(p => p.Legajo).IsRequired();
            entity.Property(p => p.Direccion).IsRequired().HasMaxLength(50);
            entity.Property(p => p.TipoPersona).IsRequired();
            entity.HasOne<Plan>()
                .WithMany(p => p.Alumnos)
                .HasForeignKey(per => per.IdPlan)
                .IsRequired();


        });


    }
}