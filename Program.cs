using Microsoft.EntityFrameworkCore;
using JaywashoeApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Mendaftarkan koneksi database SQL Server ke dalam sistem (Ini yang terlewat)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 1. Daftarkan layanan Controller ke dalam sistem
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// 2. Aktifkan rute yang mengarah ke Controller
app.MapControllers();

app.Run();