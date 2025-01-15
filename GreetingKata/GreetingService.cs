using System;

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
            if (names.Length == 2)
            {
                return $"Hello, {names[0]} and {names[1]}.";
            }

            throw new NotImplementedException("Greet for more than 2 names is not implemented yet.");
        }
    }
}
