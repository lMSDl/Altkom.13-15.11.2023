using System.Globalization;





bool exit = false;

//while - pętla która trwa gdy jej parametr jest true
//parametr jest sprawdzany PRZED każdym wejściem do ciała pętli
//jeśli przy pierwszym wejściu parametr będzie false, to pętla nigdy się nie wykona

//while(true) //pętla nieskończona
while(!exit)
{
    Console.WriteLine("Co chcesz zrobić?");
    string input = Console.ReadLine();

    switch (input)
    {
        case "exit":
            exit = true;
            break;

        default:
            Console.WriteLine($"Echo: {input}");
            break;
    }


    Console.ReadLine();
    Console.Clear();
}

//do-while - sprawdza warunek po wykonaniu ciała - zapewnia, że zostanie ono wyjonane co najmniej raz
//pozwala to wyeliminować inicjalizację zmiennych przed wejściem do pętli (jeśli zostaną zainicjalizowane wenątrz ciała)
do
{
    Console.WriteLine("Co chcesz zrobić?");
    string input = Console.ReadLine();

    switch (input)
    {
        case "exit":
            exit = true;
            break;

        default:
            exit = false;
            Console.WriteLine($"Echo: {input}");
            break;
    }


    Console.ReadLine();
    Console.Clear();
} while (!exit);


void Switch()
{
    Console.WriteLine("Podaj swoje imię:");
    string input = Console.ReadLine();

    //switch - przyjmuje paramet, który jest porównywany z listą przypadków (case)
    switch (input)
    {
        //case - rozpatrywany przypadek
        case "":
            Console.WriteLine("Szkoda, że nie  chcesz podać swojego imienia");
            break;
        //wiwele case'ów może być przypisanych do tego samego kodu
        case "Alexa":
        case "alexa":
            Console.WriteLine("Hej, masz na imię jak asysten Amazon");
            //kod wykonywany jest od case do break = nie mam potrzeby stosowania klamerek
            //case musi kończyć się instrukcją break, przerywającą wykonywanie switch
            break;
        case "Siri":
        case "siri":
            Console.WriteLine("Hej, masz na imię jak asysten Apple");
            break;
        case "Cortana":
        case "cortana":
            Console.WriteLine("Hej, masz na imię jak asysten Microsoft");
            break;
        case "Paul":
            Console.WriteLine("O.. masz na imię jak mój twórca..");
            break;
        //default - odpowiednik else, czyli wykonanie kodu, jeśli nie znaleziono odpowiedniego case
        //nie jest obowiązkowy
        default:
            Console.WriteLine($"Witaj, {input}");
            break;
    }

    int intValue = 5;
    switch (intValue)
    {
        case < 0:
            break;
        case 5:
            break;
        case >= 6:
            break;
    }
}

/*if (input == "")
{
    Console.WriteLine("Szkoda, że nie  chcesz podać swojego imienia");
}
else if (input == "Alexa" || input == "alexa")
{
    Console.WriteLine("Hej, masz na imię jak asysten Amazon");
}
else if (input == "Siri" || input == "siri")
{
    Console.WriteLine("Hej, masz na imię jak asysten Apple");
}
else if (input == "Cortana" || input == "cortana")
{
    Console.WriteLine("Hej, masz na imię jak asysten Microsoft");
}
else if (input == "Paul")
{
    Console.WriteLine("O.. masz na imię jak mój twórca..");
}
else
{
    Console.WriteLine($"Witaj, {input}");
}*/


