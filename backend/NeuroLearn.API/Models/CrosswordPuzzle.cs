using NeuroLean.API.Enums;

namespace NeuroLean.API.Models;

public class CrosswordPuzzle
{
    public Guid ID {get;set;}
    public string Topic {get; set;} = string.Empty;
    public string Language {get; set;} = string.Empty;
    public DateTime CreatedAt {get; set;}
    public PuzzleStatus Status { get; set; } = PuzzleStatus.Generating;
    public string Difficulty { get; set; } = string.Empty;
    public string LanguageCode { get; set; } = "en";
}