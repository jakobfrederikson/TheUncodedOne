using TheUncodedOne;

string name = ColouredConsole.Prompt("What is your name?").ToUpper();

Party heroesParty = new Party(new ComputerPlayer());
heroesParty.Characters.Add(new TrueProgrammer(name));

Party firstEnemyParty = new Party(new ComputerPlayer());
firstEnemyParty.Characters.Add(new Skeleton());
Party secondEnemyParty = new Party(new ComputerPlayer());
secondEnemyParty.Characters.Add(new Skeleton());
secondEnemyParty.Characters.Add(new Skeleton());

List<Party> allMonsters = new List<Party>() { 
                                                firstEnemyParty,
                                                secondEnemyParty 
                                            };

Game game = new Game(heroesParty, allMonsters);
game.Run();