using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace figurasmvc
{
    public partial class alamContext : DbContext
    {
        public alamContext()
        {
        }

        public alamContext(DbContextOptions<alamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Prueba> Prueba { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql(@"Host=Localhost;Database=alam;Username=postgres;Password=1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Prueba>(entity =>
            {
                entity.HasKey(e => e.Ide)
                    .HasName("prueba_pkey");

                entity.ToTable("prueba");

                entity.Property(e => e.Ide)
                    .HasColumnName("ide")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.Idrol)
                    .HasName("roles_pkey");

                entity.ToTable("roles");

                entity.Property(e => e.Idrol)
                    .HasColumnName("idrol")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Rolname).HasColumnName("rolname");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("usuarios");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Lastname).HasColumnName("lastname");

                entity.Property(e => e.Name).HasColumnName("name");
            });
        }
    }
}
