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
            Battle();
            DisplayWinningMessage();
        }

        public void Battle()
        {
            while (true)
            {
                foreach (Party party in new[] { _heroes, _monsters })
                {
                    foreach (Character c in party.Characters)
                    {
                        Console.WriteLine();
                        ColouredConsole.WriteLine($"It is {c.Name}'s turn...", ConsoleColor.Gray);
                        party.Player.ChooseAction(this, c).Run(this, c);

                        if (GetEnemyPartyFor(c).Characters.Count == 0) return;
                    }
                }
            }
        }

        public Party GetPartyFor(Character character) => _heroes.Characters.Contains(character) ? _heroes : _monsters;
        public Party GetEnemyPartyFor(Character character) => _heroes.Characters.Contains(character) ? _monsters : _heroes;
        public void DisplayWinningMessage()
        {
            if (_heroes.Characters.Count > _monsters.Characters.Count)
                ColouredConsole.WriteLine("The Heroes have defeated The Uncoded One! The land is saved!", ConsoleColor.Green);
            else
                ColouredConsole.WriteLine("The Uncoded One has defeated The Heroes! The lands will continue to be ravaged by this beast!", ConsoleColor.Red);
        }
    }
}
