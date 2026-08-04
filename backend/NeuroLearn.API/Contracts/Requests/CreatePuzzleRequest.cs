using NeuroLearn.API.Enums;

namespace NeuroLearn.API.Contracts.Requests;

public class CreatePuzzleRequest
{
    public string Topic {get; set;} = string.Empty;
    public string LanguageCode {get; set;} = string.Empty;
    public Difficulty Difficulty {get; set;}

}