using System;
using Figgle;

namespace ObrigadoDevCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(FiggleFonts.Big.Render("Obrigado,"));
            Console.WriteLine(FiggleFonts.Crazy.Render("Dev C# !"));
            Console.ResetColor();
            Console.Write("Pressione uma tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
