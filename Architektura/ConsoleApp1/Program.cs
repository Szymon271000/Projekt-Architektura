    using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

            string AX;
            string BX;
            string CX;
            string DX;

            Console.Write("Podaj zawartosc rejestru AX : ");
            AX = Console.ReadLine();

            Console.Write("Podaj zawartosc rejestru BX : ");
            BX = Console.ReadLine();

            Console.Write("Podaj zawartosc rejestru CX : ");
            CX = Console.ReadLine();

            Console.Write("Podaj zawartosc rejestru DX : ");
            DX = Console.ReadLine();

            

            string action;

            Console.WriteLine("MOVE OR EXCHANGE ?");
            action = Console.ReadLine();

            if (action == "MOVE")
            {
                Console.WriteLine("You have chosen MOVE");
                Console.WriteLine("What do you want to move?");
                Console.WriteLine("Insert the first register");
                string PierwszyRejestr = Console.ReadLine();
                Console.WriteLine("Insert the second register");
                string DrugiRejestr = Console.ReadLine();
                if (PierwszyRejestr == "AX" && DrugiRejestr == "BX")
                {
                    Console.WriteLine("After the command move: ");
                    Console.WriteLine($"AX: {AX}");
                    Console.WriteLine($"BX: {AX}");
                    Console.WriteLine($"CX: {CX}");
                    Console.WriteLine($"DX: {DX}");

                }
                if (PierwszyRejestr == "AX" && DrugiRejestr == "CX")
                {
                    Console.WriteLine("After the command move: ");
                    Console.WriteLine($"AX: {AX}");
                    Console.WriteLine($"BX: {BX}");
                    Console.WriteLine($"CX: {AX}");
                    Console.WriteLine($"DX: {DX}");

                }
                if (PierwszyRejestr == "AX" && DrugiRejestr == "DX")
                {
                    Console.WriteLine("After the command move: ");
                    Console.WriteLine($"AX: {AX}");
                    Console.WriteLine($"BX: {AX}");
                    Console.WriteLine($"CX: {CX}");
                    Console.WriteLine($"DX: {AX}");

                }
                if (PierwszyRejestr == "BX" && DrugiRejestr == "AX")
                {
                    Console.WriteLine("After the command move: ");
                    Console.WriteLine($"AX: {BX}");
                    Console.WriteLine($"BX: {BX}");
                    Console.WriteLine($"CX: {CX}");
                    Console.WriteLine($"DX: {DX}");

                }
                if (PierwszyRejestr == "BX" && DrugiRejestr == "CX")
                {
                    Console.WriteLine("After the command move: ");
                    Console.WriteLine($"AX: {AX}");
                    Console.WriteLine($"BX: {BX}");
                    Console.WriteLine($"CX: {BX}");
                    Console.WriteLine($"DX: {DX}");

                }
                if (PierwszyRejestr == "BX" && DrugiRejestr == "DX")
                {
                    Console.WriteLine("After the command move: ");
                    Console.WriteLine($"AX: {AX}");
                    Console.WriteLine($"BX: {BX}");
                    Console.WriteLine($"CX: {CX}");
                    Console.WriteLine($"DX: {BX}");
                }
                if (PierwszyRejestr == "CX" && DrugiRejestr == "AX")
                {
                    Console.WriteLine("After the command move: ");
                    Console.WriteLine($"AX: {CX}");
                    Console.WriteLine($"BX: {BX}");
                    Console.WriteLine($"CX: {CX}");
                    Console.WriteLine($"DX: {DX}");

                }
                if (PierwszyRejestr == "CX" && DrugiRejestr == "BX")
                {
                    Console.WriteLine("After the command move: ");
                    Console.WriteLine($"AX: {AX}");
                    Console.WriteLine($"BX: {CX}");
                    Console.WriteLine($"CX: {CX}");
                    Console.WriteLine($"DX: {DX}");

                }
                if (PierwszyRejestr == "CX" && DrugiRejestr == "DX")
                {
                    Console.WriteLine("After the command move: ");
                    Console.WriteLine($"AX: {AX}");
                    Console.WriteLine($"BX: {BX}");
                    Console.WriteLine($"CX: {CX}");
                    Console.WriteLine($"DX: {CX}");

                }
                if (PierwszyRejestr == "DX" && DrugiRejestr == "AX")
                {
                    Console.WriteLine("After the command move: ");
                    Console.WriteLine($"AX: {DX}");
                    Console.WriteLine($"BX: {BX}");
                    Console.WriteLine($"CX: {CX}");
                    Console.WriteLine($"DX: {DX}");

                }
                if (PierwszyRejestr == "DX" && DrugiRejestr == "BX")
                {
                    Console.WriteLine("After the command move: ");
                    Console.WriteLine($"AX: {AX}");
                    Console.WriteLine($"BX: {DX}");
                    Console.WriteLine($"CX: {CX}");
                    Console.WriteLine($"DX: {DX}");

                }
                if (PierwszyRejestr == "DX" && DrugiRejestr == "CX")
                {
                    Console.WriteLine("After the command move: ");
                    Console.WriteLine($"AX: {AX}");
                    Console.WriteLine($"BX: {BX}");
                    Console.WriteLine($"CX: {DX}");
                    Console.WriteLine($"DX: {DX}");

                }
            }

            else if (action == "EXCHANGE")
            {
                Console.WriteLine("You have chosen EXCHANGE");
                Console.WriteLine("What do you want to exchange?");
                Console.WriteLine("Insert the first register");
                string PierwszyRejestr = Console.ReadLine();
                Console.WriteLine("Insert the second register");
                string DrugiRejestr = Console.ReadLine();

                if (PierwszyRejestr == "AX" && DrugiRejestr == "BX" || PierwszyRejestr == "BX" && DrugiRejestr == "AX")
                {
                    Console.WriteLine("After the command exchange: ");
                    Console.WriteLine($"AX: {BX}");
                    Console.WriteLine($"BX: {AX}");
                    Console.WriteLine($"CX: {DX}");
                    Console.WriteLine($"DX: {DX}");
                }
                if (PierwszyRejestr == "AX" && DrugiRejestr == "CX" || PierwszyRejestr == "CX" && DrugiRejestr == "AX")
                {
                    Console.WriteLine("After the command exchange: ");
                    Console.WriteLine($"AX: {CX}");
                    Console.WriteLine($"BX: {BX}");
                    Console.WriteLine($"CX: {AX}");
                    Console.WriteLine($"DX: {DX}");
                }
                if (PierwszyRejestr == "AX" && DrugiRejestr == "DX" || PierwszyRejestr == "DX" && DrugiRejestr == "AX")
                {
                    Console.WriteLine("After the command exchange: ");
                    Console.WriteLine($"AX: {DX}");
                    Console.WriteLine($"BX: {BX}");
                    Console.WriteLine($"CX: {CX}");
                    Console.WriteLine($"DX: {AX}");
                }
                if (PierwszyRejestr == "BX" && DrugiRejestr == "CX" || PierwszyRejestr == "CX" && DrugiRejestr == "BX")
                {
                    Console.WriteLine("After the command exchange: ");
                    Console.WriteLine($"AX: {AX}");
                    Console.WriteLine($"BX: {CX}");
                    Console.WriteLine($"CX: {BX}");
                    Console.WriteLine($"DX: {DX}");
                }
                if (PierwszyRejestr == "BX" && DrugiRejestr == "DX" || PierwszyRejestr == "DX" && DrugiRejestr == "BX")
                {
                    Console.WriteLine("After the command exchange: ");
                    Console.WriteLine($"AX: {AX}");
                    Console.WriteLine($"BX: {DX}");
                    Console.WriteLine($"CX: {CX}");
                    Console.WriteLine($"DX: {BX}");
                }
                if (PierwszyRejestr == "CX" && DrugiRejestr == "DX" || PierwszyRejestr == "DX" && DrugiRejestr == "CX")
                {
                    Console.WriteLine("After the command exchange: ");
                    Console.WriteLine($"AX: {AX}");
                    Console.WriteLine($"BX: {BX}");
                    Console.WriteLine($"CX: {DX}");
                    Console.WriteLine($"DX: {CX}");
                }
            }
        }
    }
}