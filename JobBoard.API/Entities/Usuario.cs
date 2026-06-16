namespace JobBoard.API.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Documento { get; set; } = string.Empty;
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string? Telefono { get; set; }
        public string Correo { get; set; } = string.Empty;
        public string? Direccion { get; set; }
        public string? Departamento { get; set; }
        public string? Ciudad { get; set; }
        public string PasswordHash { get; set; } = string.Empty;
        public bool? DobleAutenticacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int IdRol { get; set; }
        public Rol Rol { get; set; } = null!;
        public int? IdEmpresa { get; set; }
        public Empresa? Empresa { get; set; } 
    }
}
