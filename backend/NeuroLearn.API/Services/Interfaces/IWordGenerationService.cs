using NeuroLearn.API.Contracts.Requests;
using NeuroLearn.API.Models;

namespace NeuroLearn.API.Services.Interfaces;

public interface IWordGenerationService
{
    List<GeneratedWord> GenerateWords(CreatePuzzleRequest request);
}