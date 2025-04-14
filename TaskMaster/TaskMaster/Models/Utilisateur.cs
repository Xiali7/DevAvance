namespace TaskMaster.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public required string Nom { get; set; }
        public required string Prenom { get; set; }
        public required string Email { get; set; }

        // Liste des tâches créées
        public required List<Tache> TachesCreees { get; set; }
        public required List<Tache> TachesAssignees { get; set; }
    }
}
