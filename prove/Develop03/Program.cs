using System;

class Program
{
    static void Main(string[] args)
    {
        bool restart = true;
        while (restart)
        {
            string verse = "And what is it that ye shall hope for? Behold I say unto you that ye shall have hope through the atonement of Christ and the power of his resurrection, to be raised unto life eternal, and this because of your faith in him according to the promise.";
            Reference reference = new Reference("Moroni", 7, 41);
            Scripture scripture = new Scripture(reference, verse);

            while (!scripture.AllCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine($"Reference: {scripture.Reference.GetDisplayText()}");
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide a random word...");
                Console.ReadLine();
                scripture.HideRandomWords();
            }

            Console.Clear();
            Console.WriteLine($"Reference: {scripture.Reference.GetDisplayText()}");
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll words are hidden.");

            Console.WriteLine("\nDo you want to restart the scripture? (y/n)");
            string input = Console.ReadLine().Trim().ToLower();

            restart = (input == "y" || input == "yes");
        }
    }
}