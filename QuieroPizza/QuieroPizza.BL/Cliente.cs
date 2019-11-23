using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese el nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese el numero de teléfono")]
        [Display(Name = "Teléfono")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "No es un número válido")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Ingrese la dirección")]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        public bool Activo { get; set; }
    }
}
