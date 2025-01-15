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

            // Separare i nomi normali e urlati
            var normalNames = names.Where(name => name.ToUpper() != name).ToArray();
            var shoutedNames = names.Where(name => name.ToUpper() == name).ToArray();

            string normalGreeting = null;
            if (normalNames.Length > 0)
            {
                var allButLast = string.Join(", ", normalNames.Take(normalNames.Length - 1));
                var last = normalNames.Length > 1 ? $" and {normalNames.Last()}" : normalNames.First();
                normalGreeting = $"Hello, {allButLast}{last}.";
            }

            string shoutedGreeting = null;
            if (shoutedNames.Length > 0)
            {
                shoutedGreeting = $"AND HELLO {string.Join(" AND ", shoutedNames)}!";
            }

            if (!string.IsNullOrEmpty(normalGreeting) && !string.IsNullOrEmpty(shoutedGreeting))
            {
                return $"{normalGreeting} {shoutedGreeting}";
            }

            return normalGreeting ?? shoutedGreeting;
        }
    }
}
