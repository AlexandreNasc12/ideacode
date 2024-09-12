
using FluentValidation.Results;

namespace ideacode.api.core.Controllers;

public abstract class InputModel
{
    private ValidationResult ValidationResult { get; set; }

    protected InputModel()
    {
        ValidationResult = new ValidationResult();
    }

    public virtual bool EstaValido() => ValidationResult.IsValid;
    public void AtribuirValidation(ValidationResult validationResult) => ValidationResult = validationResult;
    public ValidationResult ObterValidationResult() => ValidationResult;
}
