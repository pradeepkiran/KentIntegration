using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Database.Models;

#nullable disable

namespace Context
{
    public partial class attendanceContext : DbContext
    {
        public attendanceContext()
        {
        }

        public attendanceContext(DbContextOptions<attendanceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attendance> Attendances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\t751474\\source\\repos\\KentIntegration\\Database\\attendance.mdf;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__Attendan__FBDF78E95A622E16");

                entity.ToTable("Attendance");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("companyId");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("departmentName");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("deviceId");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("deviceName");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("empId");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("employeeName");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("imageUrl");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("locationName");

                entity.Property(e => e.Mode)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("mode");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
