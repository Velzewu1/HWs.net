namespace Lesson1.Model
{
    public class Chore
    {
        public string Name { get; set; }
        public string? Desc { get; set; }
        public bool IsCompleted { get; set; }

        public Chore(string? name, string? desc, bool isCompleted)
        {
            Name = name;
            Desc = desc;
            IsCompleted = isCompleted;
        }
    }
}
