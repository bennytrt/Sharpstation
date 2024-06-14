using SharpStation;
using System;

namespace SharpStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting PlayStation 1 Emulator...");

            Emulator emulator = new Emulator();

            Console.WriteLine("Enter the path to the ROM file:");
            string romPath = Console.ReadLine();

            if (!string.IsNullOrEmpty(romPath))
            {
                emulator.LoadROM(romPath);
                emulator.Start();
            }
            else
            {
                Console.WriteLine("No ROM path provided. Exiting...");
            }
        }
    }
}
