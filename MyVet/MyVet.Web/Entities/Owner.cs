using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Entities
{
    public class Owner
    {
        //Se crean las propiedades de la clase owner
        //Todas las tablas en EF tienen una propidedad obligatoria que es el ID
        public int Id { get; set; }
        /*se usan los DATANNOTATION para asegurarse que el campo sea obligatorio
        //con la palabra REQUIRED especificamos que el campo debe ser obligatorio
        [Required(ErrorMessage ="The field {0} is mandatory")]
        //Se debe usar otra ANNOTATION. maxlengh para que en la BD no consuma mucha memoria
        [MaxLength(30, ErrorMessage ="The {0} field can not have more than {1} characters")]
        public string Document { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters")]
        //Para los campos que tienen nombres compuestos existe la propiedad DISPLAY
        //Con esta propiedad vamos a mostarle al usuario el nombre del campo tal y como queremos que el usuario lo vea
        [Display(Name = "First Name")]
        public string FirsName { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters")]
        [Display(Name = "Fixed Number")]
        public string FixedNumber { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters")]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters")]
        public string Address { get; set; }
        // si se requieren campos calculados necesitamos concatenar campos
        //Para concatenar campos se deja solo la propiedad get y se pone la palabra return y los campos a concatenar
        //Esta es la forma vieja de concatenar datos
        public string FullName
        {
            get
            {
                return $"{FirsName} {LastName}";
            }
        }
        //La forma nueva para hacerlo es la siguiente
        [Display(Name = "Owner")]
        public string FullName se usa un delegado=> $"{FirsName} {LastName}";
        [Display(Name = "Owner")]
        public string FullNameWhitDocument => $"{FirsName} {LastName} - {Document}";
        se define la propiedad que hace la relación con las Pet*/

        //Se borran todas las propiedades de los owners y se dejan solo las relaciones, debido a que owner depende
        //de la clase User y User hereda de IdentityUser y ya trae los campos por defecto
        public User User { get; set; }
        public ICollection<Pet> Pets { get; set; }
        // se define la realcion para los owner con la agenda, un propietario puede tener muchas agendas
        public ICollection<Agenda> Agendas { get; set; }
    }
}
