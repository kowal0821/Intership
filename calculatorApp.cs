using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Channels;

bool kont = true;
while (kont)
{
decimal mojaLiczba = 0;
decimal mojaLiczba2 = 0;
bool prawidłowaLiczba = false;
Console.WriteLine("Witaj w kalkulatorze! Podaj pierwszą liczbę, z którą chcesz zrobić działanie:");

while (!prawidłowaLiczba)
{
    string input = Console.ReadLine();
    if (decimal.TryParse(input, out mojaLiczba))
    {
        prawidłowaLiczba = true;
    }
    else
    {
        Console.WriteLine("Liczba którą wpisałeś, nie jest poprawna, jest słowem, używa niedozwolonych znaków, albo jest za długa. Spróbuj od nowa!");
    }
}

Console.WriteLine("Liczba jest poprawna! Teraz wpisz drugą, aby pokazał się wynik!");
prawidłowaLiczba = false;

while (!prawidłowaLiczba)
{
    string input = Console.ReadLine();
    if (decimal.TryParse(input, out mojaLiczba2))
    {
        prawidłowaLiczba = true;
    }
    else
    {
        Console.WriteLine("Liczba którą wpisałeś, nie jest poprawna, jest słowem, używa niedozwolonych znaków, albo jest za długa. Spróbuj od nowa!");
    }
}

Console.WriteLine("Dobrze! A teraz wybierz co chcesz zrobić z tymi dwoma liczbami! (+) aby dodać, (-) aby odjąć, (*) aby pomnożyć, oraz (/) aby podzielić!");

string dzialanie = Console.ReadLine();
decimal wynik = 0;
bool prawidłowoscPodanegoWyboru = true;

try
{
    switch (dzialanie)
    {
        case "+":
            wynik = mojaLiczba + mojaLiczba2;
            break;
        case "-":
            wynik = mojaLiczba - mojaLiczba2;
            break;
        case "*":
            wynik = mojaLiczba * mojaLiczba2;
            break;
        case "/":
            if (mojaLiczba != 0)
            {
                wynik = mojaLiczba / mojaLiczba2;
            }
            else
            {
                Console.WriteLine("NIE MOŻNA DZIELIĆ PRZEZ ZERO!");
                prawidłowoscPodanegoWyboru = false;
            }
            break;
        default:
            Console.WriteLine("Niestety podałeś nieprawidłowy operator! Możesz podać tylko cztery powyższe aby wyszedł wynik!");
            prawidłowoscPodanegoWyboru = false;
            break;
    }
}
catch (OverflowException)
{
    Console.WriteLine("Wynik najprawdopodobniej jest zbyt duży lub zbyt mały aby mógł zostać pokazany przez program.");
    prawidłowoscPodanegoWyboru = false;
}

if (prawidłowoscPodanegoWyboru)
{
    Console.WriteLine("Wynik podanych liczb wynosi: " + wynik);
}

Console.WriteLine("Czy chcesz zrobić nowe działanie? (y/n):");
    string odp = Console.ReadLine();

if (odp == "n")
{
        kont = false;
        Console.WriteLine("Dziękujemy za skorzystanie z naszych usług.");
}
else if (odp != "y")
    {
        Console.WriteLine("Podałeś niepoprawny wyraz. Kalkulator się wyłącza.");
    }
}