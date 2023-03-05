namespace TheUncodedOne
{
    public interface IPlayer
    {
        public IAction ChooseAction(Game game, Character character);
    }

    public class ComputerPlayer : IPlayer
    {
        public IAction ChooseAction(Game game, Character character)
        {
            Thread.Sleep(500);
            return new AttackAction(character.Attack, game.GetEnemyPartyFor(character).Characters[0]);
        }
    }

    public class HumanPlayer : IPlayer
    {
        public IAction ChooseAction(Game game, Character character)
        {
            // 1. Character's attack
            // 2. Do nothing
            Console.WriteLine($"1 - Standard Attack ({character.Attack.Name})");
            Console.WriteLine("2 - Do Nothing");
            int input = Convert.ToInt32(ColouredConsole.Prompt("What do you want to do? "));

            return input switch
            {
                1 => new AttackAction(character.Attack, game.GetEnemyPartyFor(character).Characters[0]),
                2 => new DoNothingAction()
            };
        }
    }
}
