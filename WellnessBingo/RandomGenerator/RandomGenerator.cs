using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellnessBingo
{
    public class RandomGenerator
    {
        //static string[] elements;
        //public RandomGenerator(string[] inputElements) {
        //    elements = inputElements;
        //}
        public string Generate(string[] elements) {
            Random random = new Random();
            int i = random.Next(0, elements.Length);
            string randomElement = elements[i];
            return randomElement;
        }
    }
}
