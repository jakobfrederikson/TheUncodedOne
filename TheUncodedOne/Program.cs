using TheUncodedOne;

string name = ColouredConsole.Prompt("What is your name?").ToUpper();

Party heroesParty = new Party(new ComputerPlayer());
heroesParty.Characters.Add(new TrueProgrammer(name));

Party monstersParty = new Party(new ComputerPlayer());
monstersParty.Characters.Add(new Skeleton());

Game game = new Game(heroesParty, monstersParty);
game.Run();