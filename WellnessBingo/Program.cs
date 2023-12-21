namespace WellnessBingo
{
    internal class Program
    {
        static string AppName = "WellnessBingo";
        static string[] elements = { "December", "November", "October", "September", "July", "June", "National Wellness Month!" };
        static string[] december = { "Go ice skating", "Dance to holiday music", "Let go of an old habit", "Create homemade decorations", "Track your water intake", "Build a snowman", "Do a random act of kindness", "Get 10,000 steps in a day", "Bake cookies", "Mail someone a letter", "Practice breathing exercises", "Shop at a small business", "Snuggle in a blanket", "Write a resolution for 2024", "Sit by a fire", "Get yourself a small gift", "Read a chapter of a book", "Volunteer your time", "Be present", "Make a gingerbread house", "Journal your feelings", "Watch a holiday movie", "Have a cozy day" };
        static string[] november = { "Clean an area of clutter", "Make a pot of soup", "Visit your local library", "Create a vision board", "Write down 3 things you're grateful for", "Bake a pie", "Host a game night", "Go on a scenic drive", "Compliment a stranger", "Enjoy a holiday beverage", "Jump in a pile of leaves", "Go to a farmer's market", "Slow down and enjoy the moment", "Wear fuzzy socks", "Give yourself a hug", "Make someone laugh", "Don't sweat the small stuff", "Take photos in nature", "Have a bonfire", "Don't compare yourself to others", "Take 5 deep breaths", "Spend time with animals", "Try a new skill or balance", "Enjoy a cozy night in" };
        static string[] october = { "Light (or buy) a candle", "Enjoy a cozy night in", "Write down what you're grateful for", "Call a loved one", "Take a scenic hike", "Go to a farmer's market", "Don't sweat the small stuff", "Go apple picking", "Host a game night", "Compliment a stranger", "Take 5 deep breaths", "Do a meditation outdoors", "Carve a pumpkin", "Give yourself a hug", "Bake a pie", "Declutter your closet", "Enjoy a fall beverage", "Host a book club", "Listen to the campfire sleep sound", "Watch a classic fall movie", "Make someone laugh", "Jump in a pile of leaves", "Visit a pumpkin patch", "Go on a picnic" };
        static string[] september = { "Attend a local event", "Have a picnic", "Do a random act of kindness", "Work out with a friend", "Meal prep for the week", "Get an extra hour of sleep", "Have a social media-free day", "Stretch", "Get 10,000 steps in a day", "Write out your priorities", "Get some sunshine", "Clean your home", "Practice saying affirmations", "Listen to a podcast", "Hike with a friend", "Start a gratitude journal", "Do your skincare routine", "Check in with family", "Cook a new recipe", "Challenge negative thoughts", "Listen to music", "Light a candle", "Set an intention", "Be proud of yourself" };
        static string[] july = { "Eat your favorite dessert", "Have a picnic", "Try a new exercise", "Get some sunshine", "Create a summer bucket list", "Volunteer your time", "Stargaze", "Go to a farmer's market", "Take a bike ride", "Treat yourself to ice cream", "Do an art project", "Take a walk on a new trail", "Make a vision board", "Take a day trip to a beach", "Buy yourself flowers", "Clean your home", "Meditate for 10 minutes", "Relax in a hammock", "Host a BBQ with loved ones", "Take a digital detox day", "Start a beach read", "Say 'I love you' to yourself", "Do one thing you've been putting off", "Get 10,000 steps in a day" };
        static string[] june = { "Plan a road trip", "Build a relaxing evening routine", "Read a chapter in your book", "Meditate for 10 minutes before bed", "Wash your bedding and sheets", "Soak your feet in an Epsom salt bath", "Take 5 deep breaths", "Drink chamomile tea before bed", "Try a new sleep journey", "Enjoy a cozy night in", "Set your thermostat between 60-67°F", "Get 8 hours of sleep", "Make your bed", "Wear your favorite pajamas", "Diffuse lavender oil", "Create a 'wind down' playlist", "Treat yourself to a new pillow or blanket", "Do some gentle stretching or yoga", "Relax in a park", "Go to bed early", "Have a phone-free evening", "Do your skincare routine", "Journal before bed", "Get some morning sunshine" };
        static string[] nationalWellnessMonth = { "Light a candle", "Treat yourself to a delicious meal", "Go for a nature walk", "Have a 'no phone' day", "Read a chapter of a book", "Do a crossword puzzle", "Spend time in the sun", "Do your skincare routine", "Spend the day at the park", "Set an intention", "Listen to an inspirational podcast", "Write a letter to your future self", "Go to bed early", "Buy yourself a coffee or tea", "Try a new exercise", "Look at pictures of baby animals", "Do an art project", "Make yourself laugh", "Say 3 things you love about yourself", "Stretch", "Have a DIY spa day", "Create your own affirmation", "Do a breathing exercise", "Stay in for a night", "Call a friend or loved one" };

        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to the {AppName}!");
            string[] months = elements;
            Console.WriteLine("Choose using up and down arrows: ");
            Menu userMenu = new Menu(months);
            RandomGenerator generator = new RandomGenerator();
            userMenu.RenderMenu();
            userMenu.ToNextElement();
            bool isFinished = false;
            while (!isFinished)
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (userMenu.Counter() == months.Length)
                        {
                            userMenu.UpdateCounter(0);
                        }
                        Console.Clear();
                        Console.WriteLine($"Welcome to the {AppName}!");
                        Console.WriteLine("Choose using up and down arrows: ");
                        userMenu.RenderMenu();
                        userMenu.ToNextElement();
                        break;
                    case ConsoleKey.UpArrow:
                        if (userMenu.Counter() == 0)
                        {
                            userMenu.UpdateCounter(months.Length - 1);
                        }
                        else
                        {
                            userMenu.ToPreviousElement();
                        }
                        Console.Clear();
                        Console.WriteLine($"Welcome to the {AppName}");
                        Console.WriteLine("Choose using up and down arrows: ");
                        userMenu.RenderMenu();
                        break;
                    case ConsoleKey.Enter:
                        string currentSelected = userMenu.SelectedElement();
                        switch (currentSelected)
                        {
                            case "December":
                                string a = generator.Generate(december);
                                Console.WriteLine($"Today I suggest you go and... {a}!");
                                break;
                            case "November":
                                string b = generator.Generate(november);
                                Console.WriteLine($"Today I suggest you go and... {b}!");
                                break;
                            case "October":
                                string c = generator.Generate(october);
                                Console.WriteLine($"Today I suggest you go and... {c}!");
                                break;
                            case "September":
                                string d = generator.Generate(september);
                                Console.WriteLine($"Today I suggest you go and... {d}!");
                                break;
                            case "July":
                                string e = generator.Generate(june);
                                Console.WriteLine($"Today I suggest you go and... {e}!");
                                break;
                            case "June":
                                string f = generator.Generate(july);
                                Console.WriteLine($"Today I suggest you go and... {f}!");
                                break;
                            case "National Wellness Month!":
                                string g = generator.Generate(nationalWellnessMonth);
                                Console.WriteLine($"Today I suggest you go and... {g}!");
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                
            }
        }
    }
}