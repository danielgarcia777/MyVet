namespace MyVet.Web.Entities
{
    public class Manager
    {
        // la clase Manager se copia de la clase User
        public int Id { get; set; }
        public User User { get; set; }
    }
}
