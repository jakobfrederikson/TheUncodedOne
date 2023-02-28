namespace TheUncodedOne
{
    internal static class ColouredConsole
    {
        public static void WriteLine(string message, ConsoleColor color)
        {
            ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = previousColor;
        }

        public static void Write(string message, ConsoleColor color)
        {
            ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ForegroundColor = previousColor;
        }

        public static string Prompt(string question)
        {
            ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(question + " ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string input = Console.ReadLine() ?? " ";
            Console.ForegroundColor = previousColor;
            return input;
        }
    }
}
