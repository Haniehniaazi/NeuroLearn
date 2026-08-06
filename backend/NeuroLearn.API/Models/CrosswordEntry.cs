using NeuroLearn.API.Enums;

namespace NeuroLearn.API.Models;

public class CrosswordEntry
{
    public string Answer {get; set;} = string.Empty;
    public int Length => Answer.Length;
    public string Clue {get;set;} = string.Empty;
    public int StartRow {get; set;}
    public int StartColumn {get; set;}
    public WordDirection Direction {get; set;} 
}