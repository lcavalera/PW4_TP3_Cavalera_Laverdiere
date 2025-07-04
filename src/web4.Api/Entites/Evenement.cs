﻿using Events.Api.Filters.Swagger;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Events.Api.Entites
{
    public class Evenement: BaseEntity
    {
        [Required]
        public DateTime DateDebut { get; set; }
        [Required]
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
        public List<string>? Categories { get; set; }
        [Required]
        public int VilleId { get; set; }
        public virtual Ville? Ville {  get; set; }
        public string VilleNom { get; set; }
        [SwaggerIgnore]
        public virtual List<Participation>? Participations { get; set; }
        public List<int> ParticipationIds { get; set; }
    }
}
