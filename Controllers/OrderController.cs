using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JaywashoeApi.Models;
using JaywashoeApi.Data;

namespace JaywashoeApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public OrderController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetOrders()
    {
        var orders = await _context.Orders.ToListAsync();
        return Ok(orders);
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder(Order order)
    {
        _context.Orders.Add(order);
        await _context.SaveChangesAsync();
        
        return Ok(order);
    }

    [HttpPut("{id}/pay")]
    public async Task<IActionResult> PayOrder(int id)
    {
        // 1. Cari pesanan berdasarkan ID
        var order = await _context.Orders.FindAsync(id);
        
        // 2. Jika ID tidak ada, kembalikan error 404
        if (order == null)
        {
            return NotFound(new { message = "Pesanan tidak ditemukan" });
        }

        // 3. Ubah status dan simpan ke database
        order.PaymentStatus = "Paid";
        await _context.SaveChangesAsync();

        return Ok(new { message = "Pembayaran berhasil", data = order });
    }
}