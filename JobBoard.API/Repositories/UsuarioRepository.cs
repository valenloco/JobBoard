using JobBoard.API.Data;
using JobBoard.API.Entities;
using Microsoft.EntityFrameworkCore;


namespace JobBoard.API.Repositories
{
    public class UsuarioRepository
    {
        private readonly JobBoardContext _context;
        public UsuarioRepository(JobBoardContext context)
        {
            _context = context;
        }
        public async Task<List<Usuario>> ObtenerTodos()
        {
            return await _context.Usuarios.Include(u => u.Rol).ToListAsync();
        }
        public async Task<Usuario?> ObtenerPorId(int id)
        {
            return await _context.Usuarios.Include(u => u.Rol).FirstOrDefaultAsync(u => u.Id == id);
        }
        public async Task<Usuario> Crear(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return await _context.Usuarios
                .Include(u => u.Rol)
                .Include(u => u.Empresa)
                .FirstOrDefaultAsync(u => u.Id == usuario.Id);
        }
        public async Task<Usuario?> Actualizar(int id, Usuario usuarioActualizado)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return null;
            }
            usuario.Nombres = usuarioActualizado.Nombres;
            usuario.Apellidos = usuarioActualizado.Apellidos;
            usuario.Telefono = usuarioActualizado.Telefono;
            usuario.Correo = usuarioActualizado.Correo;
            usuario.Direccion = usuarioActualizado.Direccion;
            usuario.Departamento = usuarioActualizado.Departamento;
            usuario.Ciudad = usuarioActualizado.Ciudad;
            usuario.PasswordHash = usuarioActualizado.PasswordHash;
            usuario.DobleAutenticacion = usuarioActualizado.DobleAutenticacion;
            usuario.FechaModificacion = DateTime.UtcNow;
            usuario.IdRol = usuarioActualizado.IdRol;
            usuario.IdEmpresa = usuarioActualizado.IdEmpresa;
            await _context.SaveChangesAsync();
            return await _context.Usuarios
                .Include(u => u.Rol)
                .Include(u => u.Empresa)
                .FirstOrDefaultAsync(u => u.Id == usuario.Id);
        }
        public async Task Eliminar(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                await _context.SaveChangesAsync();
            }
        }
    }
}
