namespace Proiect_Medii.Models
{
    public class Trainer
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Specializare { get; set; }
        public ICollection<Member>? Members { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
