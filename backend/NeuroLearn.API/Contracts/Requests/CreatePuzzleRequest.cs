using NeuroLearn.API.Enums;
using System.ComponentModel.DataAnnotations;

namespace NeuroLearn.API.Contracts.Requests;

public class CreatePuzzleRequest
{
    [Required(ErrorMessage = "Topic is required.")]
    [StringLength(100, MinimumLength = 3,
        ErrorMessage = "Topic must contain between 3 and 100 characters.")]
    public string Topic {get; set;} = string.Empty;
    [Required(ErrorMessage ="Laguage code is required.")]
    [RegularExpression(
        "^[a-zA-Z]{2}$",
        ErrorMessage ="Language code must contain exactly two letters.")]
    public string LanguageCode {get; set;} = string.Empty;

    [EnumDataType(
        typeof(Difficulty),
        ErrorMessage = "Difficulty is invalid.")]
    public Difficulty Difficulty {get; set;}

}