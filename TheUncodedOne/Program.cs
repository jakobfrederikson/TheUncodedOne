using System.Xml.Linq;
using TheUncodedOne;

Console.WriteLine("Select a game mode...");
Console.WriteLine("1 - Player vs Computer");
Console.WriteLine("2 - Computer vs Computer");
Console.WriteLine("3 - Player vs Player");
int gameChoice = Convert.ToInt32(ColouredConsole.Prompt("What do you want to do? "));

Game game = gameChoice switch
{
    1 => PlayerVsComputer(),
    2 => ComputerVsComputer(),
    3 => PlayerVsPlayer()
};
game.Run();

/* ===============================================================
                                Methods
   =============================================================== */

Game PlayerVsComputer()
{
    string name = ColouredConsole.Prompt("What is your name?").ToUpper();

    Party heroesParty = new Party(new HumanPlayer());
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

    return new Game(heroesParty, allMonsters);
}

Game ComputerVsComputer()
{
    Party heroesParty = new Party(new ComputerPlayer());
    heroesParty.Characters.Add(new TrueProgrammer("GOOD BOT"));

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

    return new Game(heroesParty, allMonsters);
}

Game PlayerVsPlayer()
{
    string heroName = ColouredConsole.Prompt("Hero, what is your name?").ToUpper();

    Party heroesParty = new Party(new HumanPlayer());
    heroesParty.Characters.Add(new TrueProgrammer(heroName));

    Party firstBattle = new Party(new HumanPlayer());
    firstBattle.Characters.Add(new Skeleton());
    Party secondBattle = new Party(new HumanPlayer());
    secondBattle.Characters.Add(new Skeleton());
    secondBattle.Characters.Add(new Skeleton());

    Party thirdBattle = new Party(new HumanPlayer());
    thirdBattle.Characters.Add(new UncodedOne());

    List<Party> allMonsters = new List<Party>() {
                                                firstBattle,
                                                secondBattle,
                                                thirdBattle
                                            };

    return new Game(heroesParty, allMonsters);
}