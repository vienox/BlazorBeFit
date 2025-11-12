using System.ComponentModel.DataAnnotations;

namespace BlazorBeFit.Models;

public class StartBeforeEndAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is TrainingSession session)
        {
            if (session.Start > session.End)
            {
                return new ValidationResult("Data rozpoczęcia musi być wcześniejsza niż data zakończenia.");
            }
        }

        return ValidationResult.Success;
    }
}
