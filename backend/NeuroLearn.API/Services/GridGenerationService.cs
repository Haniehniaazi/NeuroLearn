using NeuroLearn.API.Models;
using NeuroLearn.API.Services;
using NeuroLearn.API.Services.Interfaces;

namespace NeuroLearn.API.Services;

public class GridGenerationService: IGridGenerationService
{
    public List<CrosswordEntry> PlaceWords(List<GeneratedWord> words)
    {
        return [];
    }
}