using Microsoft.EntityFrameworkCore;

namespace TudomanyosLib
{
    public partial class TudomanyosContext : DbContext
    {
        public TudomanyosContext() { }

        public TudomanyosContext(DbContextOptions<TudomanyosContext> options)
            : base(options) { }

        public virtual DbSet<Eloado> Eloadok { get; set; }
        public virtual DbSet<Program> Programok { get; set; }
        public virtual DbSet<Szekcio> Szekciok { get; set; }
        public virtual DbSet<Tema> Temak { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseMySql("database=tudomanyos;server=127.0.0.1;uid=root;pwd=root_p_ssW0rd", Microsoft.EntityFrameworkCore.ServerVersion.Parse("9.5.0-mysql"));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Eloado>(entity =>
            {
                entity.HasKey(e => e.EloadoId).HasName("PRIMARY");

                entity
                    .ToTable("eloadok")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.Property(e => e.EloadoId).HasColumnName("eloado_id");
                entity.Property(e => e.Email)
                    .HasMaxLength(37)
                    .HasColumnName("email")
                    .UseCollation("utf8mb3_general_ci");
                entity.Property(e => e.Nev)
                    .HasMaxLength(25)
                    .HasColumnName("nev")
                    .UseCollation("utf8mb3_general_ci");
            });

            modelBuilder.Entity<Program>(entity =>
            {
                entity.HasKey(e => e.ProgramId).HasName("PRIMARY");

                entity
                    .ToTable("program")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.HasIndex(e => e.Eloadok1, "fk_program_eloadok1_id");

                entity.HasIndex(e => e.Eloadok2, "fk_program_eloadok2_id");

                entity.HasIndex(e => e.Szekcio, "fk_program_szekcio_id");

                entity.HasIndex(e => e.Tema, "fk_program_tema_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");
                entity.Property(e => e.Datum)
                    .HasMaxLength(15)
                    .HasColumnName("datum")
                    .UseCollation("utf8mb3_general_ci");
                entity.Property(e => e.Eloadok1).HasColumnName("eloadok1");
                entity.Property(e => e.Eloadok2).HasColumnName("eloadok2");
                entity.Property(e => e.Hossz).HasColumnName("hossz");
                entity.Property(e => e.KezdoIdopont)
                    .HasMaxLength(7)
                    .HasColumnName("kezdo_idopont")
                    .UseCollation("utf8mb3_general_ci");
                entity.Property(e => e.Letszam).HasColumnName("letszam");
                entity.Property(e => e.Szekcio).HasColumnName("szekcio");
                entity.Property(e => e.Tema).HasColumnName("tema");
                entity.Property(e => e.Terem).HasColumnName("terem");

                entity.HasOne(d => d.Eloadok1Navigation).WithMany(p => p.ProgramEloadok1Navigations)
                    .HasForeignKey(d => d.Eloadok1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_program_eloadok1_id");

                entity.HasOne(d => d.Eloadok2Navigation).WithMany(p => p.ProgramEloadok2Navigations)
                    .HasForeignKey(d => d.Eloadok2)
                    .HasConstraintName("fk_program_eloadok2_id");

                entity.HasOne(d => d.SzekcioNavigation).WithMany(p => p.Programok)
                    .HasForeignKey(d => d.Szekcio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_program_szekcio_id");

                entity.HasOne(d => d.TemaNavigation).WithMany(p => p.Programok)
                    .HasForeignKey(d => d.Tema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_program_tema_id");
            });

            modelBuilder.Entity<Szekcio>(entity =>
            {
                entity.HasKey(e => e.SzekcioId).HasName("PRIMARY");

                entity
                    .ToTable("szekciok")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.Property(e => e.SzekcioId).HasColumnName("szekcio_id");
                entity.Property(e => e.Ar).HasColumnName("ar");
                entity.Property(e => e.Kategoria)
                    .HasMaxLength(37)
                    .HasColumnName("kategoria")
                    .UseCollation("utf8mb3_general_ci");
            });

            modelBuilder.Entity<Tema>(entity =>
            {
                entity.HasKey(e => e.TemaId).HasName("PRIMARY");

                entity
                    .ToTable("temak")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.Property(e => e.TemaId).HasColumnName("tema_id");
                entity.Property(e => e.TemaNev)
                    .HasMaxLength(57)
                    .HasColumnName("tema_nev")
                    .UseCollation("utf8mb3_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
