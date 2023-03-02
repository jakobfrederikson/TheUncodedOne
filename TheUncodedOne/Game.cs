namespace TheUncodedOne
{
    public class Game
    {
        private Party _heroes { get; }
        private List<Party> _monsters { get; }
        private Party _currMonsters { get; set; } = new Party(new ComputerPlayer());

        public Game(Party heroes, List<Party> monsters)
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
            int monsterIndex = 0;
            while (true)
            {
                _currMonsters = _monsters.ElementAt(monsterIndex);
                foreach (Party party in new[] { _heroes, _currMonsters })
                {
                    foreach (Character c in party.Characters)
                    {
                        Console.WriteLine();
                        ColouredConsole.WriteLine($"It is {c.Name}'s turn...", ConsoleColor.Gray);
                        party.Player.ChooseAction(this, c).Run(this, c);

                        if (_monsters.ElementAtOrDefault(monsterIndex)?.Characters.Count == 0)
                        {
                            _monsters.Remove(_currMonsters);
                            if (_monsters.Count == 0) return;
                        }
                        else if (_heroes.Characters.Count == 0) return;
                    }
                }
            }
        }

        public Party GetPartyFor(Character character) => _heroes.Characters.Contains(character) ? _heroes : _currMonsters;
        public Party GetEnemyPartyFor(Character character) => _heroes.Characters.Contains(character) ? _currMonsters : _heroes;
        public void DisplayWinningMessage()
        {
            if (_heroes.Characters.Count > _currMonsters.Characters.Count)
                ColouredConsole.WriteLine("The Heroes have defeated The Uncoded One! The land is saved!", ConsoleColor.Green);
            else
                ColouredConsole.WriteLine("The Uncoded One has defeated The Heroes! The lands will continue to be ravaged by this beast!", ConsoleColor.Red);
        }
    }
}
