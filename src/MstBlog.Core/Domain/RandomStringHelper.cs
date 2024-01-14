namespace MstBlog.Core.Domain;

public static class RandomStringHelper
{
    public static string GenerateRandomString(int length)
    {
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        char[] randomChars = new char[length];

        for (int i = 0; i < length; i++)
        {
            randomChars[i] = chars[random.Next(chars.Length)];
        }

        return new string(randomChars);
    }
}