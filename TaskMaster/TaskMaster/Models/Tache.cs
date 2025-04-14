using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskMaster.Models
{
    public class Tache
    {
        public int Id { get; set; }
        public required string Titre { get; set; }
        public required string Description { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime Echeance { get; set; }
        public required string Statut { get; set; } // à faire, en cours...
        public required string Priorite { get; set; } // basse, moyenne...

        public required string Categorie { get; set; }

        public required Utilisateur Auteur { get; set; }
        public required Utilisateur Realisateur { get; set; }

        public required List<SousTache> SousTaches { get; set; }
        public required List<Etiquette> Etiquettes { get; set; }
        public required List<Commentaire> Commentaires { get; set; }
    }
}
