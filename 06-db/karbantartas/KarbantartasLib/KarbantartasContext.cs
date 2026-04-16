using Microsoft.EntityFrameworkCore;

namespace KarbantartasLib
{
    public partial class KarbantartasContext : DbContext
    {
        public KarbantartasContext() { }

        public KarbantartasContext(DbContextOptions<KarbantartasContext> options)
            : base(options)
        { }

        public virtual DbSet<Karbantartas> Karbantartasok { get; set; }
        public virtual DbSet<Megrendelo> Megrendelok { get; set; }
        public virtual DbSet<Szakterulet> Szakteruletek { get; set; }
        public virtual DbSet<Szerelo> Szerelok { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseMySql("server=127.0.0.1;database=karbantartas;uid=root;pwd=root_p_ssW0rd", Microsoft.EntityFrameworkCore.ServerVersion.Parse("9.5.0-mysql"));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Karbantartas>(entity =>
            {
                entity.HasKey(e => e.KarbantartasId).HasName("PRIMARY");

                entity
                    .ToTable("karbantartasok")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.HasIndex(e => e.MegrendeloId, "karbantartasok_megrendelo_id_fk");

                entity.HasIndex(e => e.SzereloId, "karbantartasok_szerelo_id_fk");

                entity.Property(e => e.KarbantartasId).HasColumnName("karbantartas_id");
                entity.Property(e => e.Datum).HasColumnName("datum");
                entity.Property(e => e.Javido).HasColumnName("javido");
                entity.Property(e => e.MegrendeloId).HasColumnName("megrendelo_id");
                entity.Property(e => e.SzereloId).HasColumnName("szerelo_id");

                entity.HasOne(d => d.Megrendelo).WithMany(p => p.Karbantartasok)
                    .HasForeignKey(d => d.MegrendeloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("karbantartasok_megrendelo_id_fk");

                entity.HasOne(d => d.Szerelo).WithMany(p => p.Karbantartasok)
                    .HasForeignKey(d => d.SzereloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("karbantartasok_szerelo_id_fk");
            });

            modelBuilder.Entity<Megrendelo>(entity =>
            {
                entity.HasKey(e => e.MegrendeloId).HasName("PRIMARY");

                entity
                    .ToTable("megrendelok")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.Property(e => e.MegrendeloId).HasColumnName("megrendelo_id");
                entity.Property(e => e.Cim)
                    .HasMaxLength(42)
                    .HasColumnName("cim")
                    .UseCollation("utf8mb3_general_ci");
                entity.Property(e => e.Kedvezmeny).HasColumnName("kedvezmeny");
                entity.Property(e => e.Nev)
                    .HasMaxLength(27)
                    .HasColumnName("nev")
                    .UseCollation("utf8mb3_general_ci");
                entity.Property(e => e.Telefon)
                    .HasMaxLength(21)
                    .HasColumnName("telefon")
                    .UseCollation("utf8mb3_general_ci");
            });

            modelBuilder.Entity<Szakterulet>(entity =>
            {
                entity.HasKey(e => e.SzakteruletId).HasName("PRIMARY");

                entity
                    .ToTable("szakteruletek")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.Property(e => e.SzakteruletId).HasColumnName("szakterulet_id");
                entity.Property(e => e.Megnevezes)
                    .HasMaxLength(21)
                    .HasColumnName("megnevezes")
                    .UseCollation("utf8mb3_general_ci");
            });

            modelBuilder.Entity<Szerelo>(entity =>
            {
                entity.HasKey(e => e.SzereloId).HasName("PRIMARY");

                entity
                    .ToTable("szerelok")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.HasIndex(e => e.SzakteruletId, "szerelok_szakterulet_id_fk");

                entity.Property(e => e.SzereloId).HasColumnName("szerelo_id");
                entity.Property(e => e.Cim)
                    .HasMaxLength(51)
                    .HasColumnName("cim")
                    .UseCollation("utf8mb3_general_ci");
                entity.Property(e => e.Nev)
                    .HasMaxLength(22)
                    .HasColumnName("nev")
                    .UseCollation("utf8mb3_general_ci");
                entity.Property(e => e.Oradij).HasColumnName("oradij");
                entity.Property(e => e.SzakteruletId).HasColumnName("szakterulet_id");
                entity.Property(e => e.Telefon)
                    .HasMaxLength(21)
                    .HasColumnName("telefon")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasOne(d => d.Szakterulet).WithMany(p => p.Szerelok)
                    .HasForeignKey(d => d.SzakteruletId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("szerelok_szakterulet_id_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
