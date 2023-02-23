namespace PW_4_3_ModuleTask.Models;

public class Genre
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<Song> Songs { get; set; }
}
