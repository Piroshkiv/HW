namespace PW_4_3_ModuleTask.Models;

public class Song
{
    public int Id { get; set; }
    public string Title { get; set; }
    public TimeSpan Duration { get; set; }
    public DateTime ReleasedDate { get; set; }
    public int? GenreId { get; set; }

    public Genre Genre { get; set; }
    public List<Artist> Artists { get; set; }
}
