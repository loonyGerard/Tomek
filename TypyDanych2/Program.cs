System.Console.WriteLine("Zadanie 2.1");
int n = 5;
int silnia = 1;

for (int i = 1; i <= n; i++)
{
    silnia = silnia * i;
    System.Console.WriteLine($"silnia = {silnia}");
    System.Console.WriteLine($"i = {i}");
    System.Console.WriteLine();
}

System.Console.WriteLine($@"Silnia liczby {n} to {silnia}");

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("---------------------------------------------------------------------");
System.Console.WriteLine("Zadanie 2.2");

// Wyświetlodległość między podanymi współrzędnymi. Skorzystaj ze wzorów maturalnych na stronie CKE. Jako współrzędne wybierz sobie dowolne dwa punkty np. [x1= 2, y1= 10], [x2= -3,y2= -7]

int jedenX = 2;
int jedenY = 10;
int dwaX = -3;
int dwaY = -7;
double dlugosc = Math.Sqrt((jedenX - dwaX) * (jedenX - dwaX) + (jedenY - dwaY) * (jedenY - dwaY));

System.Console.WriteLine(dlugosc);
System.Console.WriteLine();
System.Console.WriteLine();

double Odleglosc(int aX, int aY, int bX, int bY)
{
    double dlugosc = Math.Sqrt((aX - bX) * (aX - bX) + (aY - bY) * (aY - bY));
    return dlugosc;
}
Odleglosc(2,3,4,5);

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("---------------------------------------------------------------------");
System.Console.WriteLine("Zadanie 2.3");

// 3.Wyświetl trzeci bok trójkąta prostokątnego dla podanych dwóch jego boków przyprostokątnych. Wybierz dowolne liczby.
// c2=a2+b2

double Przeciwprostokatna(double a, double b)
{
    double c2 = a * a + b * b;
    double c = Math.Sqrt(c2);

    System.Console.WriteLine(c);
    return c;
}

Przeciwprostokatna(12.3, 12.4);

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("---------------------------------------------------------------------");
System.Console.WriteLine("Zadanie 2.4");

// 4.Napisz program który będzie wyświetlał podaną liczbę pierwszą z kolei, np. pierwsza liczba to 2, piąta to 11 itd.

// int ktoraliczba = 5;
// int liczba = 12;

//     for(int i = 1; i<=ktoraliczba; i++){
//         if(Dzielniki(i) == 2) {
//             System.Console.WriteLine(i);
//         }
//     }

// int Dzielniki(int num) {
//     int liczbaDzielnikow = 0;
//     int dzielnik = num;
//     while(dzielnik > 0) {
//         if(num % dzielnik == 0) {
//             liczbaDzielnikow++;
//         }
//         dzielnik--;
//     }

//     return liczbaDzielnikow;

// }

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("---------------------------------------------------------------------");
System.Console.WriteLine("Zadanie 2.5");

// 5.Wyświetl dla podanych dwóch liczb całkowitych ich największy wspólny dzielnik.

    double a = 13;
	double b = 2;
	double w;
  
	while (b != 0) {
		w = a % b;
		a = b;
		b = w;
	}
  
	Console.WriteLine("NWD wynosi: {0}",a);

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("---------------------------------------------------------------------");
System.Console.WriteLine("Zadanie 2.6");

// 6.Wyświetl dla podanych dwóch liczb całkowitych ich największą wspólną wielokrotność.

    double a = 10;
	double b = 20;
	double x = a * b;
	double w;

	while (b != 0 && a!=0) {
		w = a % b;
		a = b;
		b = w;
	}

	double nww = x / a;
	Console.WriteLine("NWW wynosi: {0}", nww);

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("---------------------------------------------------------------------");
System.Console.WriteLine("Zadanie 2.7");

// 7.Wyświetl pole prostokąta dla podanej liczby całkowitej.

int podstawa = 2;
int h = 5;
int pole = podstawa*h;
System.Console.WriteLine($@"Pole prostokąta o podstawie {podstawa} oraz wysokości {h} wynosi: {pole}");

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("---------------------------------------------------------------------");
System.Console.WriteLine("Zadanie 2.8");

// 8.Wyświetl pole trójkąta dla podanej podstawy i wysokości.

int podstawa = 2;
int h = 5;
int pole = podstawa*h/2;
System.Console.WriteLine($@"Pole trójkąta o podstawie {podstawa} oraz wysokości {h} wynosi: {pole}");

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("---------------------------------------------------------------------");
System.Console.WriteLine("Zadanie 2.9");
// 9.Wyświetl pole równoległoboku dla podanej podstawy i wysokości

int podstawa = 2;
int h = 5;
int pole = podstawa*h;
System.Console.WriteLine($@"Pole równoległoboku o podstawie {podstawa} oraz wysokości {h} wynosi: {pole}");

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("---------------------------------------------------------------------");
System.Console.WriteLine("Zadanie 2.9");
// 10.Wyświetl pole trapezu dla podanej wysokości oraz dwóch podstaw.

int podstawa = 2;
int podstawaB = 3;
int h = 5;
int pole = (podstawa+podstawaB)*h/2;
System.Console.WriteLine($@"Pole trapezu o podstawie {podstawa} oraz wysokości {h} wynosi: {pole}");