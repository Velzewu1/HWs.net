using Lesson1.Model;
using System.Xml.Linq;

namespace Lesson1
{
    public class Data
    {
        public static Dictionary<int, Fruit> all = new Dictionary<int, Fruit>() {
            {1, new Fruit("Banana", 400) },
            {2, new Fruit("Apple", 200) }
        };
    }
}
