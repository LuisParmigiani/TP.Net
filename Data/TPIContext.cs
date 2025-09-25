using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Domain.Model;

namespace Data;


public class TPIContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Plan> Planes { get; set; }
    public DbSet<Especialidad> Especialidades { get; set; }
    public DbSet<Comision> Comisiones { get; set; }
    public DbSet<Materia> Materias { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Inscripcion> Inscripciones { get; set; }
    public DbSet<Dictado> Dictados { get; set; }
    public DbSet<Persona> Personas { get; set; }

    internal TPIContext()
    {
        //La borramos para garantizar que en desarrollo siempre tenga los últimos cambios
        //que le hacemos al modelo con EF
        //this.Database.EnsureDeleted();
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
        modelBuilder.Entity<Especialidad>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion).HasMaxLength(50).IsRequired();
        });
        modelBuilder.Entity<Especialidad>().HasData(
            new Especialidad(1, "Programación"),
            new Especialidad(2, "Especialidad de Mecánica"),
            new Especialidad(3, "Especialidad de Electrica"),
            new Especialidad(4, "Especialidad de Química")
            );
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
        modelBuilder.Entity<Plan>().HasData(
            new Plan("Ing en sistemas 2023",1,1),
            new Plan("Ing Mecanica 2024",2,2),
            new Plan("Ing Electrica 2023",3,3),
            new Plan("Ing Química 2023",4,4)
            );
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
        modelBuilder.Entity<Dictado>(entity =>
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
        modelBuilder.Entity<Inscripcion>(entity =>
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