using Microsoft.EntityFrameworkCore;
using JaywashoeApi.Models;

namespace JaywashoeApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // 'Services' akan otomatis menjadi nama tabel di dalam SQL Server
    public DbSet<Service> Services { get; set; }

    public DbSet<Order> Orders { get; set; }
}