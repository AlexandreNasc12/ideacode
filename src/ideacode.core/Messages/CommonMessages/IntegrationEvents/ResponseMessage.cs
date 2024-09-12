using FluentValidation.Results;

namespace ideacode.core.Messages.CommonMessages.IntegrationEvents
{
    public class ResponseMessage : Message
    {
        public ValidationResult ValidationResult { get; set; }

        public ResponseMessage(ValidationResult validationResult)
        {
            ValidationResult = validationResult;
        }
    }
}