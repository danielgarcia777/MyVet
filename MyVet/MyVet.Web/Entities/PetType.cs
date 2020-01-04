using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Entities
{
    public class PetType
    {
        public int Id { get; set; }
        [Display(Name ="Pet Type")]
        [MaxLength(50, ErrorMessage ="The {0} field can not have more than {1} characters")]
        [Required( ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }
        // se define la propiedad que se va a conectar con la entiti Pet
        //La propiedad debe ser de tipo Icollection
        public ICollection<Pet> Pets { get; set; }

    }
}
