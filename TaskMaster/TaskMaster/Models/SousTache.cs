namespace TaskMaster.Models
{
    public class SousTache
    {
        public int Id { get; set; }
        public required string Titre { get; set; }
        public required string Statut { get; set; }
        public DateTime? Echeance { get; set; }

        public int TacheId { get; set; }
        public required Tache Tache { get; set; }
    }
}
