using TheUncodedOne;

Console.WriteLine("What is your name? ");

Party heroesParty = new Party();
heroesParty.Characters.Add(new TrueProgrammer(Console.ReadLine()));

Party monstersParty = new Party();
monstersParty.Characters.Add(new Skeleton());

var game = new Game(heroesParty, monstersParty);
game.Run();