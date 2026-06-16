namespace JobBoard.API.Entities
{
    public class UsuarioHabilidad
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public int IdHabilidad { get; set; }
        public Habilidad Habilidad { get; set; } = null!;
    }
}
