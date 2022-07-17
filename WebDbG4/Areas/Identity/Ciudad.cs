using System.ComponentModel.DataAnnotations;

namespace WebDbG4.Areas.Identity
{
    public class Ciudad
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(40)]
        public string? Nombre { get; set; }

        public int DptoId { get; set; }

        public ICollection<Personas>? Personas { get; set; }

        public Dpto? Dpto { get; set; }
    }
}
