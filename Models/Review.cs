namespace Proiect_Medii.Models
{
    public class Review
    {

    
            public int ID { get; set; }
            public int Rating { get; set; }
            public string? Comment { get; set; }
            public DateTime Data_Review { get; set; }
        public int TrainerID
        {
            get;set;
        }
        public Trainer? Trainer { get; set; }
        
        }
    }


