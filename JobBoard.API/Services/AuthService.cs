using JobBoard.API.DTOs.Auth;
using JobBoard.API.Repositories;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using JobBoard.API.Entities;
using System.Security.Claims;
using System.Text;

namespace JobBoard.API.Services
{
    public class AuthService
    {
        private readonly IConfiguration _configuration;
        private readonly UsuarioRepository _usuarioRepository;

        public AuthService(IConfiguration configuration, UsuarioRepository usuarioRepository)
        {
            _configuration = configuration;
            _usuarioRepository = usuarioRepository;
        }

        public async Task<AuthResponseDto?> Login(LoginDto dto)
        {
            var usuario = await _usuarioRepository.ObtenerPorCorreo(dto.Correo);

            if (usuario == null || !BCrypt.Net.BCrypt.Verify(dto.Contrasena, usuario.PasswordHash))
                return null;

            var token = GenerarToken(usuario);

            return new AuthResponseDto
            {
                Token = token,
                Correo = usuario.Correo,
                Nombres = usuario.Nombres,
                Rol = usuario.Rol.NombreRol
            };
        }
        private string GenerarToken(JobBoard.API.Entities.Usuario usuario)
        {
            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
            new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
            new Claim(ClaimTypes.Email, usuario.Correo),
            new Claim(ClaimTypes.Role, usuario.Rol.NombreRol)
        };

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(8),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}