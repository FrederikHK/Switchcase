using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchcaseAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //A switchcase, which depending on your choice calculates from one numeric system to another, 
            //example: from the 10 number system, to the 16 number system(Hexidecimal), and the 2 number system (Binary)
            //Opgave 6
            bool loop = true;
            do
            {
                Console.WriteLine("Vælg din inputs type");
                Console.WriteLine("Vælg 'a' for at lave input i decimal");
                Console.WriteLine("Vælg 'b' for at lave input i hexidecimal");
                Console.WriteLine("Vælg 'c' for at lave input i bin");
                Console.WriteLine("Vælg 'q' for at afslutte");
                string svar = Console.ReadLine();

                switch (svar)
                {
                    case "a":
                        Console.Write("Skriv dit decimaltal: ");
                        decimal deciSvar = Convert.ToDecimal(Console.ReadLine());
                        int rundTilHel = (int)Math.Round(deciSvar, 0);
                        string lavTilBin = Convert.ToString(rundTilHel, 2).PadLeft(8, '0');
                        string lavTilHex = rundTilHel.ToString("X");
                        Console.WriteLine("Svarene er:");
                        Console.WriteLine("Til Heltal: " + rundTilHel);
                        Console.WriteLine("Til Binært: " + lavTilBin);
                        Console.WriteLine("Til Hexidecimalt: " + lavTilHex);
                        break;

                    case "b":
                        Console.WriteLine("Skriv dit hexidecimale tal: ");
                        string hexiInput = Console.ReadLine();
                        int revertToHel = Convert.ToInt32(hexiInput, 16);
                        string lavTilBinary = Convert.ToString(revertToHel, 2).PadLeft(8, '0');
                        Console.WriteLine("Svarene er:");
                        Console.WriteLine("Til Heltal: " + revertToHel);
                        Console.WriteLine("Til Binært: " + lavTilBinary);
                        break;

                    case "c":
                        Console.WriteLine("Skriv dit Binære tal: ");
                        string binSvar = Console.ReadLine();
                        int fraBin = Convert.ToInt32(binSvar, 2);
                        string fraHelTilHex = fraBin.ToString("X");
                        Console.WriteLine("Svarene er:");
                        Console.WriteLine("Til Heltal: " + fraBin);
                        Console.WriteLine("Til Hexidecimalt tal: " + fraHelTilHex);
                        break;

                    case "q":
                        loop = false;
                        break;


                    default:
                        break;
                }
            } while (loop);
        }
    }
}
