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
