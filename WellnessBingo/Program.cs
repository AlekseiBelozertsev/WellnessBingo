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
                Console.Clear();
                Greet();
                userMenu.UserMenu();
                generator.GenerateElement(storage.BingoElements, userMenu.CurrentSelected);
                ShowResult(generator.GeneratedActivity);
                ConfirmIsFinished();
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

        private void ConfirmIsFinished() {
            System.Console.Write("Do you wish to proceed? (Y/N): ");
            string result = Console.ReadLine();
            if (result == "Y") {
                
                Run();
            } else if (result == "N") {
                SetIsFinished(true);
                Goodbye();
            } else {
                System.Console.WriteLine("Type Y for proceed in the game and N to quit.");
            }
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