using System.ComponentModel.DataAnnotations;

namespace SyndicPfaApp.Models
{
    public class Resident
    {
        [Key]
        public int AppartementId {  get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Loyer {  get; set; }
    }
}
