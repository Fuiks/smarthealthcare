using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Entity.Entitiy;

public partial class SmarthealthcareContext : DbContext
{
    public SmarthealthcareContext()
    {
    }

    public SmarthealthcareContext(DbContextOptions<SmarthealthcareContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Data> Datas { get; set; }

    public virtual DbSet<Drug> Drugs { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<FastRegister> FastRegisters { get; set; }

    public virtual DbSet<LogManagement> LogManagements { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrdersDetail> OrdersDetails { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<PatientRegister> PatientRegisters { get; set; }

    public virtual DbSet<Perm> Perms { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<Purchase> Purchases { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolePerm> RolePerms { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<Weekly> Weeklies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=127.0.0.1;port=3306;uid=root;pwd=zkx002311..;database=smarthealthcare", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.33-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb3_general_ci")
            .HasCharSet("utf8mb3");

        modelBuilder.Entity<Data>(entity =>
        {
            entity.HasKey(e => e.Did).HasName("PRIMARY");

            entity.ToTable("datas");

            entity.Property(e => e.Did).HasColumnName("did");
            entity.Property(e => e.Dmsg)
                .HasMaxLength(255)
                .HasColumnName("dmsg");
            entity.Property(e => e.Dname)
                .HasMaxLength(255)
                .HasColumnName("dname");
        });

        modelBuilder.Entity<Drug>(entity =>
        {
            entity.HasKey(e => e.Did).HasName("PRIMARY");

            entity.ToTable("drugs");

            entity.Property(e => e.Did).HasColumnName("did");
            entity.Property(e => e.Ddesc)
                .HasMaxLength(255)
                .HasColumnName("ddesc");
            entity.Property(e => e.Dfactory)
                .HasMaxLength(30)
                .HasColumnName("dfactory");
            entity.Property(e => e.Dname)
                .HasMaxLength(20)
                .HasColumnName("dname");
            entity.Property(e => e.Dnum).HasColumnName("dnum");
            entity.Property(e => e.Dprice).HasColumnName("dprice");
            entity.Property(e => e.Dstate).HasColumnName("dstate");
            entity.Property(e => e.Dtype)
                .HasMaxLength(20)
                .HasColumnName("dtype");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PRIMARY");

            entity.ToTable("employee");

            entity.HasIndex(e => e.Uid, "uid");

            entity.Property(e => e.Eid).HasColumnName("eid");
            entity.Property(e => e.Edata)
                .HasColumnType("datetime")
                .HasColumnName("edata");
            entity.Property(e => e.Eeducation)
                .HasMaxLength(20)
                .HasColumnName("eeducation");
            entity.Property(e => e.Enation)
                .HasMaxLength(20)
                .HasColumnName("enation");
            entity.Property(e => e.Esalary).HasColumnName("esalary");
            entity.Property(e => e.Uid).HasColumnName("uid");
        });

        modelBuilder.Entity<FastRegister>(entity =>
        {
            entity.HasKey(e => e.Frid).HasName("PRIMARY");

            entity.ToTable("fast_register");

            entity.Property(e => e.Frid).HasColumnName("frid");
            entity.Property(e => e.Frdata)
                .HasColumnType("datetime")
                .HasColumnName("frdata");
            entity.Property(e => e.Frstatus).HasColumnName("frstatus");
            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.Uid).HasColumnName("uid");
        });

        modelBuilder.Entity<LogManagement>(entity =>
        {
            entity.HasKey(e => e.Lid).HasName("PRIMARY");

            entity.ToTable("log_management");

            entity.Property(e => e.Lid).HasColumnName("lid");
            entity.Property(e => e.Lcontent)
                .HasMaxLength(255)
                .HasColumnName("lcontent");
            entity.Property(e => e.Ldata)
                .HasColumnType("datetime")
                .HasColumnName("ldata");
            entity.Property(e => e.Lerror)
                .HasMaxLength(255)
                .HasColumnName("lerror");
            entity.Property(e => e.Lmethod)
                .HasMaxLength(255)
                .HasColumnName("lmethod");
            entity.Property(e => e.Lname)
                .HasMaxLength(20)
                .HasColumnName("lname");
            entity.Property(e => e.Lstatus)
                .HasMaxLength(10)
                .HasColumnName("lstatus");
            entity.Property(e => e.Ltype)
                .HasMaxLength(20)
                .HasColumnName("ltype");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Oid).HasName("PRIMARY");

            entity.ToTable("orders");

            entity.Property(e => e.Oid)
                .HasMaxLength(36)
                .HasColumnName("oid");
            entity.Property(e => e.Odata)
                .HasColumnType("datetime")
                .HasColumnName("odata");
            entity.Property(e => e.Oprice).HasColumnName("oprice");
            entity.Property(e => e.Prid)
                .HasMaxLength(36)
                .HasColumnName("prid");
        });

        modelBuilder.Entity<OrdersDetail>(entity =>
        {
            entity.HasKey(e => e.Odid).HasName("PRIMARY");

            entity.ToTable("orders_detail");

            entity.Property(e => e.Odid).HasColumnName("odid");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Did).HasColumnName("did");
            entity.Property(e => e.Oid)
                .HasMaxLength(36)
                .HasColumnName("oid");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PRIMARY");

            entity.ToTable("patient");

            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.Idcatd)
                .HasMaxLength(18)
                .HasColumnName("idcatd");
            entity.Property(e => e.Paddr)
                .HasMaxLength(20)
                .HasColumnName("paddr");
            entity.Property(e => e.Page).HasColumnName("page");
            entity.Property(e => e.Panme)
                .HasMaxLength(20)
                .HasColumnName("panme");
            entity.Property(e => e.Psex)
                .HasMaxLength(2)
                .HasColumnName("psex");
            entity.Property(e => e.Pstate).HasColumnName("pstate");
            entity.Property(e => e.Ptel)
                .HasMaxLength(11)
                .HasColumnName("ptel");
        });

        modelBuilder.Entity<PatientRegister>(entity =>
        {
            entity.HasKey(e => e.Prid).HasName("PRIMARY");

            entity.ToTable("patient_register");

            entity.Property(e => e.Prid)
                .HasMaxLength(36)
                .HasColumnName("prid");
            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.Rdata)
                .HasColumnType("datetime")
                .HasColumnName("rdata");
            entity.Property(e => e.Rdesc)
                .HasMaxLength(255)
                .HasColumnName("rdesc");
            entity.Property(e => e.Rresult)
                .HasMaxLength(255)
                .HasColumnName("rresult");
            entity.Property(e => e.Uid).HasColumnName("uid");
        });

        modelBuilder.Entity<Perm>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PRIMARY");

            entity.ToTable("perm");

            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.Panme)
                .HasMaxLength(10)
                .HasColumnName("panme");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PRIMARY");

