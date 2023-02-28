namespace TheUncodedOne
{
    public interface IAction
    {
        public void Run(Game game, Character player);
    }

    public class DoNothingAction : IAction
    {
        public void Run(Game game, Character player) => Console.WriteLine($"{player.Name} did NOTHING.");
    }
}
