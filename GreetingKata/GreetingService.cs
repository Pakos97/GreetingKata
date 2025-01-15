public class GreetingService
{
    public string GreetMultiple(string[] names)
    {
        if (names == null || names.Length == 0)
        {
            return "Hello, my friend.";
        }

        var allNames = new List<string>();

        // Gestiamo i casi dove il nome potrebbe essere null
        foreach (var name in names)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                continue; // Se il nome è null o vuoto, lo ignoriamo
            }

            if (name.Contains("\""))
            {
                var nameWithoutQuotes = name.Trim('"');
                allNames.Add(nameWithoutQuotes);
            }
            else if (name.Contains(","))
            {
                var splitNames = name.Split(',').Select(n => n.Trim()).ToArray();
                allNames.AddRange(splitNames);
            }
            else
            {
                allNames.Add(name);
            }
        }

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
            shoutedGreeting = $"HELLO {string.Join(" AND ", shoutedNames)}!";
        }

        if (!string.IsNullOrEmpty(normalGreeting) && !string.IsNullOrEmpty(shoutedGreeting))
        {
            return $"{normalGreeting} {shoutedGreeting}";
        }

        return normalGreeting ?? shoutedGreeting;
    }
}
