using System.ComponentModel.DataAnnotations;

namespace BlazorBeFit.Models;

public class ExerciseType
{
    public int Id { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 2)]
    public string Name { get; set; } = null!;
}
