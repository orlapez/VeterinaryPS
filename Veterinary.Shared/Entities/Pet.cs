using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class Pet
    {

        public int Id { get; set; }
        [Display(Name = "Nombre de la mascota")]
        [MaxLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Name { get; set; }

        [Display(Name = "Foto de la mascota")]
        public string ImageUrl { get; set; }

        [Display(Name = "Raza")]
        [MaxLength(50, ErrorMessage = "La raza  no puede tener más de 50 caracteres.")]
        [Required(ErrorMessage = "La raza es obligatoria")]
        public string Race { get; set; }


        [Display(Name = "Nacimiento mascota")]
        [Required(ErrorMessage = "¡Esta fecha  es obligatoria!")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Born { get; set; }

        [Display(Name = "Observaciones y/o comentarios")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }


        public Owner Owner { get; set; }


        public PetType PetType { get; set; }



        public ICollection<History> Histories { get; set; }

        public ICollection<Agenda> Agendas { get; set; }




    }
    }


