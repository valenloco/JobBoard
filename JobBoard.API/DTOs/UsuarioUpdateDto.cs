using JobBoard.API.Entities;

namespace JobBoard.API.DTOs
{
    public class UsuarioUpdateDto
    {
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Departamento { get; set; } = string.Empty;
        public string Ciudad { get; set; } = string.Empty;
        public string Contraseña { get; set; } = string.Empty;
        public bool? DobleAutenticacion { get; set; }
        public int IdRol { get; set; }
        public int? IdEmpresa { get; set; }

    }
}
