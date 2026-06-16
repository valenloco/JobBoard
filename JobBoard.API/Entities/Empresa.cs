namespace JobBoard.API.Entities
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nit { get; set; } = string.Empty;
        public string RazonSocial { get; set; } = string.Empty;
        public string? Direccion { get; set; } 
        public string? Departamento { get; set; } 
        public string? Ciudad { get; set; }
        public string? Telefono { get; set; }
        public string Correo { get; set; } = string.Empty;
        public string Sector { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
