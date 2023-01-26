// Projekt na dzień 4
string name = "Bonawentura";
Console.WriteLine(name);
var gender = "Mężczyzna";
var age = 17;
if (age >= 18 && gender == "Mężczyzna")
    {
    Console.WriteLine("Pełnoletni Mężczyzna");
    }
if (age < 18 && gender == "Mężczyzna")
    {
    Console.WriteLine("Niepełnoletni Mężczyzna");
    }
if (age < 18 && gender != "Mężczyzna")
    {
    Console.WriteLine("Niepełnoletnia Kobieta");
    }
if (age >= 18 && gender != "Mężczyzna")
    {
    Console.WriteLine("Pełnoletnia Kobieta");
    }