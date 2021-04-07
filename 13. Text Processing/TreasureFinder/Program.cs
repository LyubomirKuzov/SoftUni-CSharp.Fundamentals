using System;
using System.Linq;
using System.Text;

namespace TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string text = Console.ReadLine();

                if (text == "find")
                {
                    break;
                }

                int keyIndex = 0;
                StringBuilder decryptedText = new StringBuilder();

                for (int i = 0; i < text.Length; i++)
                {
                    decryptedText.Append((char)(text[i] - key[keyIndex]));

                    keyIndex++;

                    if (keyIndex >= key.Length)
                    {
                        keyIndex = 0;
                    }
                }

                text = decryptedText.ToString().Trim();

                int typeStartIndex = text.IndexOf('&');
                int typeLastIndex = text.LastIndexOf('&'); 
                int coordinatesStartIndex = text.IndexOf('<');
                int coordinatesLastIndex = text.IndexOf('>');

                string type = text.Substring(typeStartIndex + 1, typeLastIndex - typeStartIndex - 1);
                string coordinates = text.Substring(coordinatesStartIndex + 1, 
                    coordinatesLastIndex - coordinatesStartIndex - 1);

                Console.WriteLine($"Found {type} at {coordinates}");
            }
        }
    }
}
