//-----------------------------------------------------
//-----------------------------------------------------
//-----------------------------------------------------

void Zadanie1()
{
    System.Console.WriteLine("Zadanie 1.1");
    int liczba = -100;

    while (liczba <= 100)
    {
        System.Console.Write(liczba + ", ");
        liczba++;
    }
}

//-----------------------------------------------------
//-----------------------------------------------------
//-----------------------------------------------------

void Zadanie2()
{
    System.Console.WriteLine(" ");
    System.Console.WriteLine(" ");
    System.Console.WriteLine("Zadanie 1.2");
    int liczba = -100;
    int licznik = 0;

    while (liczba <= 100)
    {
        if (liczba % 2 == 0)
        {
            licznik++;
        }
        liczba++;
    }
    System.Console.Write(licznik + ", ");
}

//-----------------------------------------------------
//-----------------------------------------------------
//-----------------------------------------------------

void Zadanie3()
{
    System.Console.WriteLine(" ");
    System.Console.WriteLine(" ");
    System.Console.WriteLine("Zadanie 1.3");
    int liczba = -100;
    int licznik = 0;

    while (liczba <= 100)
    {
        if (liczba % 5 == 0)
        {
            licznik++;
        }
        liczba++;
    }
    System.Console.Write(licznik);
}

//-----------------------------------------------------
//-----------------------------------------------------
//-----------------------------------------------------

void Zadanie4()
{
    System.Console.WriteLine();
    System.Console.WriteLine();
    System.Console.WriteLine("Zadanie 1.4");
    int liczba = -000;
    int licznik = 0;

    while (liczba <= 100)
    {
        if (liczba % 5 == 0)
        {
            licznik++;
        }
        liczba++;
    }
    System.Console.WriteLine(licznik);
}

//-----------------------------------------------------
//-----------------------------------------------------
//-----------------------------------------------------

// TODO
void Zadanie5()
{
    System.Console.WriteLine();
    System.Console.WriteLine();
    System.Console.WriteLine("Zadanie 1.5");
    int liczba = -100;
    int dzielnik = 8;
    while (liczba <= 100)
    {
        int a = liczba % dzielnik;
        if (a < 0)
        {
            a = -a;
        }
        if (a > 4)
        {
            System.Console.WriteLine($"!! {liczba * a} !!");
        }
        else
        {
            System.Console.Write(liczba + ", ");
        }
        liczba++;
    }
    System.Console.WriteLine();
    System.Console.WriteLine("Koniec zadania 1.5.");
}

//-----------------------------------------------------
//-----------------------------------------------------
//-----------------------------------------------------


void Zadanie6()
{
    System.Console.WriteLine();
    System.Console.WriteLine();
    System.Console.WriteLine("Zadanie 1.6");
    double liczba = 0;

    while (liczba <= 10)
    {
        System.Console.Write($"{Math.Round(liczba, 1)}  ");
        liczba += 0.1;
    }
}

//-----------------------------------------------------
//-----------------------------------------------------
//-----------------------------------------------------
//TODO
void Zadanie7()
{
    System.Console.WriteLine();
    System.Console.WriteLine();
    System.Console.WriteLine("Zadanie 1.7");
    int max = 100;

    for (int i = 1; i <= max; i++)
    {
        if (Dzielniki(i) == 2)
        {
            System.Console.WriteLine(i);
        }
    }
}

int Dzielniki(int num)
{
    int liczbaDzielnikow = 0;
    int dzielnik = num;
    while (dzielnik > 0)
    {
        if (num % dzielnik == 0)
        {
            liczbaDzielnikow++;
        }

        dzielnik--;
    }

    return liczbaDzielnikow;
}

//-----------------------------------------------------
//-----------------------------------------------------
//-----------------------------------------------------

void Zadanie8()
{
    System.Console.WriteLine();
    System.Console.WriteLine();
    System.Console.WriteLine("Zadanie 1.8");
    //TYPY CALKOWITE
    //sbyte 8 bit
    Console.WriteLine($"sbyte od {sbyte.MinValue} do {sbyte.MaxValue} rozmiar 8 bit");

    //byte  8 bit
    Console.WriteLine($"byte od {byte.MinValue} do {byte.MaxValue} rozmiar 8 bit");

    //short 16 bit
    Console.WriteLine($"short od {short.MinValue} do {short.MaxValue} rozmiar 16 bit");

    //ushort 16 bit
    Console.WriteLine($"ushort od {ushort.MinValue} do {ushort.MaxValue} rozmiar 16 bit");

    //int 32 bit
    Console.WriteLine($"int od {int.MinValue} do {int.MaxValue} rozmiar 32 bit");

    //uint 32 bit
    Console.WriteLine($"uint od {uint.MinValue} do {uint.MaxValue} rozmiar 32 bit");

    //long 64 bit
    Console.WriteLine($"long od {long.MinValue} do {long.MaxValue} rozmiar 64 bit");

    //ulong 64 bit
    Console.WriteLine($"ulong od {ulong.MinValue} do {ulong.MaxValue} rozmiar 8 bit");

    //nint 32/64 bit
    Console.WriteLine($"nint od {nint.MinValue} do {nint.MaxValue} rozmiar 32/64 bit");

    //nuint 32/64 bit
    Console.WriteLine($"nuint od {nuint.MinValue} do {nuint.MaxValue} rozmiar 32/64 bit");

    //float
    Console.WriteLine($"float od {float.MinValue} do {float.MaxValue} rozmiar 4 bit");

    //double
    Console.WriteLine($"double od {double.MinValue} do {double.MaxValue} rozmiar 8 bit");

    //decimal
    Console.WriteLine($"decimal od {decimal.MinValue} do {decimal.MaxValue} rozmiar 16 bit");
    Console.WriteLine(
        $"decimal od {decimal.MinValue} do {decimal.MaxValue} rozmiar {sizeof(decimal)} bit"
    );
}

Zadanie1();
Zadanie2();
Zadanie3();
Zadanie4();
Zadanie5();
Zadanie6();
Zadanie7();
Zadanie8();
