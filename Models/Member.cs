using System.ComponentModel.DataAnnotations;

namespace Proiect_Medii.Models
{
    public class Member
    {
        public int ID
        {
            get; set;
        }
        [Display(Name = "Last Name")]

        public string LastName { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        public string Email { get; set; }
        [StringLength(100, ErrorMessage = "Adresa trebuie sa contina maximum 80 de caractere!")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate
        {
            get; set;
        }
        public int? MembershipID { get; set; }
        public Membership? Membership { get; set; }
    }
}