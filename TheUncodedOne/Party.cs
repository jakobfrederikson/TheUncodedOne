namespace TheUncodedOne
{
    public class Party
    {
        public IPlayer Player { get; }
        public List<Character> Characters { get; } = new List<Character>();

        public Party (IPlayer player) => Player = player;
    }
}
