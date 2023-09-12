using System;

string Choice = "";


Console.WriteLine("Du kom till en korsning, Gå till höger eller vänster");
Console.WriteLine("Vart går du?");
Console.WriteLine("Vänster [v] Höger [h]");
Choice = Console.ReadLine();
Choice = Choice.ToLower();


if (Choice == "v")
{
Console.WriteLine("Du ramlar och blir nästan påkörd");
Console.WriteLine("Men personen går ut ur bilen");
Console.WriteLine("Kommer du springa där ifrån [y] eller stanna kvar och riskera att dö [n]");

}

else if (Choice == "h")
{
Console.WriteLine("Du går en lång sträcka in i skogen och ser en björn");
Console.WriteLine("Slåss du med björnen [y] eller springer du ifrån björnen [n]");

}

Choice = Console.ReadLine();
Choice = Choice.ToLower();

if (Choice == "y")
{
Console.WriteLine("Du dog");
}

else if (Choice == "n")
{
    Console.WriteLine("Du dog");
Console.WriteLine("Game Over");
}



Console.WriteLine("Tryck enter för att avsluta");
Console.ReadLine();

