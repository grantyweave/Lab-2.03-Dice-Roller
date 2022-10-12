Console.WriteLine("How many sides would you like your dice to have?");
var sideInput = Console.ReadLine();

var isValidInput = IsUserInputValid(sideInput);

if (isValidInput == false)
{
    Console.WriteLine("Invalid Input.");
    return;
}

int sidesInput = int.Parse(sideInput);

Console.WriteLine("Roll your Dice: 'Press any key' ");
string userInput = string.Empty;

while (userInput != "n")
{
    var diceRoll1 = Roll(sidesInput);
    var diceRoll2 = Roll(sidesInput);
    var totalRoll = diceRoll2 + diceRoll1;

    Console.WriteLine($"Your first die is {diceRoll1}");
    Console.WriteLine($"Your second die is {diceRoll2}");
    Console.WriteLine($"Your total number is {totalRoll}");

    HandleSixSidedDie(sidesInput, diceRoll1, diceRoll2);

    Console.WriteLine("Would you like to roll again: 'y' or 'n' ");

    userInput = Console.ReadLine();
}




int Roll(int sides)
{
    Random rnd = new Random();
    return rnd.Next(1, sides);
}

void HandleSixSidedDie(int sides, int roll1, int roll2)
{
    if (sides != 6)
    {
        return;
    }
    var totalRoll = roll2 + roll1;

    if (roll1 == 1 && roll2 == 1)
    {
        Console.WriteLine("Snake Eyes");
    }

    if (roll1 == 1 && roll2 == 2)
    {
        Console.WriteLine("Ace Deuce");
    }

    if (roll1 == 6 && roll2 == 6)
    {
        Console.WriteLine("Box Cars");
    }

    if (totalRoll == 7 || totalRoll == 11)
    {
        Console.WriteLine("Win");
    }

    if (totalRoll == 2 || totalRoll == 3 || totalRoll == 12)
    {
        Console.WriteLine("Craps");
    }

}

bool IsUserInputValid(string sidesInput)
{
    if (int.TryParse(sidesInput, out int _))
    {
        return true;
    }
    return false;
}