
using System.Globalization;
using SEDC.Class01.Exercises.NewFolder;

//bool IsWeekend(DateTime date)
//{
//    if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
//    {
//        Console.WriteLine("It's weekend. It's not working day!");

//    }
//    return false;
//}

//bool IsHolyday(DateTime date)
//{
//    return false;
//}



//Console.WriteLine("Enter a date dd/mm/yyyy");
//DateTime date = DateTime.Parse(Console.ReadLine());

//while (true)
//{
//    if (IsHolyday(date))
//    {
//        Console.WriteLine("Today is holyday. It's not working day");

//    }
//    else if (IsWeekend(date))
//    {
//        Console.WriteLine("Hoorey! It's weekend!");

//    }
//    else
//    {
//        Console.WriteLine("Today is working day!");

//    }
//    Console.WriteLine("Do you whant to continue! Y/N");
//    string input = Console.ReadLine();
//    if(input == "y" && input == "Y")
//    {
//        continue;
//    }
//    else if(input == "n" && input == "N")
//    {
//        break;
//    }

//}
// za vtorata vezba


Console.WriteLine("Welcome!");
Console.WriteLine("Choose with what you whant to play? \n1) Rock, \n2) Paper or \n3) Scissors");
int playerChoise = int.Parse(Console.ReadLine());
Console.WriteLine($"You choose {playerChoise}");

Game player = (Game)playerChoise;
Console.WriteLine($"You choose {player}");

int computerChoise = new Random().Next(1, 4);
Game gameEnum = (Game)computerChoise;

Console.WriteLine($"Computer choise {computerChoise}");
Console.WriteLine(gameEnum);

player = 0;
gameEnum = 0;
while (true)
{
    if (player > gameEnum)
    {
        //player++;
        Console.WriteLine("You win!");
        break;
    }
    else if (player < gameEnum)
    {
        //gameEnum++;
        Console.WriteLine("Computer win!");
        break;
    }
    //else
    //{
    //    Console.WriteLine("Nobody win!");
    //    break;
    //}
}
//int randomNumber = new Random().Next(1, 4);
//Operation operationEnum = (Operation)randomNumber;
//Console.WriteLine(operationEnum);,