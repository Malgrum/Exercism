static class LogLine
{
    public static string Message(string logLine)
    {
         // On coupe la chaîne en deux morceaux autour de ":"
        string[] parts = logLine.Split(':', 2);

        // Le message est la deuxième partie (index 1)
        // On enlève les espaces et retours à la ligne avec Trim()
        return parts[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
    
        // On trouve l'index du premier '[' et du premier ']'
        int start = logLine.IndexOf('[') + 1;
        int end = logLine.IndexOf(']');

        // On récupère ce qu’il y a entre les deux
        string level = logLine.Substring(start, end - start);

        // On renvoie en minuscule
        return level.ToLower();

    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
