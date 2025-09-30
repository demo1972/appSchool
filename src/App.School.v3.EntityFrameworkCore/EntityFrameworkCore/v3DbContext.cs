using App.School.v3.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Metadata;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.BlobStoring.Database.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace App.School.v3.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class v3DbContext :
    AbpDbContext<v3DbContext>,
    ITenantManagementDbContext,
    IIdentityDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */


    #region Entities from the modules

    /* Notice: We only implemented IIdentityProDbContext and ISaasDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityProDbContext and ISaasDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    // Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }
    public DbSet<IdentitySession> Sessions { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion


    #region Entities from AdminSchool
    public DbSet<DocumentStudent> DocumentsStuddents { get; set; }
    public DbSet<EducationLevel> EducationLevels { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<GroupSchool> GroupSchools { get; set; }
    public DbSet<PaymentConcept> PaymentConcepts { get; set; }
    public DbSet<SchoolYear> SchoolYears { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<StudentNote> StudentNotes { get; set; }
    public DbSet<StudentPayment> StudentPayments { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Tutor> Tutors { get; set; }


    public DbSet<Country> Countries => Set<Country>();

    public DbSet<City> Cities => Set<City>();
    public DbSet<SchoolData> SchoolsDatas => Set<SchoolData>();
    #endregion

    public v3DbContext(DbContextOptions<v3DbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureFeatureManagement();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureTenantManagement();
        builder.ConfigureBlobStoring();

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(v3Consts.DbTablePrefix + "YourEntities", v3Consts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});

        // ========== EducationLevel -> Grades ==========
        builder.Entity<EducationLevel>()
            .HasMany(e => e.Grades)
            .WithOne(g => g.EducationLevel)
            .HasForeignKey(g => g.EducationLevelId)
            .OnDelete(DeleteBehavior.Restrict);

        // ========== Grade -> Groups ==========
        builder.Entity<Grade>()
            .HasMany(g => g.Groups)
            .WithOne(gr => gr.Grade)
            .HasForeignKey(gr => gr.GradeId)
            .OnDelete(DeleteBehavior.Restrict);

        // ========== Group -> Students ==========
        builder.Entity<GroupSchool>()
            .HasMany(g => g.Students)
            .WithOne(s => s.Group)
            .HasForeignKey(s => s.GroupId)
            .OnDelete(DeleteBehavior.Restrict);

        // ========== Student -> Tutors (Many-to-Many) ==========
        builder.Entity<Student>()
            .HasMany(s => s.Tutors)
            .WithMany(t => t.Students)
            .UsingEntity(j =>
                j.ToTable("StudentTutors") // tabla intermedia generada por EF Core
            );

        // ========== Student -> Documents (One-to-Many) ==========
        builder.Entity<DocumentStudent>()
            .HasOne(d => d.Student)
            .WithMany(s => s.Documents)
            .HasForeignKey(d => d.StudentId)
            .OnDelete(DeleteBehavior.Restrict);

        // ========== Student -> Payments (One-to-Many) ==========
        builder.Entity<StudentPayment>()
            .HasOne(p => p.Student)
            .WithMany()
            .HasForeignKey(p => p.StudentId)
            .OnDelete(DeleteBehavior.Restrict);

        // ========== Payment -> Concept (Many-to-One) ==========
        builder.Entity<StudentPayment>()
            .HasOne(p => p.PaymentConcept)
            .WithMany()
            .HasForeignKey(p => p.PaymentConceptId)
            .OnDelete(DeleteBehavior.Restrict);

        // ========== Payment -> SchoolYear (Many-to-One) ==========
        builder.Entity<StudentPayment>()
            .HasOne(p => p.SchoolYear)
            .WithMany(y => y.StudentPayments)
            .HasForeignKey(p => p.SchoolYearId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<StudentNote>()
    .HasOne(n => n.Student)
    .WithMany(s => s.Notes)
    .HasForeignKey(n => n.StudentId)
    .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<StudentNote>()
            .HasOne(n => n.Teacher)
            .WithMany(t => t.Notes)
            .HasForeignKey(n => n.TeacherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<PaymentConcept>()
       .Property(p => p.DefaultAmount)
       .HasPrecision(18, 2);

        builder.Entity<StudentPayment>()
            .Property(p => p.AmountPaid)
            .HasPrecision(18, 2);


        builder.Entity<State>(x => {
            x.ToTable("States");
            x.HasOne(s => s.Country)
             .WithMany(c => c.States)
            .HasForeignKey(s => s.IdCountry)
            .OnDelete(DeleteBehavior.NoAction);
            x.Property(p => p.Id).ValueGeneratedOnAdd(); 

        });
        // Country → State

        // State → City
        builder.Entity<City>(x => {
            x.ToTable("Cities");
        x.HasOne(c => c.State)
            .WithMany(s => s.Cities)
            .HasForeignKey(c => c.IdState)
            .OnDelete(DeleteBehavior.NoAction);
            x.Property(p=>p.Id).ValueGeneratedOnAdd();

        });
            

        // City → School
        builder.Entity<SchoolData>()
            .HasOne(s => s.City)
            .WithMany(c => c.Schools)
            .HasForeignKey(s => s.IdCity)
            .OnDelete(DeleteBehavior.NoAction);


        builder.Entity<SchoolData>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(150);
        });

    }
}
