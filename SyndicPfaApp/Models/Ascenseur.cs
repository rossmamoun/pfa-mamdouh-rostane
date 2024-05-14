using System.ComponentModel.DataAnnotations;

namespace SyndicPfaApp.Models
{
    public class Ascenseur
    {
        [Key]
        public int AscenseurId { get; set; }
        [Required]
        public string AscenseurName { get; set; }
        [Required]
        public string Etat { get; set; }
        public DateTime DernierEntretien { get; set; }
    }
}
