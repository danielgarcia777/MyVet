using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyVet.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data
{
    // Esta clase se hereda de la DbContext
    // para señalar que hereda, se ponen dos puntos y el nombre de la DB
    public class DataContext : IdentityDbContext<User>
    {
        // se crea un constructor
        // para crear un constructor se  pone la palabra ctor y tab
        // se le agregan los parametros y se le pasa el parametro al constructor de la superClase
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        // se crean las propiedades para mapear la BD
        // la propiedad debe ser de tipo DbSet
        // se le dice el modelo que se quiere mapear en la base de datos, en este caso Owner
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Pet> Pets { get; set; }    
        public DbSet<PetType> PetTypes { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }


    }
}
