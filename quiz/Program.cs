using System;
using System.IO;

string[] question = File.ReadAllLines(@"questions");
string[] alternatives = File.ReadAllLines(@"alternatives");
string[] rightAnswer = File.ReadAllLines(@"rightAnswer");

int totalPoints = 0;

string playerAnswer;
string doGameRestart;

Boolean startGame = false;
Boolean killGame = false;

while (killGame == false)
{
    for (int i = 0; i < question.Length; i++)
    {
        Console.WriteLine(question[i]);
        Console.WriteLine(alternatives[i]);
        playerAnswer = Console.ReadLine();

        if (playerAnswer == rightAnswer[i])
        {
            Console.WriteLine("Right answer");
            totalPoints += 1;
        }
        else
        {
            Console.WriteLine("Wrong answer, right answer was " + rightAnswer[i]);
        }
    }

    startGame = false;
    while (startGame == false)
    {
        Console.WriteLine("Your total score is " + totalPoints);
        Console.WriteLine("If you would like to play again press r");
        doGameRestart = Console.ReadLine();
        if (doGameRestart == "r" || doGameRestart == "R")
        {
            killGame = false;
            startGame = true;
        }
        else
        {
            killGame = true;
            startGame = true;
        }
    }
}
Console.ReadLine();