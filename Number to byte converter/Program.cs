using System;
using TextCopy;
namespace NumToByte
{
    internal class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Please enter a numeric data type to convert to bytes:");
            string? buffer = Console.ReadLine();

            NumericToByte bytes = new NumericToByte();

            if (buffer is not null)
            {
                buffer = await bytes.ConvertNumericToByteAsync(buffer);
            }
            if (buffer != "Invalid entry" && buffer is not null)
            {
                Console.WriteLine();
                Console.WriteLine("Bytes: " + buffer);
                Clipboard clipboard = new Clipboard();
                clipboard.SetText(buffer);
                Console.WriteLine();
                Console.WriteLine("Copied to clipboard.");
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }

            Console.WriteLine();
            await Main();
        }
    }
}