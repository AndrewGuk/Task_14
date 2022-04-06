namespace Types
{
    [AttributeUsage(AttributeTargets.All)]
    public class ValidateAtribute : Attribute
    {
        public string Pattern { get; set; }
        public ValidateAtribute(string pattern)
        {
            Pattern = pattern;
        }
    }
    public class People
    {
        [ValidateAtribute($"^[a-zA-Z]+$")]
        public string Name { get; set; }
        [ValidateAtribute($"^[a-zA-Z]+$")]
        public string LastName { get; set; }
        public int Age { get; set; }
        public People(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }
    }
}