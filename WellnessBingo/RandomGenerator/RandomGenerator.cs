using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellnessBingo
{
    public class RandomGenerator
    {
        public string GeneratedActivity = string.Empty;
        public void GenerateElement(Dictionary<string, string[]> Elements, string Element) {
            Random random = new Random();
            if(Elements.ContainsKey(Element)){
                string[] result = Elements[Element];
                int randomIndex = random.Next(0, result.Length);
                GeneratedActivity = result[randomIndex];
            }
        }
    }
}
