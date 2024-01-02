namespace MstBlog.Service.Constants;

public class Messages
{
    // Common
    public static string USER_NOT_FOUND = "User not found in the system!";

    // Register Errors
    public static string DUPLICATE_USER_NAME = "This username is already in use by another user!";
    public static string DUPLICATE_EMAIL = "This email is already in use by another user!";
    public static string PASSWORD_TOO_SHORT = "Your password must be at least 6 characters long!";
    public static string PASSWORD_REQUIRES_LOWER = "Your password must contain at least 1 lowercase character!";

    // Login Errors
    public static string PASSWORD_WRONG = "Incorrect email or password!";

    // Update Password Errors
    public static string CURRENT_PASSWORD_WRONG = "Your current password is incorrect!";
    public static string PASSWORDS_NOT_MATCH = "The entered passwords do not match!";
    public static string PASSWORD_UPDATE_ERROR = "An error occurred during the password update process!";

    // Reset Password Errors
    public static string RESET_PASSWORD_WRONG = "Your verification code is incorrect!";

    // Ad Errors
    public static string AD_NOT_FOUND = "Ad not found!";

    // Subscribe Errors
    public static string SUBSCRIBE_EXIST = "Email is already registered!";
    
    // Post Errors
    public static string POST_NOT_FOUND = "Post not found!";
}