using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Entities
{
    public class Pet
    {
        public int Id { get; set; }
        // se crea el campo del nombre
        [Display(Name = "Name")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }
        // se crea el campo imagen
        [Display(Name ="Image")]
        public string ImageUrl { get; set; }
        //se crea el campo raza
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters")]
        public string Race { get; set; }
        //se crea el campo de fecha de nacimiento
        [Display(Name = "Born")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Born { get; set; }
        // se crea el campo comentarios
        public string Remarks { get; set; }

        //TODO: Replace the correct URL for the image y se crea una propiedad de sólo lectura
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://TBD.azurewebsites.net{ImageUrl.Substring(1)}";
        // se crea la propiedad born local para asegurarse que no haya probelmas con la fecha
        [Display(Name = "Born")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime BornLocal => Born.ToLocalTime();

        // se define la relación que va a tener la BD, una mascota pertenece a un tipo de mascota
        // se hace lo mismo en la otra punta para asegurarse que la relación esta bien hecha
        public PetType PetType { get; set; }
        // se define la propiedad que crea la relación con los propietarios "Owner"
        public Owner Owner { get; set; }
        //Se define la propiedad que relaciona las pet con las histories
        public ICollection<History> Histories { get; set; }
        // Se define la propiedad que relaciona las pet con la agenda
        public ICollection<Agenda> Agendas { get; set; }
    }
}
