Console.WriteLine("Game: Rock, Paper, Scissors.");
Console.WriteLine();
Console.WriteLine("Player 1 choose");
string playerOne = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Player 2 choose");
string playerTwo = Console.ReadLine();
Console.WriteLine();

WhileDraw(ref playerOne, ref playerTwo);

GameAlgorithm(playerOne, playerTwo);

static void GameAlgorithm(string playerOne, string playerTwo)
{
    if (playerOne == "rock" && playerTwo == "paper")
    {
        Console.WriteLine("Player 2 won!");
    }
    if (playerOne == "rock" && playerTwo == "scissors")
    {
        Console.WriteLine("Player 1 won!");
    }
    if (playerOne == "paper" && playerTwo == "rock")
    {
        Console.WriteLine("Player 1 won!");
    }
    if (playerOne == "scissors" && playerTwo == "rock")
    {
        Console.WriteLine("Player 2 won!");
    }
    if (playerOne == "scissors" && playerTwo == "paper")
    {
        Console.WriteLine("Player 1 won!");
    }
    if (playerOne == "paper" && playerTwo == "scissors")
    {
        Console.WriteLine("Player 2 won!");
    }
}

static void WhileDraw(ref string playerOne, ref string playerTwo)
{
    while (playerOne == "rock" && playerTwo == "rock")
    {
        Console.WriteLine("Tie");
        Console.WriteLine("Choose again.");
        Console.WriteLine();
        Console.WriteLine("Player 1 choose");
        playerOne = Console.ReadLine();
        Console.WriteLine("Player 2 choose");
        playerTwo = Console.ReadLine();
    }
    while (playerOne == "paper" && playerTwo == "paper")
    {
        Console.WriteLine("Tie");
        Console.WriteLine("Choose again.");
        Console.WriteLine();
        Console.WriteLine("Player 1 choose");
        playerOne = Console.ReadLine();
        Console.WriteLine("Player 2 choose");
        playerTwo = Console.ReadLine();
    }
    while (playerOne == "scissors" && playerTwo == "scissors")
    {
        Console.WriteLine("Tie");
        Console.WriteLine("Choose again.");
        Console.WriteLine();
        Console.WriteLine("Player 1 choose");
        playerOne = Console.ReadLine();
        Console.WriteLine("Player 2 choose");
        playerTwo = Console.ReadLine();
    }
}