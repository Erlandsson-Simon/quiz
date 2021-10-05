using System;
using System.IO;

string[] question = File.ReadAllLines(@"questions");
string[] alternatives = File.ReadAllLines(@"alternatives");
string[] rightAnswer = File.ReadAllLines(@"rightAnswer");

int totalPoints = 0;

string playerAnswer;

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

Console.WriteLine("Your total score is " + totalPoints);
Console.ReadLine();