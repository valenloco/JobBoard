namespace JobBoard.API.Entities
{
    public class Habilidad
    {
        public int Id { get; set; }
        public string NombreHabilidad { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
