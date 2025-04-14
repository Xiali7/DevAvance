namespace TaskMaster.Models
{
    public class Etiquette
    {
        public int Id { get; set; }
        public required string Nom { get; set; }

        public int TacheId { get; set; }
        public required Tache Tache { get; set; }
    }
}
