namespace Proiect_Medii.Models
{
    public class Teren
    {
        public int ID { get; set; }
        public string Tip { get; set; }
        public double Dimensiune { get; set; }
        public ICollection<Reservation>? Reservations{ get; set; }

    }
}
