using System;
using System.Linq;

namespace GreetingKata
{
    public class GreetingService
    {
        public string Greet(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return "Hello, my friend.";
            }

            if (name.ToUpper() == name)
            {
                return $"HELLO {name}!";
            }

            return $"Hello, {name}.";
        }

        public string GreetMultiple(string[] names)
        {
            if (names.Length == 0)
            {
                return "Hello, my friend.";
            }

            if (names.Length == 2)
            {
                return $"Hello, {names[0]} and {names[1]}.";
            }

            // Join all names except the last with commas
            var allButLast = string.Join(", ", names.Take(names.Length - 1));
            var last = names.Last();

            return $"Hello, {allButLast}, and {last}.";
        }
    }
}
