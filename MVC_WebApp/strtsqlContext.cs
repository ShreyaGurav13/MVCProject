using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MVC_WebApp.Models;

namespace MVC_WebApp
{
    public partial class strtsqlContext : DbContext
    {
        public strtsqlContext()
        {
        }

        public strtsqlContext(DbContextOptions<strtsqlContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookCopiesv> BookCopiesvs { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Director> Directors { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Employeeasp> employeeasp { get; set; } = null!;
        public virtual DbSet<Employeef1> Employeef1s { get; set; } = null!;
        public virtual DbSet<Employeeform> Employeeforms { get; set; } = null!;
        public virtual DbSet<Empmaster> Empmasters { get; set; } = null!;
        public virtual DbSet<Leave1> Leave1s { get; set; } = null!;
        public virtual DbSet<Leave11> Leave11s { get; set; } = null!;
        public virtual DbSet<Leaveemp> Leaveemps { get; set; } = null!;
        public virtual DbSet<Login> Logins { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<Salesman> Salesmen { get; set; } = null!;
        public virtual DbSet<Signup> Signups { get; set; } = null!;
        public virtual DbSet<Stud> Studs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-RL01OIR8; Database=strtsql; Trusted_Connection=True; TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookCopiesv>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("book_copiesv");

                entity.Property(e => e.Bookid).HasColumnName("bookid");

                entity.Property(e => e.NuOfCopies).HasColumnName("nu_of_copies");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PK__customer__A1B71F90E100DA8E");

                entity.ToTable("customer");

                entity.Property(e => e.CustId)
                    .ValueGeneratedNever()
                    .HasColumnName("cust_id");

                entity.Property(e => e.CustCity)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cust_city");

                entity.Property(e => e.CustGrade)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cust_grade");

                entity.Property(e => e.CustName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cust_name");

                entity.Property(e => e.FkcustId).HasColumnName("fkcust_id");

                entity.HasOne(d => d.Fkcust)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.FkcustId)
                    .HasConstraintName("FK__customer__fkcust__5BE2A6F2");
            });

            modelBuilder.Entity<Director>(entity =>
            {
                entity.HasKey(e => e.DirId)
                    .HasName("PK__director__D886CF4CF8FB87D7");

                entity.ToTable("director");

                entity.Property(e => e.DirId)
                    .ValueGeneratedNever()
                    .HasColumnName("dir_id");

                entity.Property(e => e.DirNm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dir_nm");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Empid)
                    .HasName("PK__employee__AF4CE865EE6B0B8F");

                entity.ToTable("employee");

                entity.HasIndex(e => e.Empmail, "UQ__employee__8CDCA245CCEF08A3")
                    .IsUnique();

                entity.Property(e => e.Empid)
                    .ValueGeneratedNever()
                    .HasColumnName("empid");

                entity.Property(e => e.Designation)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("designation");

                entity.Property(e => e.Empfnm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("empfnm");

                entity.Property(e => e.Emplnm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emplnm");

                entity.Property(e => e.Empmail)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("empmail");

                entity.Property(e => e.JoiningDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Joining_date");

                entity.Property(e => e.Salary)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("salary");

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<Employeeasp>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__employee__D9509F6D9DD4D1E1");

                entity.ToTable("employeeasp");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.Deduction).HasColumnName("deduction");

                entity.Property(e => e.Designation)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("designation");

                entity.Property(e => e.Gross).HasColumnName("gross");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("isactive");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Netsal).HasColumnName("netsal");
            });

            modelBuilder.Entity<Employeef1>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__employee__D9509F6D1A310BF0");

                entity.ToTable("employeef1");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.Ctc).HasColumnName("ctc");

                entity.Property(e => e.Designation)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("designation");

                entity.Property(e => e.Gross).HasColumnName("gross");

                entity.Property(e => e.Inhand).HasColumnName("inhand");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Pf).HasColumnName("pf");
            });

            modelBuilder.Entity<Employeeform>(entity =>
            {
                entity.ToTable("Employeeform");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ctc).HasColumnName("CTC");

                entity.Property(e => e.Designation)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InHand).HasColumnName("In_Hand");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pf).HasColumnName("PF");
            });

            modelBuilder.Entity<Empmaster>(entity =>
            {
                entity.HasKey(e => e.Empid)
                    .HasName("PK__empmaste__AF4CE865C8D45939");

                entity.ToTable("empmaster");

                entity.Property(e => e.Empid)
                    .ValueGeneratedNever()
                    .HasColumnName("empid");

                entity.Property(e => e.Deduction).HasColumnName("deduction");

                entity.Property(e => e.Designation)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("designation");

                entity.Property(e => e.Empnm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("empnm");

                entity.Property(e => e.Grosssal).HasColumnName("grosssal");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("isactive");

                entity.Property(e => e.Netsal).HasColumnName("netsal");
            });

            modelBuilder.Entity<Leave1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("leave1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LDate)
                    .HasColumnType("date")
                    .HasColumnName("l_date");

                entity.Property(e => e.LeaveId).HasColumnName("leave_id");

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reason");
            });

            modelBuilder.Entity<Leave11>(entity =>
            {
                entity.HasKey(e => e.LeaveId)
                    .HasName("PK__leave11__743350BCAEC7C85B");

                entity.ToTable("leave11");

                entity.Property(e => e.LeaveId)
                    .ValueGeneratedNever()
                    .HasColumnName("leave_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LDate)
                    .HasColumnType("date")
                    .HasColumnName("l_date");

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reason");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Leave11s)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK__leave11__ID__6442E2C9");
            });

            modelBuilder.Entity<Leaveemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("leaveemp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LDate)
                    .HasColumnType("date")
                    .HasColumnName("l_date");

                entity.Property(e => e.LeaveId).HasColumnName("leave_id");

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reason");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK__leaveemp__ID__662B2B3B");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__Login__F3DBC5732787EDE7");

                entity.ToTable("Login");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__patient__DD37D91AE0DB9BB6");

                entity.ToTable("patient");

                entity.HasIndex(e => e.Mobno, "UQ__patient__0CE2D3613B70D018")
                    .IsUnique();

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("pid");

                entity.Property(e => e.Address)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Dept)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dept");

                entity.Property(e => e.Drnm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("drnm");

                entity.Property(e => e.Mobno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("mobno");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Salesman>(entity =>
            {
                entity.ToTable("salesman");

                entity.Property(e => e.SalesmanId)
                    .ValueGeneratedNever()
                    .HasColumnName("salesman_id");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Commition).HasColumnName("commition");

                entity.Property(e => e.SalesmanName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("salesman_name");
            });

            modelBuilder.Entity<Signup>(entity =>
            {
                entity.ToTable("Signup");

                entity.HasIndex(e => e.Password, "UQ__Signup__6E2DBEDE76A8BBF9")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConfirmPass)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("confirm_pass");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<Stud>(entity =>
            {
                entity.ToTable("stud");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("datetime")
                    .HasColumnName("birthdate");

                entity.Property(e => e.Nm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nm");

                entity.Property(e => e.Per).HasColumnName("per");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
