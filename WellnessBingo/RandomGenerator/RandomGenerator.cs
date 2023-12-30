using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellnessBingo
{
    public class RandomGenerator
    {
        public string generatedActivity = string.Empty;
        public void GenerateElement(Dictionary<string, string[]> elements, string element) {
            Random random = new Random();
            if(elements.ContainsKey(element)){
                string[] result = elements[element];
                int randomIndex = random.Next(0, result.Length);
                generatedActivity = result[randomIndex];
            }
        }
    }
}
