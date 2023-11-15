

using ShoppingList.Models;
using ShoppingList.Services;

ProductsService service = new ProductsService();
bool exit = false;

do
{
    Console.Clear();
    ShowList();
    ShowMenu();

    string input = Console.ReadLine();
    switch(input)
    {
        case "1":
            AddProduct();
            break;
        case "2":
            RemoveProduct();
            break;
        case "3":
            exit = true;
            break;
        default:
            Console.WriteLine( "Brak wybranej opcji" );
            break;
    }
} while (!exit);


void ShowList()
{
    Product[] prodcuts = service.GetProducts();
    //foreach (var product in prodcuts)
    for (int i = 0; i < prodcuts.Length; i++)
    {
        Product product = prodcuts[i];
        Console.WriteLine($"{i + 1}) {product.Name} : {product.Quantity}");
    }
}

void ShowMenu()
{
    Console.WriteLine();
    Console.WriteLine("1. Dodaj   2.Usuń   3.Zamknij");
}

void AddProduct()
{
    Product product = new Product();
    Console.WriteLine("Podaj nazwę:");
    string input = Console.ReadLine();
    product.Name = input;

    product.Quantity = RequestForInt("Podaj ilość:");

    service.AddProduct(product);
}

void RemoveProduct()
{
    service.RemoveProductAt(RequestForInt("Podaj pozycję na liście do usunięcia:") - 1);
}

int RequestForInt(string label)
{
    int value;
    bool success;
    do
    {
        Console.WriteLine(label);
        string input = Console.ReadLine();
        success = int.TryParse(input, out value);
    } while (!success);

    return value;
}