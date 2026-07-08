
namespace JobBoard.API.DTOs.Auth
{
    public class AuthResponseDto
    {
        public string Token { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Nombres { get; set; } = string.Empty;
        public string Rol { get; set; } = string.Empty;
    }
}
