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
                        Console.WriteLine($"It is {c.Name}'s turn...");
                        Thread.Sleep(500);
                        c.TakeTurn(GetAction(c));
                    }
                }
            }
        }

        private Action GetAction(Character c)
        {
            Console.Write("What action would you like to perform? (1. Do nothing) ");
            int input = Convert.ToInt32(Console.ReadLine());

            return (input) switch
            {
                _ => () => Console.WriteLine($"{c.Name} did NOTHING.")
            };
        }
    }
}
