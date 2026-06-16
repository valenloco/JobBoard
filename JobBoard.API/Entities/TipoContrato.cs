namespace JobBoard.API.Entities
{
    public class TipoContrato
    {
        public int Id { get; set; }
        public string Contrato { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
