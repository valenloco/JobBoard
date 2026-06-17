using JobBoard.API.Repositories;
using JobBoard.API.DTOs;
using JobBoard.API.Entities;

namespace JobBoard.API.Services
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioService(UsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public async Task<List<UsuarioResponseDto>> ObtenerTodos()
        {
            List<Usuario> usuarios = await _usuarioRepository.ObtenerTodos();
            return usuarios.Select(u => new UsuarioResponseDto
            {
                Id = u.Id,
                Documento = u.Documento,
                Nombres = u.Nombres,
                Apellidos = u.Apellidos,
                Telefono = u.Telefono,
                Correo = u.Correo,
                Direccion = u.Direccion,
                Departamento = u.Departamento,
                Ciudad = u.Ciudad,
                Rol = u.Rol.NombreRol,
                Empresa = u.Empresa?.RazonSocial
            }).ToList();
        }

        public async Task<UsuarioResponseDto> ObtenerPorId(int id)
        {
            var usuario = await _usuarioRepository.ObtenerPorId(id);
            if (usuario == null) return null;
            return new UsuarioResponseDto
            {
                Id = usuario.Id,
                Documento = usuario.Documento,
                Nombres = usuario.Nombres,
                Apellidos = usuario.Apellidos,
                Telefono = usuario.Telefono,
                Correo = usuario.Correo,
                Direccion = usuario.Direccion,
                Departamento = usuario.Departamento,
                Ciudad = usuario.Ciudad,
                Rol = usuario.Rol.NombreRol,
                Empresa = usuario.Empresa?.RazonSocial
            };
        }
        public async Task<UsuarioResponseDto> Crear(UsuarioCreateDto dto)
        {
            var usuario = new Usuario
            {
                Documento = dto.Documento,
                Nombres = dto.Nombres,
                Apellidos = dto.Apellidos,
                Telefono = dto.Telefono,
                Correo = dto.Correo,
                Direccion = dto.Direccion,
                Departamento = dto.Departamento,
                Ciudad = dto.Ciudad,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Contraseña),
                DobleAutenticacion = dto.DobleAutenticacion ?? false,
                FechaCreacion = DateTime.Now,
                IdRol = dto.IdRol,
                IdEmpresa = dto.IdEmpresa
            };
            var usuarioCreado = await _usuarioRepository.Crear(usuario);
            return new UsuarioResponseDto
            {
                Id = usuarioCreado.Id,
                Documento = usuarioCreado.Documento,
                Nombres = usuarioCreado.Nombres,
                Apellidos = usuarioCreado.Apellidos,
                Telefono = usuarioCreado.Telefono,
                Correo = usuarioCreado.Correo,
                Direccion = usuarioCreado.Direccion,
                Departamento = usuarioCreado.Departamento,
                Ciudad = usuarioCreado.Ciudad,
                Rol = usuarioCreado.Rol.NombreRol,
                Empresa = usuarioCreado.Empresa?.RazonSocial
            };
        }

        public async Task<UsuarioResponseDto> Actualizar(int id, UsuarioUpdateDto dto)
        {
            var usuarioActualizado = new Usuario
            {
                Nombres = dto.Nombres,
                Apellidos = dto.Apellidos,
                Telefono = dto.Telefono,
                Correo = dto.Correo,
                Direccion = dto.Direccion,
                Departamento = dto.Departamento,
                Ciudad = dto.Ciudad,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Contraseña),
                DobleAutenticacion = dto.DobleAutenticacion ?? false,
                IdRol = dto.IdRol,
                IdEmpresa = dto.IdEmpresa
            };
            var usuario = await _usuarioRepository.Actualizar(id, usuarioActualizado);
            if (usuario == null) return null;
            return new UsuarioResponseDto
            {
                Id = usuario.Id,
                Documento = usuario.Documento,
                Nombres = usuario.Nombres,
                Apellidos = usuario.Apellidos,
                Telefono = usuario.Telefono,
                Correo = usuario.Correo,
                Direccion = usuario.Direccion,
                Departamento = usuario.Departamento,
                Ciudad = usuario.Ciudad,
                Rol = usuario.Rol.NombreRol,
                Empresa = usuario.Empresa?.RazonSocial
            };
        }

        public async Task Eliminar(int id)
        {
            await _usuarioRepository.Eliminar(id);
        }
    }
}