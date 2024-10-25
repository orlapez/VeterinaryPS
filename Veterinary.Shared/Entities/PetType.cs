﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class PetType
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de mascota")]
        [MaxLength(50, ErrorMessage = "El {0} no puede tener menos de 50 caracteres.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Name { get; set; }
    }
}
