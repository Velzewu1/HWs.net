using Lesson1.Model;
using Lesson1;

namespace Lesson1
{
    public class Command
    {
        public static string AddElement(Fruit fruit)
        {
            try
            {
                Data.all.Add(Data.all.Count + 1, new Fruit(fruit.Name, fruit.Store));
                return $"element with name {fruit.Name} has been added under id {Data.all.Count + 1}.";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public static string PatchElement(int id, Fruit fruit)
        {
            try
            {
                if (Data.all.ContainsKey(id))
                {
                    Data.all[id] = fruit;
                    return $"element with id {id} has been patched.";
                }
                else
                {
                    return "there is no such element.";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public static string RemoveElement(int id)
        {
            try
            {
                if (Data.all.ContainsKey(id))
                {
                    Data.all.Remove(id);
                    return $"element with id {id} has been removed.";
                }
                else
                {
                    return "there is no such element.";
                }
            }
            catch (Exception e)
            {
                return e.Message; ;
            }
        }
    }
}
