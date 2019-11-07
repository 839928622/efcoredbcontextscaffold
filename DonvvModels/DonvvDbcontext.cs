using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleApp.DonvvModels
{
    public partial class DonvvDbcontext : DbContext
    {
        public DonvvDbcontext()
        {
        }

        public DonvvDbcontext(DbContextOptions<DonvvDbcontext> options)
            : base(options)
        {
        }

        public virtual DbSet<SysUsers> SysUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(System.Environment.GetEnvironmentVariable("DonvvDb"));
                //原来将密码字符串 取GetBytes， 取md5 再取base64。 反向 -decodebase64 再破译md5  再转成字符串（string）
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SysUsers>(entity =>
            {
                entity.ToTable("Sys_Users");

                entity.Property(e => e.BirthDay)
                    .HasColumnType("datetime")
                    .HasComment("生日");

                entity.Property(e => e.BranchId).HasDefaultValueSql("((1))");

                entity.Property(e => e.DingId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.IsValid).HasComment("1:有效，0：无效");

                entity.Property(e => e.IsYinLi).HasComment("1：阴历生日");

                entity.Property(e => e.JoinDate)
                    .HasColumnType("date")
                    .HasComment("入职日期");

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TokenEndDate)
                    .HasColumnName("tokenEndDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
