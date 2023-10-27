using FluentValidation;

namespace graphQLDemo.Mutations
{
    public class CreateUserInputValidator : AbstractValidator<CourseInputType>
    {
        public CreateUserInputValidator()
        {
            RuleFor(input => input.name).NotEmpty().WithMessage("Username is required.");
        }
    }
}