void ifelse()
{

    Console.WriteLine("Podaj bok kwadratu:");
    string input = Console.ReadLine();

    //TryParse - zwraca wartość bool mówiącą czy parsowanie się powiodło
    //out - parameter wyjściowy - parametr przez który metoda może nam zwrócić jakąś dodatkową wartość (w tym przypadku jest to wynik parsowania)
    // jeśli parsowanie się nie powiodło, to w parametrze wyjściowym będzie wpisana wartość domyślna typu (dla typów liczbowych jest to 0)
    float size;
    bool parseSuccess = float.TryParse(input, out size);
    if (!parseSuccess)
    {
        Console.WriteLine("Nieprawidłowe dane");
        return; //przerywamy działanie funkcji. Aktualnie jesteśmy w funkcji Main, więc przerwanie jej oznacza zakończenie działania programu
    }



    //if sprawdza warunek w nawiasie i jeśli jest on prawdą, to wykonuje się blok kodu pod nim
    if (size < 0)
    {
        Console.WriteLine("Nieprawidłowy rozmiar");
    }
    //jeśli poprzedni warunek nie jest spełniony, to sprawdzamy kolejny if
    //else if - może występować wielokrotnie
    else if (size == 0)
    {
        Console.WriteLine("Kwadrat nie istnieje");
    }
    //else - wykonuje siuę w każdym innym przypadku (jeśli nie spełniono żadnego z wyżej występujących warunków)
    else
    {
        float area = size * size;
        Console.WriteLine($"Pole kwadratu to: {area}");
    }

    //jeśli używamy else, to tylko jeden blok kodu zostanie wykonany i sprawdzanie warunków kończy się w przypadku wejścia w któryś z nich
    //jeśli nie używamy else, to każdy if będzie traktowany osobno i warunek będzie sprawdzany niezależnie od innych
    //wniosek: else jest łącznikiem między kolenymi if'ami

    bool result;

    result = size == 0; //porównanie
    result = size > 0; //większe
    result = size < 0; //mniejsze
    result = size >= 0; //wieksze lub równe
    result = size <= 0; //mniejsze lub równe
    result = size != 0; //różne

    result = size > 0 || size == 0; // || - lub logiczne (OR)
    result = size > 0 && size <= 10; // && - i logiczne (AND)

    result = !result; //zaprzeczenie

    Console.WriteLine();

}



void Lists()
{

    //tworzymy nową listę. Lista po inicjalizacji jest pusta.
    //List<string> mojaLista = new List<string>();
    List<string> myList = new();

    Console.WriteLine(myList.Count);

    //dodajemy nowy element na koniec listy, rozmiar listy się zwiększa
    myList.Add("ala");
    Console.WriteLine(myList.Count);
    myList.Add("ma");
    Console.WriteLine(myList.Count);
    myList.Add("dwa");
    Console.WriteLine(myList.Count);
    myList.Add("psy");
    Console.WriteLine(myList.Count);

    //wstawiamy element na konkretny indeks listy - pozostałe przesuwają się
    myList.Insert(2, "kota");
    myList.Insert(3, "i");
    Console.WriteLine(myList.Count);

    //usuwamy element spod wskazanego indeksu
    myList.RemoveAt(myList.Count - 2);
    Console.WriteLine(myList.Count);

    myList.Add("ala");
    //usuwamy konkretny element z listy - jeśli występuje sięcej takich elementów, to usunięty zostanie piewszy z nich
    myList.Remove("ala");
    myList.Remove(myList[3]);
    Console.WriteLine(myList.Count);

    Console.WriteLine(myList[0]);
    Console.WriteLine(myList[1]);
    Console.WriteLine(myList[2]);
    myList[0] = "bob";
    Console.WriteLine(myList[0]);


    myList = Console.ReadLine().Split(" ").ToList();
    Console.WriteLine(myList.Count);
    myList.Clear();
    Console.WriteLine(myList.Count);
    Console.WriteLine();

}


void Arrays()
{

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


    Console.WriteLine("Napisz coś:");
    string input = Console.ReadLine();

    string[] words = input.Split(" ");
    Console.WriteLine($"Ilość wyrazów: {words.Length}");
    Console.WriteLine($"Pierwszy wyraz: {words[0]}");



    Console.WriteLine();
}





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