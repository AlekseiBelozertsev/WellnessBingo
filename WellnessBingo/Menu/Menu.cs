using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellnessBingo
{
    public class Menu
    {
        static string[] elements;
        static int counter = 0;
        static string currentSelected;

        public Menu(string[] inputElements)
        {
            elements = inputElements;
        }
        public void RenderMenu()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (i == counter)
                {
                    Console.ForegroundColor = ConsoleColor.White; // Set the highlight color
                    Console.BackgroundColor = ConsoleColor.Blue;  // Set the background color if needed
                    Console.WriteLine($"> {elements[i]}");
                    currentSelected = elements[i];
                    Console.ResetColor(); // Reset colors to default
                }
                else
                {
                    Console.WriteLine($"> {elements[i]}");
                }
            }
        }

        public string SelectedElement()
        {
            return currentSelected;
        }

        public int Counter()
        {
            return counter;
        }

        public void UpdateCounter(int arg)
        {
            counter = arg;
        }
        public void ToNextElement()
        {
            counter++;
        }
        public void ToPreviousElement()
        {
            counter--;
        }
    }
}
