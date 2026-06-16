namespace JobBoard.API.Entities
{
    public class Vacante
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal? Salario { get; set; }
        public string? Departamento { get; set; }
        public string? Ciudad { get; set; }
        public bool? Discapacidad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int IdArea { get; set; }
        public Area Area { get; set; } = null!;
        public int IdModalidad { get; set; }
        public ModalidadTrabajo ModalidadTrabajo { get; set; } = null!;
        public int IdContrato { get; set; }
        public TipoContrato TipoContrato { get; set; } = null!;
        public int IdEmpresa { get; set; }
        public Empresa Empresa { get; set; } = null!;
        public int IdEducacion { get; set; }
        public NivelEducativo NivelEducativo { get; set; } = null!;
    }
}
