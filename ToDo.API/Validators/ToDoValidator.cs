namespace ToDo.API.Validators;

public class ToDoValidator : AbstractValidator<ToDoViewModel>
{
    public ToDoValidator()
    {
        RuleFor(e => e.Title)
            .MaximumLength(50)
            .NotEmpty();
        RuleFor(e => e.Body)
            .MaximumLength(150);
    }
}
