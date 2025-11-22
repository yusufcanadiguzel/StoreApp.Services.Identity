namespace StoreApp.Services.Identity.Application.Constants.Messages;

public static class MagicStrings
{
    // User Validation Messages
    public const string UserFirstNameNotEmpty = "First name must not be empty.";
    public const string UserLastNameNotEmpty = "Last name must not be empty.";
    public const string UserUsernameNotEmpty = "Username must not be empty.";
    public const string UserUsernameLength = "Username must be between 3 and 50 characters.";
    public const string UserEmailNotEmpty = "Email must not be empty.";
    public const string UserEmailInvalid = "Email must be a valid email address.";
    public const string UserPasswordNotEmpty = "Password must not be empty.";
    public const string UserPasswordLength = "Password must be at least 6 characters long.";
    public const string UserPasswordDigit = "Password must contain at least one digit.";
    public const string UserPasswordLowercase = "Password must contain at least one lowercase letter.";
    public const string UserPasswordUppercase = "Password must contain at least one uppercase letter.";
}
