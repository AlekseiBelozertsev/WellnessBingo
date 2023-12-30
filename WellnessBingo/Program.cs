namespace WellnessBingo
{
    internal class Program
    {
        static bool isFinished = false;
        static void Main(string[] args)
        {
            Menu userMenu = new Menu();
            RandomGenerator generator = new RandomGenerator();
            Storage storage = new Storage();
            Prompt prompt = new Prompt();
            while (!isFinished)
            {
                Greet();
                userMenu.UserMenu();
                generator.GenerateElement(storage.BingoElements, userMenu.currentSelected);
                Console.WriteLine("Today you shall... " + generator.generatedActivity);
                // prompt.UserPrompt();

            }
        }
        static void Greet()
        {
            Console.WriteLine($"Welcome to the Welness Bingo!");
            Console.WriteLine("Choose using up and down arrows: ");
        }
    }
}