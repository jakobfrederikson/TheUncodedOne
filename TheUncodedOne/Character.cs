namespace TheUncodedOne
{
    public abstract class Character
    {
        public abstract string Name { get; }
        public abstract Action? Action { get; set; }
        public bool IsAlive { get; set; } = true;
        public abstract void TakeTurn(Action action);
    }

    public class TrueProgrammer : Character
    {
        public override string Name { get; }
        public override Action? Action { get; set; }
        public TrueProgrammer(string name) => Name = name;

        public override void TakeTurn(Action action) => action.Invoke();
    }

    public class Skeleton : Character
    {
        public override string Name => "SKELETON";
        public override Action? Action { get; set; }

        public override void TakeTurn(Action action) => action.Invoke();
    }
}