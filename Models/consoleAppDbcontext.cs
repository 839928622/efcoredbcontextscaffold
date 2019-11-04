using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleApp.Models
{
    public partial class consoleAppDbcontext : DbContext
    {
        public consoleAppDbcontext()
        {
        }

        public consoleAppDbcontext(DbContextOptions<consoleAppDbcontext> options)
            : base(options)
        {
        }

        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<View> View { get; set; }
        public virtual DbSet<ViewStudent> ViewStudent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=efcore3pointOScriptsTest;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Age)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Height).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<View>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View");

                entity.Property(e => e.Age)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Height).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<ViewStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewStudent");

                entity.Property(e => e.Age)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Height).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
