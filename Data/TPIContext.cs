using System.IO;
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
            entity.ToTable("Usuarios");
        });

        // Seed Usuarios (vinculados a Personas)
        modelBuilder.Entity<Usuario>().HasData(
            new { Id = 1, NombreUsuario = "juan.p", Clave = "6lnGDQYrGBelhzWv6LeHtIH6mR5SLDWdMeZCPZEyb3U=", Habilitado = true, CambiaClave = false, IdPersona = 1 }, // Password: "Agus123"
            new { Id = 2, NombreUsuario = "maria.t", Clave = "6lnGDQYrGBelhzWv6LeHtIH6mR5SLDWdMeZCPZEyb3U=", Habilitado = true, CambiaClave = false, IdPersona = 2 }, // Password: "Agus123"
            new { Id = 3, NombreUsuario = "alumno.a", Clave = "6lnGDQYrGBelhzWv6LeHtIH6mR5SLDWdMeZCPZEyb3U=", Habilitado = true, CambiaClave = false, IdPersona = 3 } // Password: "Agus123"
        );

        modelBuilder.Entity<Especialidad>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion).HasMaxLength(50).IsRequired();
            entity.ToTable("Especialidades");
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
            entity.ToTable("Planes");
            
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
            entity.ToTable("Materias");

        });

        // Seed Materias
        modelBuilder.Entity<Materia>().HasData(
            new { Id = 1, Descripcion = "Programación I", HSSemanales = 4, HSTotales = 64, IDPlan = 1 },
            new { Id = 2, Descripcion = "Algoritmos", HSSemanales = 4, HSTotales = 64, IDPlan = 1 },
            new { Id = 3, Descripcion = "Máquinas y Mecanismos", HSSemanales = 4, HSTotales = 64, IDPlan = 2 },
            new { Id = 4, Descripcion = "Circuitos Eléctricos", HSSemanales = 4, HSTotales = 64, IDPlan = 3 }
        );

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
            entity.ToTable("Comisiones");

        });

        // Seed Comisiones
        modelBuilder.Entity<Comision>().HasData(
            new { Id = 1, Descripcion = "Comisión A", AnioEspecialidad = 1, IDPlan = 1 },
            new { Id = 2, Descripcion = "Comisión B", AnioEspecialidad = 1, IDPlan = 1 },
            new { Id = 3, Descripcion = "Comisión Mecánica A", AnioEspecialidad = 2, IDPlan = 2 },
            new { Id = 4, Descripcion = "Comisión Eléctrica A", AnioEspecialidad = 3, IDPlan = 3 }
        );

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
            entity.ToTable("Cursos");

        });

        // Seed Cursos
        modelBuilder.Entity<Curso>().HasData(
            new { Id = 1, Descripcion = "Curso Programación I - A", AnioCalendario = 2025, Cupo = 30, IdComision = 1, IdMateria = 1 },
            new { Id = 2, Descripcion = "Curso Algoritmos - A", AnioCalendario = 2025, Cupo = 30, IdComision = 2, IdMateria = 2 },
            new { Id = 3, Descripcion = "Curso Mecanismos - A", AnioCalendario = 2025, Cupo = 25, IdComision = 3, IdMateria = 3 },
            new { Id = 4, Descripcion = "Curso Circuitos - A", AnioCalendario = 2025, Cupo = 25, IdComision = 4, IdMateria = 4 }
        );

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
            entity.ToTable("Dictados");
        });

        // Seed Dictados (docentes asignados a cursos)
        modelBuilder.Entity<Dictado>().HasData(
            new { Id = 1, Cargo = "Titular", IDCurso = 1, IDDocente = 1 },
            new { Id = 2, Cargo = "Auxiliar", IDCurso = 2, IDDocente = 1 }
        );

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
            entity.ToTable("Inscripciones");
        });

        // Seed Inscripciones
        modelBuilder.Entity<Inscripcion>().HasData(
            new { Id = 1, IdAlumno = 1, IdCurso = 1, Nota = 8, Condicion = "Regular" },
            new { Id = 2, IdAlumno = 3, IdCurso = 2, Nota = 7, Condicion = "Regular" }
        );

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
            entity.ToTable("Personas");


        });

        // Seed Personas (alumnos y docentes)
        modelBuilder.Entity<Persona>().HasData(
            new { Id = 1, Nombre = "Juan", Apellido = "Pérez", Direccion = "Calle Falsa 123", Email = "juan.perez@example.com", Telefono = "123456789", FechaNacimiento = new DateTime(1998, 4, 10), Legajo = 2001, TipoPersona = 1, IdPlan = 1 },
            new { Id = 2, Nombre = "María", Apellido = "González", Direccion = "Av Siempre Viva 456", Email = "maria.gonzalez@example.com", Telefono = "987654321", FechaNacimiento = new DateTime(1985, 2, 20), Legajo = 3001, TipoPersona = 2, IdPlan = 1 },
            new { Id = 3, Nombre = "Ana", Apellido = "López", Direccion = "Calle 9 789", Email = "ana.lopez@example.com", Telefono = "555123456", FechaNacimiento = new DateTime(2000, 7, 15), Legajo = 2002, TipoPersona = 1, IdPlan = 1 }
        );

    }
}