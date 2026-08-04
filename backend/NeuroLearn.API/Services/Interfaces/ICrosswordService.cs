using NeuroLearn.API.Contracts.Requests;
using NeuroLearn.API.Models;

namespace NeuroLearn.API.Services.Interfaces;

public interface ICrosswordService
{
    CrosswordPuzzle CreatePuzzle(CreatePuzzleRequest request);
}

