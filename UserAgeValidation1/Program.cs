// See https://aka.ms/new-console-template for more information

// rakendus küsib kasutajal sisestada tema vanuse 
// kui kasutaja vanus on väiksem kui 13, kuvatakse : "You are too young to use app
// muul juhul "Welcome"

Console.WriteLine("Enter Your age");
string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber == true) 
{



    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to instagram!");
    } else 
    { 
    Console.WriteLine("You are too young");
    }
 }
else
{
    Console.WriteLine("Write only numbers!!!");
}