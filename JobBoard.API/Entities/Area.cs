namespace JobBoard.API.Entities
{
    public class Area
    {
        public int Id { get; set; }
        public string NombreArea { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
