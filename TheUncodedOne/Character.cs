namespace TheUncodedOne
{
    public abstract class Character
    {
        public abstract string Name { get; }
    }

    public class TrueProgrammer : Character
    {
        public override string Name { get; }
        public TrueProgrammer(string name) => Name = name;
    }

    public class Skeleton : Character
    {
        public override string Name => "SKELETON";
    }
}