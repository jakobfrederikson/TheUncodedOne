namespace TheUncodedOne
{
    public abstract class Character
    {
        public abstract string Name { get; }
        public abstract IAttack Attack { get; }
        public abstract int MaxHealth { get; }
        public abstract int HealthToAttack { get; set; }
        public abstract bool IsAlive { get; set; }
    }

    public class TrueProgrammer : Character
    {
        public override string Name { get; }
        public override IAttack Attack { get; } = new Punch();
        public override int MaxHealth { get; } = 25;
        public override int HealthToAttack { get; set; } = 25;
        public override bool IsAlive { get; set; } = true;
        public TrueProgrammer(string name) => Name = name;
    }

    public class Skeleton : Character
    {
        public override string Name => "SKELETON";
        public override IAttack Attack { get; } = new BoneCrunch();
        public override int MaxHealth { get; } = 5;
        public override int HealthToAttack { get; set; } = 5;
        public override bool IsAlive { get; set; } = true;
    }
}