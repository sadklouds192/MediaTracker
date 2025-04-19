using System.ComponentModel.DataAnnotations;
using MediaTracker.Core.Enums;

namespace MediaTracker.Core.DataModels;

public class NovelModel
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Title { get; set; }
    public string? Author { get; set; }
    public int TotalChapters { get; set; }
    public int CurrentChapter { get; set; }
    public MediaStatus Status { get; set; } 
    public DateTime  DateAdded { get; set; } = DateTime.Now;
    public DateTime ?DateStarted { get; set; }
    public DateTime ?DateCompleted { get; set; }

}