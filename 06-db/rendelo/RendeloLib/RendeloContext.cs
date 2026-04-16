using Microsoft.EntityFrameworkCore;

namespace RendeloLib
{

    public partial class RendeloContext : DbContext
    {
        public RendeloContext() { }

        public RendeloContext(DbContextOptions<RendeloContext> options)
            : base(options) { }

        public virtual DbSet<Kezeles> Kezelesek { get; set; }
        public virtual DbSet<Orvos> Orvosok { get; set; }
        public virtual DbSet<Paciens> Paciensek { get; set; }
        public virtual DbSet<Szakterulet> Szakteruletek { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseMySql("database=rendelo;server=127.0.0.1;uid=root;pwd=root_p_ssW0rd", Microsoft.EntityFrameworkCore.ServerVersion.Parse("9.5.0-mysql"));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Kezeles>(entity =>
            {
                entity.HasKey(e => e.KezelesId).HasName("PRIMARY");

                entity
                    .ToTable("kezeles")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.HasIndex(e => e.OrvosId, "kezeles_orvos_id_fk");

                entity.HasIndex(e => e.PaciensId, "kezeles_paciens_id_fk");

                entity.Property(e => e.KezelesId).HasColumnName("kezeles_id");
                entity.Property(e => e.Datum).HasColumnName("datum");
                entity.Property(e => e.Idotartam).HasColumnName("idotartam");
                entity.Property(e => e.Kezdesido).HasColumnName("kezdesido");
                entity.Property(e => e.Megjegyzes)
                    .HasMaxLength(31)
                    .HasColumnName("megjegyzes")
                    .UseCollation("utf8mb3_general_ci");
                entity.Property(e => e.OrvosId).HasColumnName("orvos_id");
                entity.Property(e => e.PaciensId).HasColumnName("paciens_id");

                entity.HasOne(d => d.Orvos).WithMany(p => p.Kezelesek)
                    .HasForeignKey(d => d.OrvosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("kezeles_orvos_id_fk");

                entity.HasOne(d => d.Paciens).WithMany(p => p.Kezelesek)
                    .HasForeignKey(d => d.PaciensId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("kezeles_paciens_id_fk");
            });

            modelBuilder.Entity<Orvos>(entity =>
            {
                entity.HasKey(e => e.OrvosId).HasName("PRIMARY");

                entity
                    .ToTable("orvos")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.HasIndex(e => e.SzakteruletId, "orvos_szakterulet_id_fk");

                entity.Property(e => e.OrvosId).HasColumnName("orvos_id");
                entity.Property(e => e.Nev)
                    .HasMaxLength(31)
                    .HasColumnName("nev")
                    .UseCollation("utf8mb3_general_ci");
                entity.Property(e => e.Oradij).HasColumnName("oradij");
                entity.Property(e => e.SzakteruletId).HasColumnName("szakterulet_id");
                entity.Property(e => e.Telefon)
                    .HasMaxLength(21)
                    .HasColumnName("telefon")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasOne(d => d.Szakterulet).WithMany(p => p.Orvosok)
                    .HasForeignKey(d => d.SzakteruletId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orvos_szakterulet_id_fk");
            });

            modelBuilder.Entity<Paciens>(entity =>
            {
                entity.HasKey(e => e.PaciensId).HasName("PRIMARY");

                entity
                    .ToTable("paciens")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.Property(e => e.PaciensId).HasColumnName("paciens_id");
                entity.Property(e => e.Nev)
                    .HasMaxLength(28)
                    .HasColumnName("nev")
                    .UseCollation("utf8mb3_general_ci");
                entity.Property(e => e.Szuletett).HasColumnName("szuletett");
                entity.Property(e => e.Telefon)
                    .HasMaxLength(21)
                    .HasColumnName("telefon")
                    .UseCollation("utf8mb3_general_ci");
            });

            modelBuilder.Entity<Szakterulet>(entity =>
            {
                entity.HasKey(e => e.SzakteruletId).HasName("PRIMARY");

                entity
                    .ToTable("szakterulet")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.Property(e => e.SzakteruletId).HasColumnName("szakterulet_id");
                entity.Property(e => e.Nev)
                    .HasMaxLength(21)
                    .HasColumnName("nev")
                    .UseCollation("utf8mb3_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
