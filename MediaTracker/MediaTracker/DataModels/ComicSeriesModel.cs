using System.ComponentModel.DataAnnotations;
using MediaTracker.Enums;

namespace MediaTracker.DataModels;

public class ComicSeriesModel
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Title { get; set; }
    public string? Author { get; set; }
    public string? Artist { get; set; }
    public ComicOrigin Origin { get; set; }
    public int TotalChapters { get; set; }
    public int ?TotalVolumes { get; set; }
    public int ?CurrentChapter { get; set; }
    public MediaStatus Status { get; set; } 
    public DateTime  DateAdded { get; set; } = DateTime.Now;
    public DateTime ?DateStarted { get; set; }
    public DateTime ?DateCompleted { get; set; }
}