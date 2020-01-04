using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Entities
{
    public class History
    {
        //se crean los dos campos que va a tener esta tabla
        public int Id { get; set; }
        [Display(Name = "Description")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Description { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public string Remarks { get; set; }
        // Cada que definamos una propiedad DATETIME le debemos definir una propiedad de lectura LOCAL
        // esto para evitar que haya errores y para saber que siempre va a mostrar la hora 
        //correcta asi nos conectemos desde otras partes del mundo
        // esta propiedad lleva los mismos formatos de la propiedad Date
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DateLocal => Date.ToLocalTime();
        // definimos la propiedad que relaciona las historias con el servicetype
        public ServiceType ServiceType { get; set; }
        //se define la propiedad que relaciona las historias con las Pet
        public Pet Pet { get; set; }

    }
}
