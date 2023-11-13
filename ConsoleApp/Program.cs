
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