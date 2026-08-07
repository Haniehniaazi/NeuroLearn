namespace NeuroLearn.API.Models;

public class GeneratedWord
{
    public string Answer { get; set; } = string.Empty;

    public int Length => Answer.Length;

    public string Clue { get; set; } = string.Empty;
}