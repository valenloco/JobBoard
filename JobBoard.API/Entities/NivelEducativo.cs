namespace JobBoard.API.Entities
{
    public class NivelEducativo
    {
        public int Id { get; set; }
        public string Educacion { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
