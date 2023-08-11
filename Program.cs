namespace Terningen
{
    internal class Program
    {
        static void Main()
        {
            // Afventer input
            Console.WriteLine("Press any key to roll dice.");
            Console.ReadKey();
            Console.Clear();

            // Instantierer tilfældig generator
            Random random = new Random();
            int dice = random.Next(1, 7);

            // Kontrolstruktur
            switch (dice)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You rolled a {dice}!");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"You rolled a {dice}!");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"You rolled a {dice}!");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You rolled a {dice}!");
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"You rolled a {dice}!");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"You rolled a {dice}!");
                    break;
            }

            // Afventer at gå tilbage
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
            Main();
        }
    }
}