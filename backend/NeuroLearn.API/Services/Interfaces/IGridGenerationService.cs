using NeuroLearn.API.Models;
using NeuroLearn.API.Services;

namespace NeuroLearn.API.Services.Interfaces;

public interface IGridGenerationService
{
    List<CrosswordEntry> PlaceWords(List<GeneratedWord> words);
}