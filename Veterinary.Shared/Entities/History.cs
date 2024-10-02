using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public  class History
    {
        public int Id { get; set; }

        [Display(Name = "Historia del servicio prestado")]
        [DataType(DataType.MultilineText)] 
        [MaxLength(100, ErrorMessage = "La descripción no puede tener más de 100 caracteres.")]
        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string Description { get; set; }



        [Display(Name = "Fecha historia")]
        [Required(ErrorMessage = "¡Esta fecha  es obligatoria!")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }



        [Display(Name = "Observaciones y/o comentarios")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [JsonIgnore]
        public ServiceType ServiceTypes { get; set; }
        public int ServiceTypeId { get; set; }

        [JsonIgnore]
        public Pet Pets { get; set; }
        public int PetTypeId { get; set; }

    }
}
