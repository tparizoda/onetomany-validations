using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<User> Users {get;set;}
    public DbSet<Driverlicense> Driverlicenses {get;set;}
    public DbSet<Car> Cars {get;set;}

    public AppDbContext(DbContextOptions<AppDbContext> options)
        :base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasKey(x => x.Id);

        modelBuilder.Entity<User>()
            .Property(x => x.Username)
            .HasMaxLength(20)
            .IsRequired();

        modelBuilder.Entity<User>()
            .HasIndex(x => x.Username)
            .IsUnique();

        modelBuilder.Entity<User>()
            .Property(x => x.Email)
            .IsRequired();

        modelBuilder.Entity<User>()
            .HasIndex(x => x.Email)
            .IsUnique();

        modelBuilder.Entity<User>()
            .HasOne(d => d.DriverLicense)
            .WithOne(u => u.Holder)
            .HasForeignKey<Driverlicense>(u => u.Id)
            .HasPrincipalKey<User>(u => u.Id);

        modelBuilder.Entity<User>()
            .HasMany(u => u.Cars)
            .WithOne(c => c.Owner)
            .HasPrincipalKey(c => c.Id)
            .IsRequired();

        modelBuilder.Entity<Car>()
            .HasKey(e => e.Id);

        modelBuilder.Entity<Car>()
            .Property(e => e.Color)
            .HasMaxLength(20);

        modelBuilder.Entity<Car>()
            .Property(e => e.Brand)
            .HasMaxLength(20)
            .IsRequired();

        modelBuilder.Entity<Car>()
            .Property(e => e.Model)
            .HasMaxLength(20)
            .IsRequired();

        



        








        base.OnModelCreating(modelBuilder);
    }
}