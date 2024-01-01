namespace WellnessBingo
{
    internal class Program
    {
        static bool IsFinished = false;
        static void Main(string[] args)
        {
            Menu UserMenu = new Menu();
            RandomGenerator Generator = new RandomGenerator();
            Storage storage = new Storage();
            Prompt prompt = new Prompt();
            while (!IsFinished)
            {
                Greet();
                UserMenu.UserMenu();
                Generator.GenerateElement(storage.BingoElements, UserMenu.currentSelected);
                Console.WriteLine("Today you shall... " + Generator.GeneratedActivity);
                IsFinished = UserMenu.isSelected;
                Goodbye();
                // prompt.UserPrompt();
            }
        }
        static void Greet()
        {
            Console.WriteLine($"Welcome to the Welness Bingo!\nChoose options by using ⬆️ / ⬇️");
        }

        static void Goodbye()
        {
            Console.WriteLine("Thank you for playing.");
        }
    }
}