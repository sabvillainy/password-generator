using System;
using System.Threading;
class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Password Generator 2000");
        string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789?*_-";
        Random random = new Random();
        int passwordLength = random.Next(6, 13);
        Console.WriteLine("Password length is set to " + passwordLength + ".");
        Console.WriteLine("Generating your password...");
        Thread.Sleep(5000);
        string password = "";
        for (int i = 0; i < passwordLength; i++)
        {
            char randomChar = chars[random.Next(chars.Length)];
            password = password + randomChar;
            Console.WriteLine(randomChar);
            Thread.Sleep(1000);
        }
        Console.WriteLine(password);
        if (passwordLength >= 10)
        {
            Console.WriteLine("The generated password is strong.");
        }
        else if (passwordLength >= 8 && passwordLength <= 9)
        {
            Console.WriteLine("The generated password is intermediate.");
        }
        else
        {
            Console.WriteLine("The generated password is weak.");
        }
        Console.ReadKey();
    }
}
