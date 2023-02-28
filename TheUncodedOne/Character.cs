namespace TheUncodedOne
{
    public abstract class Character
    {
        public abstract string Name { get; }
        public abstract IAttack Attack { get; }
    }

    public class TrueProgrammer : Character
    {
        public override string Name { get; }
        public override IAttack Attack { get; } = new Punch();
        public TrueProgrammer(string name) => Name = name;
    }

    public class Skeleton : Character
    {
        public override string Name => "SKELETON";
        public override IAttack Attack { get; } = new BoneCrunch();
    }
}