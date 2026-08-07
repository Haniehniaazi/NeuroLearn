using NeuroLearn.API.Contracts.Requests;
using NeuroLearn.API.Enums;
using NeuroLearn.API.Models;
using NeuroLearn.API.Services.Interfaces;

namespace NeuroLearn.API.Services;

public class WordGenerationService: IWordGenerationService
{
    public List<GeneratedWord> GenerateWords(CreatePuzzleRequest request)
    {
        return [
            new GeneratedWord
            {
                Answer = "ROUTER",
                Clue = "Verbindet unterschiedliche Netzwerke",
            },
            new GeneratedWord
            {
                Answer = "SERVER",
                Clue = "Stellt anderen Geräten Dienste bereit",
            }
        ];
    }
}