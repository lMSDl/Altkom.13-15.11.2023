
//deklaracja zmiennej lokalnej o typie string (ciąg / łańcuch znaków) i nazwie helloVariable (nazwa ma znaczenie dla programisty nie dla programu)
//nazwy muszą się zkłądać ze znaków alfa-numerycznych (+ podkreślnik _) i nie mogą zaczynać się od cyfr. Istnieją też nazwy zastrzeżone (słowa kluczowe, nazwy typów, itp)
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