namespace TheUncodedOne
{
    public interface IAction
    {
        public void Run(Game game, Character c);
    }

    public class DoNothingAction : IAction
    {
        public void Run(Game game, Character c) => Console.WriteLine($"{c.Name} did NOTHING.");
    }

    public class AttackAction : IAction
    {
        private readonly IAttack _attack;
        private readonly Character _enemyCharacter;

        public AttackAction(IAttack attack, Character enemyCharacter)
        {
            _attack = attack;
            _enemyCharacter = enemyCharacter;
        }

        public void Run(Game game, Character c)
        {
            // Do logic here

            Console.WriteLine($"{c.Name} used {_attack.Name} on {_enemyCharacter.Name}!");
            Console.ReadKey(false);
        }
    }

}
