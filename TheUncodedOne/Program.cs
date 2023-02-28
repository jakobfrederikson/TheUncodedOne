using TheUncodedOne;

string name = ColouredConsole.Prompt("What is your name?");

Party heroesParty = new Party();
heroesParty.Characters.Add(new TrueProgrammer(name));

Party monstersParty = new Party();
monstersParty.Characters.Add(new Skeleton());

var game = new Game(heroesParty, monstersParty);
game.Run();