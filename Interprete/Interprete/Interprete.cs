using Interprete.Menu;
using Interprete.Source;
using System;
using System.Text;

namespace Interprete
{
    public class Interprete
    {
        static void Main(string[] args)
        {
            //menu del interprete
            StartMenu menu = new StartMenu();
            menu.GetMenu();

            //pidiendo cadena de entrada
            string inputAux = string.Empty;
            StringBuilder input = new StringBuilder();

            for(; ;)
            {
                Console.Write("\n>>");
                inputAux = Console.ReadLine().ToString();
                Scanner scanner = new Scanner();
                input.Append(inputAux);
                scanner.ScannerInput(input);               //scanenado datos de entrada
            }
            
        }
    }
}
