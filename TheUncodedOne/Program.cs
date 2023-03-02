using TheUncodedOne;

string name = ColouredConsole.Prompt("What is your name?").ToUpper();

Party heroesParty = new Party(new ComputerPlayer());
heroesParty.Characters.Add(new TrueProgrammer(name));

Party firstBattle = new Party(new ComputerPlayer());
firstBattle.Characters.Add(new Skeleton());
Party secondBattle = new Party(new ComputerPlayer());
secondBattle.Characters.Add(new Skeleton());
secondBattle.Characters.Add(new Skeleton());

Party thirdBattle = new Party(new ComputerPlayer());
thirdBattle.Characters.Add(new UncodedOne());

List<Party> allMonsters = new List<Party>() { 
                                                firstBattle,
                                                secondBattle,
                                                thirdBattle
                                            };

Game game = new Game(heroesParty, allMonsters);
game.Run();