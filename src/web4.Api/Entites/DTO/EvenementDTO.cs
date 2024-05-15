using Events.Api.Filters.Swagger;
using System.ComponentModel.DataAnnotations;

namespace Events.Api.Entites.DTO
{
    public class EvenementDTO
    {
        public int Id { get; set; }
        [Required, DataType(DataType.Date), DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateDebut { get; set; }
        [Required, DataType(DataType.Date), DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateDeFin { get; set; }
        [Required]
        public string Titre { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Adresse { get; set; }
        [Required]
        public string NomOrganisateur { get; set; }
        public int Prix { get; set; }
        [Required]
        public List<int> CategorieIds { get; set; }
        public List<string> Categories { get; set; }
        [Required]
        public int VilleId { get; set; }
        public string VilleNom { get; set; }
        public List<int> ParticipationIds { get; set; }
    }
}
