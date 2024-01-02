using System.Reflection.Emit;

namespace WellnessBingo
{
    internal class Program
    {
        private bool isFinished = false;

        private string arrowIcons = "⬆️ / ⬇️";
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            Menu userMenu = new Menu();
            RandomGenerator generator = new RandomGenerator();
            Storage storage = new Storage();

            while (!isFinished)
            {
                Greet();
                userMenu.UserMenu();
                generator.GenerateElement(storage.BingoElements, userMenu.CurrentSelected);
                ShowResult(generator.GeneratedActivity);
                SetIsFinished(userMenu.IsSelected);
                Goodbye();
            }
        }
        private void Greet()
        {
            Console.WriteLine($"Welcome to the Welness Bingo!\nChoose options by using {arrowIcons}");
        }

        private void ShowResult(string result)
        {
            Console.WriteLine($"Today you shall... {result}.");
        }

        private void SetIsFinished(bool isOptionSelected)
        {
            isFinished = isOptionSelected;
        }

        private void Goodbye()
        {
            Console.WriteLine("See you next time.");
        }
    }
}