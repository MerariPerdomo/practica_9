using System.ComponentModel.DataAnnotations;

namespace practica_9.Models
{
    public class usuarios
    {
        [Key]
        [Display(Name = "ID de usuario")]
        public int usuario_id { get; set; }
        [Display(Name = "Nombre de usuario")]
        public string? nombre { get; set; }
        [Display(Name = "Documento")]
        public string? documento { get; set; }
        [Display(Name = "Tipo")]
        public char tipo { get; set; }
        [Display(Name = "Carnet")]
        public string? carnet { get; set; }
        [Display(Name = "ID de carrera")]
        public int carrera_id { get; set; }
    }
}
