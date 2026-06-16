namespace JobBoard.API.Entities
{
    public class Estado
    {
        public int Id { get; set; }
        public string NombreEstado { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
