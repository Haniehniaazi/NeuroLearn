using Microsoft.AspNetCore.Mvc;
using NeuroLearn.API.Contracts.Requests;
using NeuroLearn.API.Models;
using NeuroLearn.API.Services.Interfaces;

namespace NeuroLearn.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CrosswordController : ControllerBase
{
    private readonly ICrosswordService _crosswordService;

    public CrosswordController(ICrosswordService crosswordService)
    {
        _crosswordService = crosswordService;
    }

    [HttpPost]
    public ActionResult<CrosswordPuzzle> CreatePuzzle(
        [FromBody] CreatePuzzleRequest request)
    {
        CrosswordPuzzle puzzle = _crosswordService.CreatePuzzle(request);

        return Ok(puzzle);
    }
}