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
                        party.Player.ChooseAction(this, c).Run(this, c);
                    }
                }
            }
        }
    }
}
