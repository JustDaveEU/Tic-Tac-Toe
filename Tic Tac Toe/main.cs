using System;
using System.Net;
using Tic_Tac_Toe;

Console.BackgroundColor = ConsoleColor.Gray;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();

//Main here

Console.WriteLine("Welcome to Tic Tac Toe. Press any key to start the Game!");
Console.ReadKey(true);
Grid currentGame = new Grid();
PlayerMoveMaker currentInstance = new PlayerMoveMaker(currentGame);
WinChecker currentState = new WinChecker(currentGame);
Console.Clear();

while (currentState.IsThereAWinner == false)
{
    FullTurn("Player 1");
    currentState.WinCheck();
    if (currentState.IsThereAWinner)
        break;
    currentState.LossCheck();
    if (currentState.IsThereAWinner)
        break;
    FullTurn("Player 2");
    currentState.WinCheck();
    if (currentState.IsThereAWinner)
        break;
    currentState.LossCheck();
    if (currentState.IsThereAWinner)
        break;
}
currentGame.PrintGrid();
Console.Write($"{currentState.WhoWon} has won the game!");

//Methods Here
void EmptyLine()
{
    Console.WriteLine();
}
char AskForNumberCharInput(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    if (input != null)
    {
        char charInput = Convert.ToChar(input);
        if (char.IsNumber(charInput))
            return charInput;
    }
    
    Console.WriteLine("Please Stick to numbers!");
    return AskForNumberCharInput(message);
}

void FullTurn(string player)
{
    currentGame.PrintGrid();
    EmptyLine();
    Console.WriteLine("-----------------------------");
    EmptyLine();
    Console.Write($"{player}, your move! ");
    char playerMove = AskForNumberCharInput("Pick a position for your Move!");
    if (currentInstance.MakeMove(player, playerMove))
    {
        currentState = new WinChecker(currentGame);
    }
    else
    {
        Console.WriteLine("This move has already been made.Try again!");
        FullTurn((player));
    }
    
}



