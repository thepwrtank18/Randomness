using Microsoft.CodeAnalysis.CSharp.Scripting;
using System.Net;

namespace Randomness
{
    internal class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Note that the following code could be written by *anyone*.");
            Console.WriteLine("You can find the code by going to https://github.com/thepwrtank18/Randomness/code.txt.");
            Console.WriteLine("By continuing, you agree that you are responsible for anything ran.");
            Console.ReadKey();

            while (true)
            {
                WebClient client = new();
                string code = client.DownloadString("https://raw.githubusercontent.com/thepwrtank18/Randomness/master/code.txt");

                await CSharpScript.RunAsync(code);
            }
        }
    }
}