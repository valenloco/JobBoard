namespace JobBoard.API.Entities
{
    public class ModalidadTrabajo
    {
        public int Id { get; set; }
        public string Modalidad { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
