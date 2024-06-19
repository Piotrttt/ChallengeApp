// "Mężczyzna w wieku 20 lat"
// "Mężczyzna w wieku poniżej 50 lat o imiemiu Paweł"
// "Niepełnoloetnia osoba"
// "Ewa lub Aneta"

Console.WriteLine("Napisz płeć:");
var sex  = Console.ReadLine();

Console.WriteLine("Napisz imię:");
var name  = Console.ReadLine();

Console.WriteLine("Napisz wiek:");
var ageAsString = Console.ReadLine();
var age = int.Parse(ageAsString);

if (sex == "m" && age == 20)
{
    Console.WriteLine("Mężczyzna w wieku 20 lat");
}
else if (sex == "m" && age < 50 && name == "Paweł")
{
    Console.WriteLine("Mężczyzna w wieku poniżej 50 lat o imiemiu Paweł");
}
else if (age < 18)
{
    Console.WriteLine("Niepełnoloetnia osoba");
}
else if (name == "Ewa" || name == "Aneta")
{
    Console.WriteLine("Ewa lub Aneta");
}