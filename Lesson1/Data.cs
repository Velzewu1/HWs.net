using Lesson1;
using Lesson1.Model;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Lesson1
{
    public class Data
    {
        public static Dictionary<int, Product> all = new Dictionary<int, Product>() {
                {1, new Product("Corn", 20.1, 10) },
                {2, new Product("Metal", 30.5, 20) },
                {3, new Product("Park", 2000000, 2) }
        };
    }
}
