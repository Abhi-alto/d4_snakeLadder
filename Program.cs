Console.WriteLine("Welcome to snake and Ladder game");
Console.WriteLine("Enter player name");                     //for single player
String n = Console.ReadLine();
const int Start = 0, End = 100;                          //represent start position i.e 0 & end position i.e 100
int position = Start;                                      //current position of the player
Console.WriteLine(n+" is at the " + position + " position in "+" the starting");

while (position < 100)                                 
{
    int dice = new Random().Next(1, 7);                         //gets value dice value
    Console.WriteLine(n + " has got " + dice);

    Console.Write("Lets see ");
    int opt = new Random().Next(0, 3);                            //three values
    if (opt == 0)
    {
       Console.Write("No Play .... remain at ");
    }
    else if (opt == 1)
    {
       Console.Write("Earned a Ladder ......jumped to ");
        position = position + dice;
        if (position > End)                               //Restart condition
        {
            position = position - dice;
        }
    }
    else
    {
        Console.Write("Snake .... back to ");
        position = position - dice;
        if (position < Start)                               //Restart condition
        {
            position = 0;
        }
    }
    Console.WriteLine(position);                        //prints the position at the end of one dice throwing process
}
Console.WriteLine("Won the game");