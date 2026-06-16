namespace JobBoard.API.Entities
{
    public class Rol
    {
        public int Id { get; set; }

        public string NombreRol { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}
