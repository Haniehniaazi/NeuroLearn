using NeuroLearn.API.Services.Interfaces;
using NeuroLearn.API.Contracts.Requests;
using NeuroLearn.API.Models;
using NeuroLearn.API.Enums;

namespace NeuroLearn.API.Services;
public class CrosswordService : ICrosswordService
{
    private readonly IWordGenerationService _wordGenerationService;

    public CrosswordService(IWordGenerationService wordGenerationService)
    {
        _wordGenerationService = wordGenerationService;
    }
    public CrosswordPuzzle CreatePuzzle (CreatePuzzleRequest request)
    {
        List<CrosswordEntry> entries =
            _wordGenerationService.GenerateEntries(request);
        return new CrosswordPuzzle
        {
            Topic = request.Topic,
            Difficulty = request.Difficulty,
            LanguageCode = request.LanguageCode,
            ID = Guid.NewGuid(),
            Status = PuzzleStatus.Ready,
            CreatedAt = DateTime.UtcNow,
            Entries = entries

        };
    }
}