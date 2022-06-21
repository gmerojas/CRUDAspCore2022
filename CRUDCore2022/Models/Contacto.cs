using System.ComponentModel.DataAnnotations;

namespace CRUDCore2022.Models
{
    public class Contacto
    {
        public int IdContacto { get; set; }
        [Required(ErrorMessage = "El campo NOMBRE es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo TELEFONO es obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El campo CORREO es obligatorio")]
        public string Correo { get; set; }
    }
}
