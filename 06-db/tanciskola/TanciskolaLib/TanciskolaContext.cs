using Microsoft.EntityFrameworkCore;

namespace TanciskolaLib
{
    public partial class TanciskolaContext : DbContext
    {
        public TanciskolaContext() { }

        public TanciskolaContext(DbContextOptions<TanciskolaContext> options)
            : base(options) { }

        public virtual DbSet<Orarend> Orarendek { get; set; }
        public virtual DbSet<Szint> Szintek { get; set; }
        public virtual DbSet<Tanar> Tanarok { get; set; }
        public virtual DbSet<Tanc> Tancok { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseMySql("database=tanciskola;server=127.0.0.1;uid=root;pwd=root_p_ssW0rd", Microsoft.EntityFrameworkCore.ServerVersion.Parse("9.5.0-mysql"));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Orarend>(entity =>
            {
                entity.HasKey(e => e.OrarendId).HasName("PRIMARY");

                entity
                    .ToTable("orarend")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.HasIndex(e => e.Szint, "orarend_szint_id_fk");

                entity.HasIndex(e => e.Tanar1, "orarend_tanar1_id_fk");

                entity.HasIndex(e => e.Tanar2, "orarend_tanar2_id_fk");

                entity.HasIndex(e => e.Tanc, "orarend_tanc_id_fk");

                entity.Property(e => e.OrarendId).HasColumnName("orarend_id");
                entity.Property(e => e.Hossz).HasColumnName("hossz");
                entity.Property(e => e.KezdoIdopont)
                    .HasMaxLength(7)
                    .HasColumnName("kezdo_idopont")
                    .UseCollation("utf8mb3_general_ci");
                entity.Property(e => e.Letszam).HasColumnName("letszam");
                entity.Property(e => e.Nap)
                    .HasMaxLength(13)
                    .HasColumnName("nap")
                    .UseCollation("utf8mb3_general_ci");
                entity.Property(e => e.Szint).HasColumnName("szint");
                entity.Property(e => e.Tanar1).HasColumnName("tanar1");
                entity.Property(e => e.Tanar2).HasColumnName("tanar2");
                entity.Property(e => e.Tanc).HasColumnName("tanc");
                entity.Property(e => e.Terem).HasColumnName("terem");

                entity.HasOne(d => d.SzintNavigation).WithMany(p => p.Orarendek)
                    .HasForeignKey(d => d.Szint)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orarend_szint_id_fk");

                entity.HasOne(d => d.Tanar1Navigation).WithMany(p => p.OrarendTanar1Navigations)
                    .HasForeignKey(d => d.Tanar1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orarend_tanar1_id_fk");

                entity.HasOne(d => d.Tanar2Navigation).WithMany(p => p.OrarendTanar2Navigations)
                    .HasForeignKey(d => d.Tanar2)
                    .HasConstraintName("orarend_tanar2_id_fk");

                entity.HasOne(d => d.TancNavigation).WithMany(p => p.Orarendek)
                    .HasForeignKey(d => d.Tanc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orarend_tanc_id_fk");
            });

            modelBuilder.Entity<Szint>(entity =>
            {
                entity.HasKey(e => e.SzintId).HasName("PRIMARY");

                entity
                    .ToTable("szint")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.Property(e => e.SzintId).HasColumnName("szint_id");
                entity.Property(e => e.Ar).HasColumnName("ar");
                entity.Property(e => e.Kategoria)
                    .HasMaxLength(15)
                    .HasColumnName("kategoria")
                    .UseCollation("utf8mb3_general_ci");
            });

            modelBuilder.Entity<Tanar>(entity =>
            {
                entity.HasKey(e => e.TanarId).HasName("PRIMARY");

                entity
                    .ToTable("tanar")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.Property(e => e.TanarId).HasColumnName("tanar_id");
                entity.Property(e => e.Email)
                    .HasMaxLength(37)
                    .HasColumnName("email")
                    .UseCollation("utf8mb3_general_ci");
                entity.Property(e => e.Nev)
                    .HasMaxLength(25)
                    .HasColumnName("nev")
                    .UseCollation("utf8mb3_general_ci");
            });

            modelBuilder.Entity<Tanc>(entity =>
            {
                entity.HasKey(e => e.TancId).HasName("PRIMARY");

                entity
                    .ToTable("tanc")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_hungarian_ci");

                entity.Property(e => e.TancId).HasColumnName("tanc_id");
                entity.Property(e => e.TancTipus)
                    .HasMaxLength(24)
                    .HasColumnName("tanc_tipus")
                    .UseCollation("utf8mb3_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
