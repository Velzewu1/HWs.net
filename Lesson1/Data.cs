using Lesson1;
using Lesson1.Model;
using System.Xml.Linq;

namespace Lesson1
{
    public class Data
    {
        public static Dictionary<int, Chore> all = new Dictionary<int, Chore>() {
            {1, new Chore("Twist", "You not rrrh rot Dot n dot n dot per rot Dot n not n dot per", true) },
            {2, new Chore("Pray", "Say your prays little one, don't forget my son to include everyone", true) },
            {3, new Chore("Hit the floor", "One minute you're on top", true) }
        };
    }
}
