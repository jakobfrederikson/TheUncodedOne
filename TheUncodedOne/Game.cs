namespace TheUncodedOne
{
    public class Game
    {
        private Party _heroes { get; }
        private Party _monsters { get; }

        public Game(Party heroes, Party monsters)
        {
            _heroes = heroes;
            _monsters = monsters;
        }

        public void Run()
        {
            while (true)
            {
                foreach (Party party in new[] {_heroes, _monsters})
                {
                    foreach (Character c in party.Characters)
                    {
                        Console.WriteLine();
                        ColouredConsole.WriteLine($"It is {c.Name}'s turn...", ConsoleColor.Gray);
                        Thread.Sleep(500);
                        c.TakeTurn(GetAction(c));
                    }
                }
            }
        }

        private Action GetAction(Character c)
        {
            int input = 0;
            if (c.PlayerType == PlayerType.Human)
                input = Convert.ToInt32(ColouredConsole.Prompt("What action would you like to perform? (1. Do Nothing)"));
            else
                input = 1;

            return (input) switch
            {
                _ => () => Console.WriteLine($"{c.Name} did NOTHING.")
            };
        }
    }
}
