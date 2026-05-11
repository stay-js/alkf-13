using Microsoft.EntityFrameworkCore;

namespace TanacsadoLib
{
    public partial class TanacsadoContext : DbContext
    {
        public TanacsadoContext() { }

        public TanacsadoContext(DbContextOptions<TanacsadoContext> options)
            : base(options) { }

        public virtual DbSet<Szakterulet> Szakteruletek { get; set; }
        public virtual DbSet<Talalkozo> Talalkozok { get; set; }
        public virtual DbSet<Tanacsado> Tanacsadok { get; set; }
        public virtual DbSet<Ugyfel> Ugyfelek { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseMySql("server=127.0.0.1;database=tanacsado;uid=root;pwd=root_p_ssW0rd", Microsoft.EntityFrameworkCore.ServerVersion.Parse("9.5.0-mysql"));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Szakterulet>(entity =>
            {
                entity.HasKey(e => e.SzakteruletId).HasName("PRIMARY");

                entity
                    .ToTable("szakterulet")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.Property(e => e.SzakteruletId).HasColumnName("szakterulet_id");
                entity.Property(e => e.Megnevezes)
                    .HasMaxLength(15)
                    .HasColumnName("megnevezes")
                    .UseCollation("utf8mb3_general_ci");
            });

            modelBuilder.Entity<Talalkozo>(entity =>
            {
                entity.HasKey(e => e.TalalkozoId).HasName("PRIMARY");

                entity
                    .ToTable("talalkozo")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.HasIndex(e => e.TanacsadoId, "talalkozo_tanacsado_id_fk");

                entity.HasIndex(e => e.UgyfelId, "talalkozo_ugyfel_id_fk");

                entity.Property(e => e.TalalkozoId).HasColumnName("talalkozo_id");
                entity.Property(e => e.Datum).HasColumnName("datum");
                entity.Property(e => e.Idopont)
                    .HasColumnType("time")
                    .HasColumnName("idopont");
                entity.Property(e => e.Idotartam).HasColumnName("idotartam");
                entity.Property(e => e.TanacsadoId).HasColumnName("tanacsado_id");
                entity.Property(e => e.UgyfelId).HasColumnName("ugyfel_id");

                entity.HasOne(d => d.Tanacsado).WithMany(p => p.Talalkozok)
                    .HasForeignKey(d => d.TanacsadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("talalkozo_tanacsado_id_fk");

                entity.HasOne(d => d.Ugyfel).WithMany(p => p.Talalkozok)
                    .HasForeignKey(d => d.UgyfelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("talalkozo_ugyfel_id_fk");
            });

            modelBuilder.Entity<Tanacsado>(entity =>
            {
                entity.HasKey(e => e.TanacsadoId).HasName("PRIMARY");

                entity
                    .ToTable("tanacsado")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.HasIndex(e => e.SzakteruletId, "tanacsado_szakterulet_id_fk");

                entity.Property(e => e.TanacsadoId).HasColumnName("tanacsado_id");
                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .HasColumnName("email")
                    .UseCollation("utf8mb3_general_ci");
                entity.Property(e => e.Nev)
                    .HasMaxLength(25)
                    .HasColumnName("nev")
                    .UseCollation("utf8mb3_general_ci");
                entity.Property(e => e.Oradij).HasColumnName("oradij");
                entity.Property(e => e.SzakteruletId).HasColumnName("szakterulet_id");
                entity.Property(e => e.Telefon)
                    .HasMaxLength(21)
                    .HasColumnName("telefon")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasOne(d => d.Szakterulet).WithMany(p => p.Tanacsadok)
                    .HasForeignKey(d => d.SzakteruletId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tanacsado_szakterulet_id_fk");
            });

            modelBuilder.Entity<Ugyfel>(entity =>
            {
                entity.HasKey(e => e.UgyfelId).HasName("PRIMARY");

                entity
                    .ToTable("ugyfel")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.Property(e => e.UgyfelId).HasColumnName("ugyfel_id");
                entity.Property(e => e.Email)
                    .HasMaxLength(49)
                    .HasColumnName("email")
                    .UseCollation("utf8mb3_general_ci");
                entity.Property(e => e.Nev)
                    .HasMaxLength(28)
                    .HasColumnName("nev")
                    .UseCollation("utf8mb3_general_ci");
                entity.Property(e => e.Telefon)
                    .HasMaxLength(21)
                    .HasColumnName("telefon")
                    .UseCollation("utf8mb3_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
