using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques2
{
    internal class dice
    {
        public static int posi(int opt,int position)
        {
            const int Start = 0, End = 100;
            int dice = new Random().Next(1, 7);           //gets value dice value
            Console.WriteLine(" has got " + dice);
            Console.Write("Lets see ");
            if (opt == 0)
            {
                Console.Write("No Play .... remain at ");
            }
            else if (opt == 1)
            {
                Console.Write("Earned a Ladder ......jumped to ");
                position = position + dice;
                if (position > End)                               //End condition
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
            Console.WriteLine(position);
            return position;                        //returns the position at the end of one dice throwing process
        }
    }
}
