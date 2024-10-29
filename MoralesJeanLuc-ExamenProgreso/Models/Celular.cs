using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoralesJeanLuc_ExamenProgreso.Models
{
    public class Celular
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Modelo { get; set; }
        public int Año { get; set; }
        [Range(1.0, 3000.0, ErrorMessage = "Ingrese un valor entre 1.0 y 3000.0")]
        public decimal Precio { get; set; }
        public MoralesJeanLuc Dueño { get; set; }
        [ForeignKey("MoralesJeanLuc")]
        public int IdMoralesJeanLuc { get; set; }
        
    }
}
