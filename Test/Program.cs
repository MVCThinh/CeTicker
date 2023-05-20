

using System.Reflection;

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
        //Console.WriteLine(DecryptPassword("cAB2AHEAcAB2AHEA"));
        //string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
        string PathRoot = @"C:\EQData1\Config\";
        string ConfigName = "\\VisionConfig.ini";
        string ecamName = "LoadingPre1";
        string path1 = Path.Combine(PathRoot,ecamName,ConfigName);
        Console.WriteLine("khong co cam dc ket noi \n\r Kiem tra lai IP Cam");
        
    }
}

