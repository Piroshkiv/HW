namespace PW_4_3_ModuleTask.Models;

public class Artist
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime? DateOfDeath { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? InstagramUrl { get; set; }

    public List<Song> Songs { get; set; }
}
