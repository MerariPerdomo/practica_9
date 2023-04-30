using System.ComponentModel.DataAnnotations;

namespace practica_9.Models
{
    public class tipo_equipo
    {
        [Key]
        [Display(Name = "ID")]
        public int id_tipo_equipo { get; set; }
        [Display(Name = "Descripción")]
        public string? descripcion { get; set; }
        [Display(Name = "Estado")]
        public char estado { get; set; }
    }
}
