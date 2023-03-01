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
            int attackDamage = _attack.DealDamage();
            _enemyCharacter.HealthToAttack -= _attack.DealDamage(); 
            if (_enemyCharacter.HealthToAttack < 0) _enemyCharacter.HealthToAttack = 0; // Don't let health go below 0

            Console.WriteLine($"{c.Name} used {_attack.Name} on {_enemyCharacter.Name}!");
            Console.WriteLine($"{_attack.Name} dealt {attackDamage} to {_enemyCharacter.Name}!");
            Console.WriteLine($"{_enemyCharacter.Name} is now at {_enemyCharacter.HealthToAttack}/{_enemyCharacter.MaxHealth}");
            Console.ReadKey(false);
        }
    }

}
