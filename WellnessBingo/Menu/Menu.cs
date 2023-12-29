using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WellnessBingo
{
    public class Menu
    {
        private readonly string[] elements = { "December", "November", "October", "September", "July", "June", "National Wellness Month!" };
        private int counter = 0;
        private bool isSelected = false;
        public string currentSelected = string.Empty;

        private ConsoleKey pressedKey;

        public void UserMenu()
        {
            (int left, int top) = Console.GetCursorPosition();
            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);
                RenderMenu();
                SetConsoleKey();
                NavigateMenu();
                SelectElement();
            }
        }
        public void RenderMenu()
        {
            string currentOption = "✅ \u001b[32m";
            for (int i = 0; i < elements.Length; i++)
            {
                if (i == counter)
                {
                    Console.WriteLine($"{currentOption}{elements[i]}");
                    currentSelected = elements[i];
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"   {elements[i]}");
                }
            }
        }

        public void NavigateMenu()
        {
            switch (pressedKey)
            {
                case ConsoleKey.DownArrow:
                    if (counter == elements.Length - 1)
                    {
                        UpdateCounter(0);
                    }
                    else
                    {
                        Navigate("next");
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (counter == 0)
                    {
                        UpdateCounter(elements.Length - 1);
                    }
                    else
                    {
                        Navigate("prev");
                    }
                    break;
            }
        }
        private void UpdateCounter(int arg)
        {
            counter = arg;
        }

        public void SetConsoleKey() {
            ConsoleKeyInfo cki = Console.ReadKey(true);
            pressedKey = cki.Key;
        }

        public void SelectElement() {
            if(pressedKey == ConsoleKey.Enter) {
                currentSelected = elements[counter];
                isSelected = true;
            }
        }
        private void Navigate(string nav)
        {
            if (nav == "prev")
            {
                counter--;
            }
            else if (nav == "next")
            {
                counter++;
            }
        }

    }
}
