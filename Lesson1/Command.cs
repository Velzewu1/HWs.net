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
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public static string AddElement(Product product)
        {
            try
            {
                Data.all.Add(Data.all.Count + 1, new Product(product.Name, product.Price, product.Stock));
                return $"element with name {product.Name} has been added under id {Data.all.Count + 1}.";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public static string PatchElement(int id, Product Product)
        {
            try
            {
                if (Data.all.ContainsKey(id))
                {
                    Data.all[id] = Product;
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
