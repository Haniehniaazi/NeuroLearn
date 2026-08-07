using NeuroLearn.API.Contracts.Requests;
using NeuroLearn.API.Enums;
using NeuroLearn.API.Models;
using NeuroLearn.API.Services.Interfaces;

namespace NeuroLearn.API.Services;

public class WordGenerationService: IWordGenerationService
{
    public List<CrosswordEntry> GenerateEntries(CreatePuzzleRequest request)
    {
        return [
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
                StartColumn = 1,
                Direction = WordDirection.Vertical      
            }
        ];
    }
}