            entity.ToTable("post");

            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.Pdata).HasColumnName("pdata");
            entity.Property(e => e.Pename)
                .HasMaxLength(30)
                .HasColumnName("pename");
            entity.Property(e => e.Pname)
                .HasMaxLength(30)
                .HasColumnName("pname");
            entity.Property(e => e.Pstatus)
                .HasMaxLength(10)
                .HasColumnName("pstatus");
        });

        modelBuilder.Entity<Purchase>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PRIMARY");

            entity.ToTable("purchase");

            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.Pdate)
                .HasColumnType("datetime")
                .HasColumnName("pdate");
            entity.Property(e => e.Pdesc)
                .HasMaxLength(255)
                .HasColumnName("pdesc");
            entity.Property(e => e.Pfactory)
                .HasMaxLength(30)
                .HasColumnName("pfactory");
            entity.Property(e => e.Pname)
                .HasMaxLength(20)
                .HasColumnName("pname");
            entity.Property(e => e.Pnum).HasColumnName("pnum");
            entity.Property(e => e.Pnumber)
                .HasMaxLength(36)
                .HasColumnName("pnumber");
            entity.Property(e => e.Pprice).HasColumnName("pprice");
            entity.Property(e => e.Ptype)
                .HasMaxLength(20)
                .HasColumnName("ptype");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Rid).HasName("PRIMARY");

            entity.ToTable("role");

            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Rdesc)
                .HasMaxLength(100)
                .HasColumnName("rdesc");
            entity.Property(e => e.Rname)
                .HasMaxLength(20)
                .HasColumnName("rname");
        });

        modelBuilder.Entity<RolePerm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("role_perms");

            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.Rid).HasColumnName("rid");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PRIMARY");

            entity.ToTable("supplier");

            entity.Property(e => e.Sid).HasColumnName("sid");
            entity.Property(e => e.Semail)
                .HasMaxLength(30)
                .HasColumnName("semail");
            entity.Property(e => e.Sfactory)
                .HasMaxLength(30)
                .HasColumnName("sfactory");
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .HasColumnName("sname");
            entity.Property(e => e.Stel)
                .HasMaxLength(11)
                .HasColumnName("stel");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PRIMARY");

            entity.ToTable("user");

            entity.Property(e => e.Uid)
                .HasComment("主键")
                .HasColumnName("uid");
            entity.Property(e => e.Uage).HasColumnName("uage");
            entity.Property(e => e.Udesc)
                .HasMaxLength(255)
                .HasColumnName("udesc");
            entity.Property(e => e.Uimg)
                .HasMaxLength(255)
                .HasColumnName("uimg");
            entity.Property(e => e.Uname)
                .HasMaxLength(20)
                .HasColumnName("uname");
            entity.Property(e => e.Upass)
                .HasMaxLength(12)
                .HasColumnName("upass");
            entity.Property(e => e.Upost).HasColumnName("upost");
            entity.Property(e => e.Ustate).HasColumnName("ustate");
            entity.Property(e => e.Utel)
                .HasMaxLength(11)
                .HasColumnName("utel");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PRIMARY");

            entity.ToTable("user_role");

            entity.Property(e => e.Uid)
                .ValueGeneratedNever()
                .HasComment("主键")
                .HasColumnName("uid");
            entity.Property(e => e.Rid).HasColumnName("rid");
        });

        modelBuilder.Entity<Weekly>(entity =>
        {
            entity.HasKey(e => e.Wid).HasName("PRIMARY");

            entity.ToTable("weekly");

            entity.Property(e => e.Wid).HasColumnName("wid");
            entity.Property(e => e.Sopinion)
                .HasMaxLength(255)
                .HasColumnName("sopinion");
            entity.Property(e => e.Uid).HasColumnName("uid");
            entity.Property(e => e.Wdata)
                .HasColumnType("datetime")
                .HasColumnName("wdata");
            entity.Property(e => e.Werror)
                .HasMaxLength(255)
                .HasColumnName("werror");
            entity.Property(e => e.Wsum)
                .HasMaxLength(255)
                .HasColumnName("wsum");
            entity.Property(e => e.Wwork)
                .HasMaxLength(255)
                .HasColumnName("wwork");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
