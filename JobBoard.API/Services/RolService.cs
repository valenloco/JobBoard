using JobBoard.API.Repositories;
using JobBoard.API.Entities;

namespace JobBoard.API.Services
{
    public class RolService
    {
        private readonly RolRepository _rolRepository;

        public RolService(RolRepository rolRepository)
        {
            _rolRepository = rolRepository;
        }
        public async Task<List<Rol>> ObtenerTodos()
        {
            return await _rolRepository.ObtenerTodos();
        }
        public async Task<Rol?> ObtenerPorId(int id)
        {
            return await _rolRepository.ObtenerPorId(id);
        }
        public async Task<Rol> Crear(Rol rol)
        {
            return await _rolRepository.Crear(rol);
        }
        public async Task<Rol?> Actualizar(int id, Rol rolActualizado)
        {
            return await _rolRepository.Actualizar(id, rolActualizado);
        }
        public async Task Eliminar(int id)
        {
            await _rolRepository.Eliminar(id);
        }
    }
}
