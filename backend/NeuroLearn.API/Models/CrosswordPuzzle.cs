using NeuroLearn.API.Enums;

namespace NeuroLearn.API.Models;

public class CrosswordPuzzle
{
    public Guid ID {get;set;}
    public string Topic {get; set;} = string.Empty;
    public DateTime CreatedAt {get; set;}
    public PuzzleStatus Status { get; set; } = PuzzleStatus.Generating;
    public Difficulty Difficulty { get; set; }
    public string LanguageCode { get; set; } = "en";
}