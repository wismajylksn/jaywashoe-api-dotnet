using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JaywashoeApi.Models;
using JaywashoeApi.Data;

namespace JaywashoeApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServiceController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    // 1. Dependency Injection: Memasukkan koneksi database ke dalam Controller
    public ServiceController(ApplicationDbContext context)
    {
        _context = context;
    }

    // 2. Async/Await: Mengambil data tanpa memblokir sistem (Standar industri)
    [HttpGet]
    public async Task<IActionResult> GetServices()
    {
        // Mengambil semua data dari tabel Services (Sama seperti Service::all() di Laravel)
        var services = await _context.Services.ToListAsync();
        
        return Ok(services);
    }

    // 3. Endpoint baru untuk menambah layanan cuci sepatu
    [HttpPost]
    public async Task<IActionResult> CreateService(Service service)
    {
        _context.Services.Add(service);
        await _context.SaveChangesAsync(); // Sama seperti $service->save() di Laravel
        
        return Ok(service);
    }
}