using System;
using System.Reflection;
using System.Text.RegularExpressions;
using Types;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            var people1 = new People("Andrew", "hud", 1544);
            var people2 = new People("андрей", "хзхз", 18);
            Console.WriteLine(ValidateString(people1));
            Console.WriteLine(ValidateString(people2));

            Console.ReadLine();
        }
        static string ValidateString(People people)
        {
            Type t = typeof(People);
            PropertyInfo[] properties = t.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            string resault = string.Empty;
            foreach (PropertyInfo property in properties)
            {
                foreach (ValidateAtribute attr in property.GetCustomAttributes(false))
                {
                    if (Regex.IsMatch(people.Name, attr.Pattern) && Regex.IsMatch(people.LastName, attr.Pattern))
                        resault = "Data is correct!";
                    else
                        resault = "Data is not correct!";
                }
            }
            return resault;
        }
    }
}