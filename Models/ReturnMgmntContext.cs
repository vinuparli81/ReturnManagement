using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RtMgmt.Models
{
    public partial class ReturnMgmntContext : DbContext
    {
        public ReturnMgmntContext()
        {
        }

        public ReturnMgmntContext(DbContextOptions<ReturnMgmntContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Processheader> Processheaders { get; set; }
        public virtual DbSet<RtnPriceMaster> RtnPriceMasters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=10.9.246.162,4022;Database=ReturnMgmnt;User ID=sa;pwd=CreateFile();");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Processheader>(entity =>
            {
                entity.HasKey(e => e.Tranid);

                entity.ToTable("PROCESSHEADER");

                entity.Property(e => e.Tranid).HasColumnName("TRANID");

                entity.Property(e => e.Componentname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPONENTNAME");

                entity.Property(e => e.Componenttype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPONENTTYPE");

                entity.Property(e => e.Contactnumber)
                    .HasColumnType("numeric(12, 0)")
                    .HasColumnName("CONTACTNUMBER");

                entity.Property(e => e.Creditcardnumber)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREDITCARDNUMBER");

                entity.Property(e => e.Expecteddeliverydate)
                    .HasColumnType("datetime")
                    .HasColumnName("EXPECTEDDELIVERYDATE");

                entity.Property(e => e.Ispriority).HasColumnName("ISPRIORITY");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.Trandate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRANDATE");

                entity.Property(e => e.Username)
                    .HasMaxLength(150)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<RtnPriceMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RTN_PRICE_MASTER");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("COST");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Items)
                    .HasMaxLength(50)
                    .HasColumnName("ITEMS");

                entity.Property(e => e.Servicetype)
                    .HasMaxLength(10)
                    .HasColumnName("SERVICETYPE")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
