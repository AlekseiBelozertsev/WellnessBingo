using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellnessBingo
{
    public class RandomGenerator
    {
        private string generatedActivity = string.Empty;

        public string GeneratedActivity { get { return generatedActivity; } private set { generatedActivity = value; } }
        public void GenerateElement(Dictionary<string, string[]> Elements, string Element) {
            Random random = new Random();
            if(Elements.ContainsKey(Element)){
                string[] result = Elements[Element];
                int randomIndex = random.Next(0, result.Length);
                generatedActivity = result[randomIndex];
            }
        }
    }
}
