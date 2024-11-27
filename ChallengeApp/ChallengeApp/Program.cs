// Praca domowa dzień 5 v.2
// alternatywna wersja pracy domowej z dnia 5 pokazana przez Zuzię w dniu 19.09.2023 r. LIVE #48 od 31:30

// Przygotuj program, który policzy ile jakich cyfr występuje w podanej liczbie.

// Przykład: 
// Wyniki dla liczby: 4566
// 0 => 0
// 1 => 0
// 2 => 0
// 3 => 0
// 4 => 1
// 5 => 1
// 6 => 2
// 7 => 0
// 8 => 0
// 9 => 0

int number = 456621789;
string numberInString = number.ToString();
char[] digitsInNumber = numberInString.ToArray();
List<char> digits = new() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

foreach (var digit in digits)
{
    int count = 0;
    foreach (var digitInNumber in digitsInNumber)
    {
        if (digitInNumber == digit)
        {
            count++;
        }
    }

    Console.WriteLine($"{digit} => {count}");
}
