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
}
