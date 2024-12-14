namespace Proiect_Medii.Models
{
    public class Reservation
    {
        public int ID { get; set; }
        public DateTime Data_Rezervarii {  get; set; }
        public int Durata { get; set; }
        public int? MemberID { get; set; }
        public Member? Member { get; set; }
        public int? TerenID { get; set; }
        public Teren? Teren { get; set; }

    }
}
