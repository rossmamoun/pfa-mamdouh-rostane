using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SyndicPfaApp.Models
{
    public class Intervention
    {
        [Key] 
        public int InterventionId { get; set; }
        public string InterventionDescription { get; set;}
        public int AscenseurId {  get; set;}
        [ForeignKey("AscenseurId")]
        [ValidateNever]
        public Ascenseur Ascenseur { get; set;}
        [Required]
        public DateTime DateEntretien { get; set; }


    }
}
