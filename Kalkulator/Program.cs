// ---------------------------------
//          KALKULATOR
// ---------------------------------

// Napisz aplikacje ktora bedzie umozliwiac wykonywanie najprostszych
// zadan matematycznych w kalkulatorze:
// - dodawanie
// - odejmowanie
// - dzielenie
// - mnozenie

// - potegowanie
// - pierwiastkowanie

// Program ma byc przystepny wizualnie dla uzytkownika oraz umozliwiac w kazdej chwili wyjscie z 
// aplikacji przyciskiem ESC

var shutDown = false;

Console.WriteLine("Witaj w programie KALKULATOR\n\n");

while (!shutDown)
{
    Console.WriteLine("Aby wyjsc z programu wcisnij [ESC]. Wcisnij jakikolwiek inny przycisk jesli chcesz isc dalej");
    var pressedKey = Console.ReadKey();

    if (pressedKey.Key == ConsoleKey.Escape)
    {
        shutDown = true;
    }
    else
    {
        Console.WriteLine("Wybierz typ operatora matematycznego: [dod - dodawanie, od - odejmowanie, dz - dzielenie, mn - mnozenie]");
        var providedValue = Console.ReadLine();

        switch (providedValue)
        {
            case "dod":
                Console.WriteLine("Podaj liczby do dodania i po kazdej z nich kliknij enter. Aby zobaczyc wynik wpisz znak =");
                Add();
                break;
            case "od":
                Console.WriteLine("Zaczynam odejmowanie...");
                Subtraction();
                break;
            case "dz":
                Console.WriteLine("Zaczynam dzielenie...");
                Division();
                break;
            case "mn":
                Console.WriteLine("Zaczynam mnozenie...");
                Multiply();
                break;
        }
    }
}

void Add()
{
    var stopAdding = false;
    var sum = 0;

    while (!stopAdding)
    {
        var value = Console.ReadLine();
        var parseResult = int.TryParse(value, out int num);
        if (!parseResult)
        {

            if (value == "=")
            {
                Console.WriteLine("Wynik: " + sum);
            }
            else
            {
                Console.WriteLine("Podales zla wartosc, mozesz podac tylko liczby!!!");
                shutDown = true;
            }
            stopAdding = true;
        }
        else
        {
            sum += num;
        }
    }
}

void Subtraction()
{
    var stopSub = false;
    

    System.Console.WriteLine("Podaj początkową liczbę, od któ®ej chcesz zacząć odejmować");
    var valueBasic = Console.ReadLine();
    var parseResultBasic = int.TryParse(valueBasic, out int sub);

    System.Console.WriteLine("Podaj kolejne liczby, które chcesz odejmować");
    while (!stopSub)
    {
        var value = Console.ReadLine();
        var parseResult = int.TryParse(value, out int num);
        
        if (!parseResult)
        {

            if (value == "=")
            {
                Console.WriteLine("Wynik: " + sub);
            }
            else
            {
                Console.WriteLine("Podales zla wartosc, mozesz podac tylko liczby!!!");
                shutDown = true;
            }
            stopSub = true;
        }
        else
        {
            sub -= num;
        }
    }
}

void Multiply()
{
    var stopMultiply = false;
    var sum = 1;

    while (!stopMultiply)
    {
        var value = Console.ReadLine();
        var parseResult = int.TryParse(value, out int num);
        if (!parseResult)
        {

            if (value == "=")
            {
                Console.WriteLine("Wynik: " + sum);
            }
            else
            {
                Console.WriteLine("Podales zla wartosc, mozesz podac tylko liczby!!!");
                shutDown = true;
            }
            stopMultiply = true;
        }
        else
        {
            sum *= num;
        }
    }
}

void Division()
{
    var stopDiv = false;
    

    System.Console.WriteLine("Podaj początkową liczbę, którą, chcesz dzielić");
    var valueBasic = Console.ReadLine();
    var parseResultBasic = int.TryParse(valueBasic, out int sub);

    System.Console.WriteLine("Podaj kolejne liczby, przez które chcesz podzielić");
    while (!stopDiv)
    {
        var value = Console.ReadLine();
        var parseResult = int.TryParse(value, out int num);
        
        if (!parseResult)
        {

            if (value == "=")
            {
                Console.WriteLine("Wynik: " + sub);
            }
            else
            {
                Console.WriteLine("Podales zla wartosc, mozesz podac tylko liczby!!!");
                shutDown = true;
            }
            stopDiv = true;
        }
        else
        {
            sub = sub/num;
        }
    }
}


Console.WriteLine("Shutting down the app...");
