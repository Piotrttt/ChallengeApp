// praca domowa dzień 4
using System.Security.Cryptography;

var name = "Joanna";
var age = 42;
var sex = "female";

if (sex == "female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, 30 lat");
}
else if (sex == "male" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}