namespace JobBoard.API.Entities
{
    public class VacanteHabilidad
    {
        public int Id { get; set; }
        public int IdVacante { get; set; }
        public Vacante Vacante { get; set; } = null!;
        public int IdHabilidad { get; set; }
        public Habilidad Habilidad { get; set; } = null!;
    }
}
