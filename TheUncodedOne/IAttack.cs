namespace TheUncodedOne
{
    public interface IAttack
    {
        string Name { get; }
    }
    
    public class Punch : IAttack
    {
        public string Name { get; } = "PUNCH";
    }

    public class BoneCrunch : IAttack
    {
        public string Name { get; } = "BONE CRUNCH";
    }
}
