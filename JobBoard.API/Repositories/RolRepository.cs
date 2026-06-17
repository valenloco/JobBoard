using JobBoard.API.Data;
using JobBoard.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace JobBoard.API.Repositories
{
    public class RolRepository
    {
        private readonly JobBoardContext _context;

        public RolRepository(JobBoardContext context)
        {
            _context = context;
        }

        public async Task<List<Rol>> ObtenerTodos()
        {
            return await _context.Roles.ToListAsync();
        }
        public async Task<Rol?> ObtenerPorId(int id)
        {
            return await _context.Roles.FindAsync(id);
        }
        public async Task<Rol> Crear(Rol rol)
        {
            _context.Roles.Add(rol);
            await _context.SaveChangesAsync();
            return rol;
        }
        public async Task<Rol?> Actualizar(int id, Rol rolActualizado)
        {
            var rol = await _context.Roles.FindAsync(id);
            if (rol == null)
            {
                return null;
            }
            rol.NombreRol = rolActualizado.NombreRol;
            // Actualiza otras propiedades según sea necesario
            await _context.SaveChangesAsync();
            return rol;
        }
        public async Task Eliminar(int id)
        {
            var rol = await _context.Roles.FindAsync(id);
            if (rol != null)
            {
                _context.Roles.Remove(rol);
                await _context.SaveChangesAsync();
            }
        }
    }
}