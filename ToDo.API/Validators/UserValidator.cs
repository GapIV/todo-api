namespace ToDo.API.Validators;

public class UserValidator : AbstractValidator<UserViewModel>
{
    public UserValidator()
    {
        RuleFor(u => u.Email)
            .EmailAddress()
            .MaximumLength(30);
        RuleFor(u => u.Password)
            .MaximumLength(50);
        RuleFor(u => u.UserName)
            .MaximumLength(30);
    }
}
