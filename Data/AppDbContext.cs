using Microsoft.EntityFrameworkCore;
using OlimpoAgency.Api.Models;

namespace OlimpoAgency.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios => Set<Usuario>();

    public void Seed()
    {
        Database.EnsureCreated();
        if (Usuarios.Any()) return;

        Usuarios.AddRange(
            new Usuario
            {
                Nombre = "Admin Olimpo",
                Correo = "admin@olimpo.com",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin123"),
                Rol = "admin"
            },
            new Usuario
            {
                Nombre = "Carlos Rios",
                Correo = "carlos@olimpo.com",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("carlos123"),
                Rol = "cliente"
            }
        );
        SaveChanges();
    }
}