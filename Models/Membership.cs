using System.ComponentModel.DataAnnotations;

namespace Proiect_Medii.Models
{
    public class Membership
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Numele membership-ului este obligatoriu.")]
        [StringLength(100, ErrorMessage = "Numele membership-ului nu poate depăși 100 de caractere.")]
        
        public string MembershipName { get; set; }
        [Required(ErrorMessage = "Data de start este obligatorie.")]
        [DataType(DataType.Date, ErrorMessage = "Data de start trebuie să fie o dată validă.")]
        public DateTime? Data_Start { get; set; }
        [Required(ErrorMessage = "Data de expirare este obligatorie.")]
        [DataType(DataType.Date, ErrorMessage = "Data de expirare trebuie să fie o dată validă.")]
        public DateTime? Data_Expirare { get; set; }

        public ICollection<Member>? Members { get; set; }
    }
}
