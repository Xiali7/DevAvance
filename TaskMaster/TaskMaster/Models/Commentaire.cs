namespace TaskMaster.Models
{
    public class Commentaire
    {
        public int Id { get; set; }
        public required string Auteur { get; set; }
        public DateTime Date { get; set; }
        public required string Contenu { get; set; }

        public int TacheId { get; set; }
        public required Tache Tache { get; set; }
    }
}
