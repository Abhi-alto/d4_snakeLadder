using Ques2;
Console.WriteLine("Welcome to snake and Ladder game");
Console.WriteLine("Enter player 1 name");                    //Player names
String n1 = Console.ReadLine();
Console.WriteLine("Enter player 2 name");                     
String n2= Console.ReadLine();
const int Start = 0, End = 100;                          //represent start position i.e 0 & end position i.e 100
int p1 = Start, p2 = Start;                                   //current position of the player   
int x = 0;                                       //For giving chances alternatly to the players to throw the dice
while (p1 < End && p2<End)                                 
{
    int option = new Random().Next(0, 3);                            //three values
    if (x%2==0)
    {
        Console.WriteLine(n1 + "'s chance");
         p1 = dice.posi(option,p1);
        if(option==1 && p1!=End)
        {
            while(option==1 && p1!=End)
            {
                option = new Random().Next(0, 3);
                p1 = dice.posi(option,p1);
            }
        }
    }
    else
    {
        Console.WriteLine(n2 + "'s chance");
        p2 = dice.posi(option,p2);
        if (option == 1 && p1 != End)
        {
            while (option == 1 && p2 != End)
            {
                option = new Random().Next(0, 3);
                p2 = dice.posi(option,p2);
            }
        }
    }
    x++;
}
String won = p1 > p2 ? n1 : n2;
Console.WriteLine(won+" won the game");
      