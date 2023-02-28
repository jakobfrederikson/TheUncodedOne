namespace TheUncodedOne
{
    public abstract class Character
    {
        public abstract string Name { get; }
        public abstract void TakeTurn(Action action);
    }

    public class TrueProgrammer : Character
    {
        public override string Name { get; }
        public TrueProgrammer(string name) => Name = name;

        public override void TakeTurn(Action action) => action.Invoke();
    }

    public class Skeleton : Character
    {
        public override string Name => "SKELETON";
        public override void TakeTurn(Action action) => action.Invoke();
    }
}