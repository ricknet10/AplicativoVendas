using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Nest;

internal class AppSettingsDbContext
{
    public DbSet<Authentication> Authentication { get; set; }

    public AppSettingsDbContext():base()
    {

    }

 /*  public AppSettingsDbContext(DbContextOptions<AppSettingsDbContext> options): base(options)
    { 
    }  */

  /*  protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Authentication>().HasKey(s => s.Id);
        builder.Entity<Authentication>().ToTable("Authentication");
    } */



}