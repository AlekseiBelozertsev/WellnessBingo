namespace WellnessBingo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu userMenu = new Menu();
            RandomGenerator generator = new RandomGenerator();
            Greet();
            userMenu.UserMenu();
        }

        static void Greet() {
            Console.WriteLine($"Welcome to the Welness Bingo!");
            Console.WriteLine("Choose using up and down arrows: ");
        }
    }
}