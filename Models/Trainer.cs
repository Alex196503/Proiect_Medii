using System.ComponentModel.DataAnnotations;

namespace Proiect_Medii.Models
{
    public class Trainer
    {
        public int ID { get; set; }
        [Required(ErrorMessage="Numele antrenorului este obligatoriu.")]
        [StringLength(100,ErrorMessage="Numele nu poate depăși 100 de caractere.")]
        public string Name { get; set; }
        [Required(ErrorMessage="Numarul de telefon al antrenorului este obligatoriu.")]
        [RegularExpression(@"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Telefonul trebuie sa fie de forma '0741-242-469' sau'0741.242.469' sau '0741 242 469'")]
        public string PhoneNumber { get; set; }
        [StringLength(100,ErrorMessage="Specializarea nu poate depăși 70 de caractere.")]
        public string Specializare { get; set; }
        public ICollection<Member>? Members { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
