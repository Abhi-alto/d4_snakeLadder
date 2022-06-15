Console.WriteLine("Welcome to snake and Ladder game");
Console.WriteLine("Enter player name");
String n = Console.ReadLine();
const int Start = 0, End = 100;
int position = Start;
Console.WriteLine(n+" is at the " + position + " position"+" the starting");

int dice = new Random().Next(1, 7);
Console.WriteLine(n+" has got "+dice);