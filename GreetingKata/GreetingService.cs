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
            else if (name.ToUpper() == name)
            {
                return $"HELLO {name}!";
            }

            return $"Hello, {name}.";
        }

        public string GreetMultiple(string[] names)
        {
            // Unire i nomi separati da virgola e dividerli correttamente
            var allNames = new List<string>();

            foreach (var name in names)
            {
                // Se il nome contiene una virgola, separa il nome in più voci
                if (name.Contains(","))
                {
                    var splitNames = name.Split(',').Select(n => n.Trim()).ToArray();
                    allNames.AddRange(splitNames);
                }
                else
                {
                    allNames.Add(name);
                }
            }

            // Separare i nomi normali e urlati
            var normalNames = allNames.Where(name => name.ToUpper() != name).ToArray();
            var shoutedNames = allNames.Where(name => name.ToUpper() == name).ToArray();

            string normalGreeting = null;
            if (normalNames.Length > 0)
            {
                if (normalNames.Length == 1)
                {
                    normalGreeting = $"Hello, {normalNames[0]}.";
                }
                else if (normalNames.Length == 2)
                {
                    normalGreeting = $"Hello, {normalNames[0]} and {normalNames[1]}.";
                }
                else
                {
                    var allButLast = string.Join(", ", normalNames.Take(normalNames.Length - 1));
                    var last = normalNames.Last();
                    normalGreeting = $"Hello, {allButLast}, and {last}.";
                }
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
