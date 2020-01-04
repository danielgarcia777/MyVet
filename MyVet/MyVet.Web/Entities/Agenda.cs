using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Entities
{
    public class Agenda
    {
        public int Id { get; set; }
        [Display(Name = "Date")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd H:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public string Remarks { get; set; }
        [Display(Name ="Is Available?")]
        public bool IsAvailable { get; set; }
        // Cada que definamos una propiedad DATETIME le debemos definir una propiedad de lectura LOCAL
        // esto para evitar que haya errores y para saber que siempre va a mostrar la hora 
        //correcta asi nos conectemos desde otras partes del mundo
        // esta propiedad lleva los mismos formatos de la propiedad Date
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd H:mm tt}")]
        public DateTime DateLocal => Date.ToLocalTime();
        // se hace la relacion con los propietarios
        public Owner Owner { get; set; }
        //se hace la relacion con las pet
        public Pet Pet { get; set; }

    }
}
