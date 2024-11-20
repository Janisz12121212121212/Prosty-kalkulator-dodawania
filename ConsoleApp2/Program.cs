//Zmienne
int add1 = 0;
int add2 = 0;

// Queston
Console.WriteLine("Wpisz liczbę!");
string userInput = Console.ReadLine();

add1 = int.Parse(userInput);


//Program
Console.WriteLine("Podaj 2 liczbę!");
userInput = Console.ReadLine();
add2 = int.Parse(userInput);

int sum = add1 + add2;

Console.WriteLine($"Twoj wynik to {sum}");
Console.ReadKey();