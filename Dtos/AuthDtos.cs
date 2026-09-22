namespace OlimpoAgency.Api.Dtos;

public class LoginRequest
{
    public string Correo { get; set; } = "";
    public string Password { get; set; } = "";
}

public class UsuarioResponse
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public string Correo { get; set; } = "";
    public string Rol { get; set; } = "";
}

public class LoginResponse
{
    public string Token { get; set; } = "";
    public UsuarioResponse Usuario { get; set; } = new();
    public string Mensaje { get; set; } = "";
}