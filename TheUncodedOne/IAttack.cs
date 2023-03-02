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

        public int DealDamage() => 10;
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

    public class Unraveling : IAttack
    {
        public string Name { get; } = "UNRAVELING";
        public int DealDamage()
        {
            Random random = new Random();
            return (random.Next(1, 4)) switch // 1, 4 because .Next() will return the min value, but not the max value. (This attack deals 0 - 2 damage)
            {
                1 => 0,
                2 => 1,
                3 => 2,
                _ => 0
            };
        }
    }
}
