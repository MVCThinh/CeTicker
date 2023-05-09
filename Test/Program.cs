


class Program
{
    static string DecryptPassword(string encryptedPassword)
    {
        if (string.IsNullOrEmpty(encryptedPassword))
        {
            return "";
        }
        byte[] passByteData = Convert.FromBase64String(encryptedPassword);
        string originalPassword = System.Text.Encoding.Unicode.GetString(passByteData);
        return originalPassword;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(DecryptPassword("cAB2AHEAcAB2AHEA"));
    }
}

