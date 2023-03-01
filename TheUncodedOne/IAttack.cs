namespace TheUncodedOne
{
    public interface IAttack
    {
        string Name { get; }
        public int DealDamage();
    }
    
    public class Punch : IAttack
    {
        public string Name { get; } = "PUNCH";

        public int DealDamage() => 4;
    }

    public class BoneCrunch : IAttack
    {
        public string Name { get; } = "BONE CRUNCH";
        public int DealDamage()
        {
            Random random = new Random();
            if (random.Next(2) == 1) return 0;
            return 1;
        }
    }
}
