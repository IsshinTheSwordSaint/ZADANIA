string imie = "Anna";
string nazwisko = "Kowalska";
string wiekString = "28";
string email = "anna.kowalska@example.com";
string telefon = "123456789";

bool imieOK = false;
bool nazwiskoOK = false;
bool wiekOK = false;
bool emailOK = false;
bool telefonOK = false;

if (!string.IsNullOrWhiteSpace(imie))
{
    Console.WriteLine($"[Imię]{imie} ✓ OK");
    imieOK = true;
}
else
{
    Console.WriteLine($"[Imię]{imie} X Błąd: Pole nie może być puste");
}

if (!string.IsNullOrWhiteSpace(nazwisko))
{
    Console.WriteLine($"[Nazwisko]{nazwisko} ✓ OK");
    nazwiskoOK = true;
}
else
{
    Console.WriteLine($"[Nazwisko]{nazwisko} X Błąd: Pole nie może być puste");
}

if (int.TryParse(wiekString, out int wiek))
{
    if (wiek >= 18 && wiek <= 100)
    {
        Console.WriteLine($"[Wiek]{wiek} ✓ OK");
        wiekOK = true;
    }
    else
    {
        Console.WriteLine($"[Wiek]{wiek} X Błąd: Wiek musi być w zakresie 18–100");
    }
}
else
{
    Console.WriteLine($"[Wiek]{wiek} X Błąd: Wiek musi być liczbą");
}

if (email.Contains("@"))
{
    Console.WriteLine($"[Email]{email} ✓ OK");
    emailOK = true;
}
else
{
    Console.WriteLine($"[Email]{email} X Błąd: Adres email musi zawierać znak '@'");
}

if (telefon.Length == 9 && long.TryParse(telefon, out _))
{
    Console.WriteLine($"[Telefon]{telefon} ✓ OK");
    telefonOK = true;
}
else
{
    Console.WriteLine($"[Telefon]{telefon} X Błąd: Numer telefonu musi mieć dokładnie 9 cyfr");
}

bool wszystkieOK = imieOK && nazwiskoOK && wiekOK && emailOK && telefonOK;

Console.WriteLine();
if (wszystkieOK)
{
    Console.WriteLine("Wszystkie dane są poprawne. Rejestracja zakończona sukcesem!");
}
else
{
    Console.WriteLine("Formularz zawiera błędy. Popraw dane i spróbuj ponownie.");
}
