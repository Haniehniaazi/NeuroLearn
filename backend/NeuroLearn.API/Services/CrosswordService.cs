using NeuroLearn.API.Services.Interfaces;
using NeuroLearn.API.Contracts.Requests;
using NeuroLearn.API.Models;
using NeuroLearn.API.Enums;

namespace NeuroLearn.API.Services;
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
            Status = PuzzleStatus.Ready,
            CreatedAt = DateTime.UtcNow,
            Entries =
        [
            new CrosswordEntry
            {
                Answer = "ROUTER",
                Clue = "Verbindet unterschiedliche Netzwerke",
                StartRow = 2,
                StartColumn = 1,
                Direction = WordDirection.Horizontal
            },
            new CrosswordEntry
            {
                Answer = "SERVER",
                Clue = "Stellt anderen Geräten Dienste bereit",
                StartRow = 0,
                StartColumn = 3,
                Direction = WordDirection.Vertical
            }
        ]

        };
    }
}