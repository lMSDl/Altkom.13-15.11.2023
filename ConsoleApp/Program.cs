
//deklaracja zmiennej lokalnej o typie string (ciąg / łańcuch znaków) i nazwie helloVariable (nazwa ma znaczenie dla programisty nie dla programu)
//nazwy muszą się zkłądać ze znaków alfa-numerycznych (+ podkreślnik _) i nie mogą zaczynać się od cyfr. Istnieją też nazwy zastrzeżone (słowa kluczowe, nazwy typów, itp)
using System.Globalization;

string helloVariable;
//inicjalizacja zmiennej - pierwsze przypiwanie wartości
helloVariable = "hello";

//nie możemy używać niezainicjalizowanych zmiennych
//wywołanie metody na konsoli (metody mają nawiasy ())
Console.Write(helloVariable); //Write - wypisanie na konsolę bez znaku nowej linii

//deklaracja z inicjalizacja
string target = "world";


Console.WriteLine(target); // WriteLine - wypisanie tekstu na konsolę i dodanie znaku końca linii

//zmiana / przypisanie wartości
target = "Tom";

Console.WriteLine(target);

target = Console.ReadLine();


string output;

//łączenie stringów za pomocą operatora +
output = helloVariable + " " + target + "!"; // łączenie stringów to wyprodukowanie nowego stringa na postawie innych
Console.WriteLine(output);

//łączenie stringów za pomocą funkcji string.Format - przydatne, gdy musimy wypisać wiele strinów o takim samym formacie
string format = "{0} {1}!";
output = string.Format(format, helloVariable, target); // format + ilość stringów zgodna z ilością indeksów (numerownych od 0)
Console.WriteLine(output);

//łączenie stringów za pomocą interpolacji (string interpolowany)
output = $"{helloVariable} {target}!"; //$ - włącza string interpolowany
Console.WriteLine(output);
output = "{helloVariable} {target}!";
Console.WriteLine(output);


output = "\"C:\\Users\\Student\\Downloads\\Firefox Installer.exe\""; // t - pozwala na używanie znaków specjalnych np: nowa linia: \n, tablilator: \t
Console.WriteLine(output);
output = @"C:\Users\Student\Downloads\Firefox Installer.exe"; // @ - wyłącza funkcjonalność \
Console.WriteLine(output);


//każda opecja na string powoduje wyprodukowanie nowego (zmienionego) stringa
//replace - zamiana jednego ciągu znaków na inny
output = output.Replace("Downloads", "Pobrane"); //funkcja uwzględnia wielkość liter
Console.WriteLine(output);

//Replace jest motodą przeciążoną - to znaczy ma wiele implementacji o tej samej nazwie, ale innej ilości/typie parametrów
output = output.Replace("users", "Admin", true, CultureInfo.InvariantCulture); //ignorujemy wielkość liter
Console.WriteLine(output);

Console.WriteLine($"Długość stringa \"{output}\" to {output.Length}"); //używamy właściwości Length
Console.WriteLine($"Długość stringa \"{output}\" to {output.Count()}"); //używamy metody count


string partOfPath = output.Substring(5);
Console.WriteLine(partOfPath);

partOfPath = output.Substring(5, 11);
Console.WriteLine(partOfPath);

//obliczamy ile znaków usunąć z końca
partOfPath = output.Substring(output.Length - 3, 3);
Console.WriteLine(partOfPath);

// == - operator porównania (dla string działa tak samo jako Equals()) zwraca informacje czy to są te same obiekty
bool isEqual = helloVariable == "hello"; //bool - wartości prawda/fałsz (true/false)
Console.WriteLine($"Is helloVariable equal to hello? {isEqual}");

isEqual = helloVariable.Equals("Hello", StringComparison.InvariantCultureIgnoreCase);
Console.WriteLine($"Is helloVariable equal to Hello (ignorin case)? {isEqual}");

//usuwanie białych znaków z początku i/lub końca
output = "   ala ma kota    ";
Console.WriteLine("|" + output + "|");
Console.WriteLine("|" + output.Trim() + "|");
Console.WriteLine("|" + output.TrimEnd() + "|");
Console.WriteLine("|" + output.TrimStart() + "|");