// See https://aka.ms/new-console-template for more info

//rakendus küsib kas oled m/f
// rakendus küsib sisestada tema perekonnanime
// lähtudes kasutaja valikust tervitab kasutajat järgmiselt:
// "Welcome, Mr [kasutaja perekonnanimi] / "Welcome, Ms. [kasutaja perekonnanimi]

Console.WriteLine("Please select Your gender (m/f) or other:");

char userGender = Char.Parse( Console.ReadLine());// loeb konsoolist mahe andmeid string(sõne) formaadis
Console.WriteLine("Please, enter Your lastname");
string userLastName= Console.ReadLine();  

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome {userLastName}!");
}



