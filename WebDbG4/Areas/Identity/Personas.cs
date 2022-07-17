using System.ComponentModel.DataAnnotations;

namespace WebDbG4.Areas.Identity
{
    public class Personas
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(40)]
        
        public string? Nombre { get; set; }

        [MaxLength(40)]
        [Display(Name = "Dirección")]
        public string? Direccion { get; set; }

        public int CiudadId { get; set; }

        [MaxLength(40)]
        public string? Email { get; set; }

        [Display(Name = "Fecha Nacimiento")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime FechaNac { get; set; }

        public Ciudad? Ciudad { get; set; }
    }
}
