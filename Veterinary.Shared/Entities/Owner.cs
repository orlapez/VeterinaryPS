using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class Owner
    {

        //Primary key- Autoincrement
        public int Id { get; set; }

        [Display(Name ="Documento de identidad")]
        [MaxLength(10,ErrorMessage ="El {0} no puede tener más de 10 caracteres.")]
        [Required(ErrorMessage ="El {0} es obligatorio")]
        public string Document { get; set; }

        [Display(Name = "Nombre propietario")]
        [MaxLength(40, ErrorMessage = "El {1} no puede tener más de 40 caracteres.")]
        [Required(ErrorMessage = "El {1} es obligatorio")]
        public string FirstName { get; set; }

        [Display(Name = "Apellido propietario")]

        [MaxLength(50, ErrorMessage = "El {2} no puede tener más de 50 caracteres.")]
        [Required(ErrorMessage = "El {2} es obligatorio")]
        public string LastName { get; set; }

        [Display(Name = "Teléfono fijo")]
        [MaxLength(7, ErrorMessage = "El {3} no puede tener más de 7 caracteres.")]
        public string FixedPhone { get; set; }

        [Display(Name = "Teléfono móvil")]
        [MaxLength(10, ErrorMessage = "El {4} no puede tener más de 10 caracteres.")]
        public string CellPhone { get; set; }

        [Display(Name = "Dirección de residencia")]
        [MaxLength(50, ErrorMessage = "El {5} no puede tener más de 10 caracteres.")]
        [Required(ErrorMessage = "El {5} es obligatorio")]
        public string Address { get; set; }

        public string FullName => $"{FirstName} {LastName}";









    }
}
