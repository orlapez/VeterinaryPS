using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public  class Agenda
    {
        public int Id { get; set; }


        [Display(Name = "Fecha cita")]
        [Required(ErrorMessage = "¡Esta fecha  es obligatoria!")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }


        [Display(Name = "¿Está disponible?")]
        public bool IsAvailable { get; set; }


        [Display(Name = "Observaciones y/o comentarios")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [JsonIgnore]
        public Owner Owners { get; set; }
        public int OwnerId { get; set; }


        [JsonIgnore]

        public Pet Pets { get; set; }
        public int PetId { get; set; }


    }
}
