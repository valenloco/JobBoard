namespace JobBoard.API.Entities
{
    public class VacanteAplicada
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public int IdVacante { get; set; }
        public Vacante Vacante { get; set; } = null!;
        public int IdEstado { get; set; }
        public Estado Estado { get; set; } = null;
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
