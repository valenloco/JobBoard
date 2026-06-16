namespace JobBoard.API.Entities
{
    public class Discapacidad
    {
        public int Id { get; set; }
        public string TipoDiscapacidad { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
