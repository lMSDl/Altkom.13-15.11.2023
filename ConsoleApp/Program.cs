using System.Globalization;


int a = 5;
int b = 10;
int c = 20;

//deklaracja tablicy przechowującej dane typu int
//[] - tablica
int[] arrayInt;
//inicjalizujemy zmienną nową tablicą typu int o rozmiarze 3
arrayInt = new int[3];

//tablice indeksowane są od 0 (minimalny indeks)
arrayInt[0] = a;
arrayInt[1] = b;
//maksymalny indeks tablicy to rozmian minus 1 ( 3 - 1 = 2)
arrayInt[2] = c;


arrayInt[0] = arrayInt[0] * 2;
arrayInt[1] = arrayInt[1] * arrayInt[2];


Console.WriteLine(arrayInt[0]);
Console.WriteLine(arrayInt[1]);
Console.WriteLine(arrayInt[2]);

Console.WriteLine($"Tablica ma rozmiar {arrayInt.Length}");

string[] stringArray = new string[5];

stringArray[0] = Console.ReadLine();

Console.WriteLine();


void TimeExercise()
{
    int seconds = 119345;

    int divider = 60 * 60 * 24;
    int days = seconds / divider;
    seconds = seconds % divider;

    divider = 60 * 60;
    int hours = seconds / divider;
    seconds = seconds % divider;


    divider = 60;
    int minutes = seconds / divider;
    seconds = seconds % divider;

    Console.WriteLine($"{days}.{hours:00}:{minutes:d2}:{seconds:00}");
}


void Numbers()
{
    int a = 11;
    int b = -4;

    int c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
    c = a / b; //część dziętna jest ucinana
    Console.WriteLine($"{a} / {b} = {c}");
    c = a % b; //reszta z dzielenia
    Console.WriteLine($"{a} % {b} = {c}");

    Console.WriteLine();

    float aa = 11f;
    float bb = -4.0f;

    float cc = aa + bb;
    Console.WriteLine($"{aa} + {bb} = {cc}");
    cc = aa - bb;
    Console.WriteLine($"{aa} - {bb} = {cc}");
    cc = aa * bb;
    Console.WriteLine($"{aa} * {bb} = {cc}");
    cc = aa / bb;
    Console.WriteLine($"{aa} / {bb} = {cc}");


    //aby wynik był poprawny przy dzieleniu dwóch intów należy jako pierwszą operację "przekształcić" int na float
    //możemy to zrobić poprzez wykonanie jako pierwszą operację mnożenia przez typ o większej prezycji
    cc = 1f * a / b;
    Console.WriteLine($"{a} / {b} = {cc}");
    //lub poprzez rzutowanie (czyli potraktowanie jednego typu jako inny (podany w nawiasie))
    cc = a / (float)b;
    Console.WriteLine($"{a} / {b} = {cc}");

    //kolejność działań zgodna z zasadami matematyki
    c = a + a * a;
    Console.WriteLine($"{a} + {a} * {a} = {c}");
    c = (a + a) * a;
    Console.WriteLine($"({a} + {a}) * {a} = {c}");

    Console.WriteLine($"short min:{short.MinValue} max:{short.MaxValue}");
    Console.WriteLine($"int min:{int.MinValue} max:{int.MaxValue}");
    Console.WriteLine($"uint min:{uint.MinValue} max:{uint.MaxValue}");
    Console.WriteLine($"long min:{long.MinValue} max:{long.MaxValue}");
    Console.WriteLine($"ulong min:{ulong.MinValue} max:{ulong.MaxValue}");
    Console.WriteLine($"float min:{float.MinValue} max:{float.MaxValue}");
    Console.WriteLine($"double min:{double.MinValue} max:{double.MaxValue}");
    Console.WriteLine($"decimal min:{decimal.MinValue} max:{decimal.MaxValue}");

    Console.WriteLine(5 / 3.3f);
    Console.WriteLine(5 / 3.3); // lub 3.3d
    Console.WriteLine(5 / 3.3m);

    //Math to klasa zawierające funkcje przydatne w obliczeniach matematycznych
    double value = Math.Sqrt(2f); //pierwiastek
    Console.WriteLine(value);
    value = Math.Pow(2, 5); //potęga 
    Console.WriteLine(value);

    //domyślne zachowanie funkcji zaokrąglającej powoduje zaokrąglanie do wartości parzystej - financial rounding
    Console.WriteLine(Math.Round(2.5));
    Console.WriteLine(Math.Round(3.5));
    //używamy zaokrąglania znanego ze szkoły
    Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
    Console.WriteLine(Math.Round(3.5, MidpointRounding.AwayFromZero));

    //formatowanie liczb
    Console.WriteLine($"{short.MaxValue:### ###.0#}");

    Console.WriteLine("Podaj jakąś wartość liczbową:");
    string intput = Console.ReadLine();


    //parsowanie/konwersja string na int
    int intValue = int.Parse(intput);
    Console.WriteLine(intValue * 2);

    //parsowanie/konwersja string na float
    float floatValue = float.Parse(intput);
    Console.WriteLine(floatValue * 3.5);


    long longValue = intValue;
    Console.WriteLine(longValue) ;

    //rzutowanie - chcąc przypisać wartość o wyższej prezycji do zmiennej o niższej precyzji musimy zastosować rzutowanie
    intValue = (int)longValue;
    Console.WriteLine(intValue);

    longValue = 10000000000000L;
    intValue = (int)longValue;
    Console.WriteLine(intValue);

    floatValue = (float)5.6;

    double doubleValue = floatValue;
    intValue = (int)floatValue;

    float max = Math.Max(intValue, floatValue);
    //niektóre metody zwracają inny typ danych, niż ten z którego korzystamy, więc tu przydaje się rzutowanie
    float average = (float)Math.Pow(floatValue, 2);
}

void Strings()
{

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

}