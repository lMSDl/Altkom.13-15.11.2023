//namespace - przestrzeń nazw, czyli adres pod którym "mieszka" klasa. W namespace może występować tylko jedna klasa o danej nazwie.
namespace Models
{
    //public - modyfikator dotępu - oznacza, że z klasy można koszystać wszędzie. Inny modyfikator to "internal" - oznacza, że z klasy można korzystać w obrębie projektu, w którym ta klasa występuje
    //class - szablon opisujący zachowania i cechy obiektów (instancji klas), które wytwarzane są na jej podstawie
    //pełna nazwa klasy: namespace + nazwa
    public class Product
    {
        //metoda konstrukcyjna (konstruktor) bezparametrowa
        //brak typu zwracanego i nazwa taka sama jak nazwa klasy
        //jeśli klasa nie ma żadnego konstruktora, to konstruktor bezparametrowy zostanie do niej automatycznie dodany
        //konstruktor służy do ustawienia wartości początkowych pól i właściwości klasy. Domyślnie wartości są ustawiane na domyślne wartości odpowiadające typowi pola/właściowści
        public Product()
        {
            SetName("NoName");
        }

        //konstruktor parametrowy -- służy do zapewnienia klasie wartości początkowych wskazanych jako parametry
        //jeśli w klasie występuje jakikolwiek konstruktor parametrowy, to konstruktor domyślny (bezparametrowy) nie zostanie wytworzony
        //chcąc posiadać też konsturktor bezparametrowy musimy go jawnie utworzyć
        public Product(string name)
        {
            _name = name;
        }
        //możemy mieć wiele konstruktorów parametrowych o ile różnią się wygnaturą (kolejnością i typem parametrów)
        public Product(string name, string description, float price)
        {
            _name = name;
            Description = description;
            Price = price;
        }


        //pole klasy (field)
        //private - modyfikator dostępu - oznacza dostęp tylko dla elementów danej klasy
        //brak modyfikatora dostępu = private
        //pola zazwyczaj są prywatne ze względu na hermetyzację, a dostęp realizowany jest przez metody dostępowe
        //_name - nomenklatura pozwalająca rozróżnić pola prywatne od zmiennych lokalnych lub parametrów funkcji
        private string _name;


        //setter do ustawiania wartości pola _name - metoda przyjmująca jako parametr wartość, która zostanie wpisana do pola
        //schemat sygnatury metody: <modyfikator dostępu> <tym zwracany> <nazwa funkcji>(<opcjonalne parametry: typ + nazwa>)
        public void SetName(string name)
        {
            //this.name = name; //this oznacza odniesienie do klasy, dzięki czemu możemy rozróżnić pole od parametru metody jeśli nazwy są takie same
            _name = name;
        }

        //getter do pobrania wartości pola _name - metoda zwracająca typ zgodny z typem pola
        public string GetName()
        {
            //return instrukcja zwracająca wynik metody - typ obiektu zwracanego musi być zgodny z sygnaturą metody
            return _name;
        }


        //Property

        //auto-property
        //właściwość integruje w sobie pole i metody dostępowe (getter i setter)
        //możliwość zmiany modyfikatora dostępu dla gettera lub setter
        public string Description { /*private*/get; set; }

        //full-property
        private float _price; //backfield dla full-property
        public float Price
        {
            //getter wbudowany w property
            get
            {
                return _price;
            }
            //setter wbudowany w property - posiada niejawny parameter o nazwie value
            set
            {
                if (value < 0)
                {
                    _price = 0;
                }
                else
                {
                    _price = value;
                }
            }
        }



        //metody

        public float PriceWithVat(float vat)
        {
            return _price * (1f + vat);
        }

        public string Summarize()
        {
            return $"{_name} ({Description}): {Price} zł + VAT";
        }

        //static - powoduje, że metoda dostępna jest z poziomu klasy a nie obiektu
        public static Product Parse(string input)
        {
            Product product = new Product();
            string[] splitted = input.Split("|");
            if (splitted.Length >= 1)
            {
                product.SetName(splitted[0]);
            }

            if (splitted.Length >= 2 && splitted[1].StartsWith("(") && splitted[1].EndsWith(")"))
            {
                product.Description = splitted[1].Substring(1, splitted[1].Length - 2);
            }

            if (splitted.Length >= 3) {
                float price;
                if(float.TryParse(splitted[2], out price))
                {
                    product.Price = price;
                }
            }

            return product;
        }
    }


}