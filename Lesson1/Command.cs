using Lesson1.Model;
using Lesson1;

namespace Lesson1
{
    public class Command
    {
        public static object GetElement(int id)
        {
            try
            {
                return Data.all[id];
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
        public static string AddElement(Chore chore)
        {
            try
            {
                Data.all.Add(Data.all.Count + 1, new Chore(chore.Name, chore.Desc, chore.IsCompleted));
                return $"element with name {chore.Name} has been added under id {Data.all.Count}.";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public static string PatchElement(int id, Chore chore)
        {
            try
            {
                if (Data.all.ContainsKey(id))
                {
                    Data.all[id] = chore;
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
