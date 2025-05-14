Random random = new Random();


Console.WriteLine("Would you like to play? (Y/N)");
PlayGame();
if (ShouldPlay())
{
    PlayGame();
}


bool ShouldPlay() {
    string answer = Console.ReadLine();
    return answer.ToLower().Equals("y");
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = getTarget();
        var roll = getRoll();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int getTarget()
{
    return random.Next(1, 7);
}

int getRoll()
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target)
{
    if (roll > target)
    {
        return "You win!";
    }
    else
    {
        return "You lose!";
    }
}

Console.WriteLine("Thanks for playing!");

