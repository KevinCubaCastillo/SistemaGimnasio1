using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SistemaGimnasio.Models
{
    public partial class dn9jbgf4b4ih0Context : DbContext
    {
        public dn9jbgf4b4ih0Context()
        {
        }

        public dn9jbgf4b4ih0Context(DbContextOptions<dn9jbgf4b4ih0Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorium> Categoria { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Detallerutina> Detallerutinas { get; set; } = null!;
        public virtual DbSet<Ejercicio> Ejercicios { get; set; } = null!;
        public virtual DbSet<Equipo> Equipos { get; set; } = null!;
        public virtual DbSet<Estado> Estados { get; set; } = null!;
        public virtual DbSet<Inscripcione> Inscripciones { get; set; } = null!;
        public virtual DbSet<Publicacione> Publicaciones { get; set; } = null!;
        public virtual DbSet<Rutina> Rutinas { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=ec2-52-4-87-74.compute-1.amazonaws.com; Database=dn9jbgf4b4ih0; Username=jzzemroimkliwd; Port=5432; Password=02be3d0f31d6318ca707b3f8f02f98b8d120b994093f6da02de7d9d6cb69ec84");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(e => e.Codcategoria)
                    .HasName("categoria_pkey");

                entity.ToTable("categoria");

                entity.Property(e => e.Codcategoria).HasColumnName("codcategoria");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Nombrecategoria)
                    .HasMaxLength(50)
                    .HasColumnName("nombrecategoria");

                entity.Property(e => e.Rutaimagen)
                    .HasMaxLength(500)
                    .HasColumnName("rutaimagen");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Categoria)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("categoria_estado_fkey");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Ci)
                    .HasName("clientes_pkey");

                entity.ToTable("clientes");

                entity.HasIndex(e => e.Codcliente, "clientes_codcliente_key")
                    .IsUnique();

                entity.Property(e => e.Ci)
                    .HasMaxLength(20)
                    .HasColumnName("ci");

                entity.Property(e => e.Apellidomaterno)
                    .HasMaxLength(100)
                    .HasColumnName("apellidomaterno");

                entity.Property(e => e.Apellidopaterno)
                    .HasMaxLength(100)
                    .HasColumnName("apellidopaterno");

                entity.Property(e => e.Codcliente)
                    .HasMaxLength(10)
                    .HasColumnName("codcliente");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(100)
                    .HasColumnName("nombres");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("clientes_estado_fkey");
            });

            modelBuilder.Entity<Detallerutina>(entity =>
            {
                entity.HasKey(e => e.Coddetallerutina)
                    .HasName("detallerutinas_pkey");

                entity.ToTable("detallerutinas");

                entity.Property(e => e.Coddetallerutina).HasColumnName("coddetallerutina");

                entity.Property(e => e.Cantidadreps).HasColumnName("cantidadreps");

                entity.Property(e => e.Codejercicio).HasColumnName("codejercicio");

                entity.Property(e => e.Codrutina).HasColumnName("codrutina");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.HasOne(d => d.CodejercicioNavigation)
                    .WithMany(p => p.Detallerutinas)
                    .HasForeignKey(d => d.Codejercicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("detallerutinas_codejercicio_fkey");

                entity.HasOne(d => d.CodrutinaNavigation)
                    .WithMany(p => p.Detallerutinas)
                    .HasForeignKey(d => d.Codrutina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("detallerutinas_codrutina_fkey");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Detallerutinas)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("detallerutinas_estado_fkey");
            });

            modelBuilder.Entity<Ejercicio>(entity =>
            {
                entity.HasKey(e => e.Codejercicio)
                    .HasName("ejercicios_pkey");

                entity.ToTable("ejercicios");

                entity.Property(e => e.Codejercicio).HasColumnName("codejercicio");

                entity.Property(e => e.Codequipo).HasColumnName("codequipo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Nombreejercicio)
                    .HasMaxLength(100)
                    .HasColumnName("nombreejercicio");

                entity.Property(e => e.Rutaimagen)
                    .HasMaxLength(500)
                    .HasColumnName("rutaimagen");

                entity.Property(e => e.Rutavideo)
                    .HasMaxLength(500)
                    .HasColumnName("rutavideo");

                entity.HasOne(d => d.CodequipoNavigation)
                    .WithMany(p => p.Ejercicios)
                    .HasForeignKey(d => d.Codequipo)
                    .HasConstraintName("ejercicios_codequipo_fkey");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Ejercicios)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("ejercicios_estado_fkey");
            });

            modelBuilder.Entity<Equipo>(entity =>
            {
                entity.HasKey(e => e.Codequipo)
                    .HasName("equipos_pkey");

                entity.ToTable("equipos");

                entity.Property(e => e.Codequipo).HasColumnName("codequipo");

                entity.Property(e => e.Codcategoria).HasColumnName("codcategoria");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Nombreequipo)
                    .HasMaxLength(100)
                    .HasColumnName("nombreequipo");

                entity.Property(e => e.Rutaimagen)
                    .HasMaxLength(500)
                    .HasColumnName("rutaimagen");

                entity.HasOne(d => d.CodcategoriaNavigation)
                    .WithMany(p => p.Equipos)
                    .HasForeignKey(d => d.Codcategoria)
                    .HasConstraintName("equipos_codcategoria_fkey");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Equipos)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("equipos_estado_fkey");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.Idestado)
                    .HasName("estado_pkey");

                entity.ToTable("estado");

                entity.Property(e => e.Idestado)
                    .ValueGeneratedNever()
                    .HasColumnName("idestado");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Inscripcione>(entity =>
            {
                entity.HasKey(e => e.Codinscripcion)
                    .HasName("inscripciones_pkey");

                entity.ToTable("inscripciones");

                entity.Property(e => e.Codinscripcion).HasColumnName("codinscripcion");

                entity.Property(e => e.Cicliente)
                    .HasMaxLength(20)
                    .HasColumnName("cicliente");

                entity.Property(e => e.Ciusuario)
                    .HasMaxLength(20)
                    .HasColumnName("ciusuario");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Fechafin).HasColumnName("fechafin");

                entity.Property(e => e.Fechainicio).HasColumnName("fechainicio");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(100)
                    .HasColumnName("observaciones");

                entity.Property(e => e.Tipoinscripcion)
                    .HasMaxLength(50)
                    .HasColumnName("tipoinscripcion");

                entity.Property(e => e.Tipopago)
                    .HasMaxLength(20)
                    .HasColumnName("tipopago");

                entity.HasOne(d => d.CiclienteNavigation)
                    .WithMany(p => p.Inscripciones)
                    .HasForeignKey(d => d.Cicliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("inscripciones_cicliente_fkey");

                entity.HasOne(d => d.CiusuarioNavigation)
                    .WithMany(p => p.Inscripciones)
                    .HasForeignKey(d => d.Ciusuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("inscripciones_ciusuario_fkey");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Inscripciones)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("inscripciones_estado_fkey");
            });

            modelBuilder.Entity<Publicacione>(entity =>
            {
                entity.HasKey(e => e.Codpublicacion)
                    .HasName("publicaciones_pkey");

                entity.ToTable("publicaciones");

                entity.Property(e => e.Codpublicacion).HasColumnName("codpublicacion");

                entity.Property(e => e.Ciusuario)
                    .HasMaxLength(20)
                    .HasColumnName("ciusuario");

                entity.Property(e => e.Contenido)
                    .HasMaxLength(720)
                    .HasColumnName("contenido");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Rutaimagen)
                    .HasMaxLength(500)
                    .HasColumnName("rutaimagen");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(100)
                    .HasColumnName("titulo");

                entity.HasOne(d => d.CiusuarioNavigation)
                    .WithMany(p => p.Publicaciones)
                    .HasForeignKey(d => d.Ciusuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("publicaciones_ciusuario_fkey");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Publicaciones)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("publicaciones_estado_fkey");
            });

            modelBuilder.Entity<Rutina>(entity =>
            {
                entity.HasKey(e => e.Codrutina)
                    .HasName("rutinas_pkey");

                entity.ToTable("rutinas");

                entity.Property(e => e.Codrutina).HasColumnName("codrutina");

                entity.Property(e => e.Cicliente)
                    .HasMaxLength(20)
                    .HasColumnName("cicliente");

                entity.Property(e => e.Ciusuario)
                    .HasMaxLength(20)
                    .HasColumnName("ciusuario");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(100)
                    .HasColumnName("titulo");

                entity.HasOne(d => d.CiclienteNavigation)
                    .WithMany(p => p.Rutinas)
                    .HasForeignKey(d => d.Cicliente)
                    .HasConstraintName("rutinas_cicliente_fkey");

                entity.HasOne(d => d.CiusuarioNavigation)
                    .WithMany(p => p.Rutinas)
                    .HasForeignKey(d => d.Ciusuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rutinas_ciusuario_fkey");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Rutinas)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("rutinas_estado_fkey");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Ci)
                    .HasName("usuarios_pkey");

                entity.ToTable("usuarios");

                entity.Property(e => e.Ci)
                    .HasMaxLength(20)
                    .HasColumnName("ci");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(100)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Contrasenia)
                    .HasMaxLength(100)
                    .HasColumnName("contrasenia");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(100)
                    .HasColumnName("nombres");

                entity.Property(e => e.Nombreusuario)
                    .HasMaxLength(100)
                    .HasColumnName("nombreusuario");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .HasColumnName("tipo");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("usuarios_estado_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
