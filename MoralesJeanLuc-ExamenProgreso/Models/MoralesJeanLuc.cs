using System.ComponentModel.DataAnnotations;

namespace MoralesJeanLuc_ExamenProgreso.Models
{
    public class MoralesJeanLuc
    {
        [Key]

        public int Id { get; set; }
        [Required]
        [Range(1.0,5000.0,ErrorMessage = "Ingrese un valor entre 1.0 y 5000.0")]
        public decimal Sueldo { get; set; }
        [Required]
        [EmailAddress]
        public string Correo { get; set; }
        [Required]
        public bool HorasExtra { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Inicio de contrato")]
        public DateTime FechaInicio { get; set; }
    }
}
