using System.ComponentModel.DataAnnotations;

namespace BlazorBeFit.Models;

[StartBeforeEnd]
public class TrainingSession
{
    public int Id { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime Start { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime End { get; set; }

    // Navigation property
    public ICollection<TrainingEntry>? Entries { get; set; }
}
