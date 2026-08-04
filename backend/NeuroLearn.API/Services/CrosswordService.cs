using NeuroLearn.API.Services.Interfaces;
using NeuroLearn.API.Contracts.Requests;
using NeuroLearn.API.Models;
using NeuroLearn.API.Enums;


public class CrosswordService : ICrosswordService
{
    public CrosswordPuzzle CreatePuzzle (CreatePuzzleRequest request)
    {
        return new CrosswordPuzzle
        {
            Topic = request.Topic,
            Difficulty = request.Difficulty,
            LanguageCode = request.LanguageCode,
            ID = Guid.NewGuid(),
            Status = PuzzleStatus.Generating,
            CreatedAt = DateTime.UtcNow

        };
    }
}