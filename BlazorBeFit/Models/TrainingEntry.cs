using System.ComponentModel.DataAnnotations;

namespace BlazorBeFit.Models;

public class TrainingEntry
{
    public int Id { get; set; }

    [Required]
    public int ExerciseTypeId { get; set; }
    public ExerciseType? ExerciseType { get; set; }

    [Required]
    public int TrainingSessionId { get; set; }
    public TrainingSession? TrainingSession { get; set; }

    // Obciążenie w kg
    [Range(0, 1000)]
    public double Weight { get; set; }

    // Liczba serii
    [Range(1, 100)]
    public int Sets { get; set; }

    // Liczba powtórzeń w serii
    [Range(0, 1000)]
    public int Repetitions { get; set; }
}
