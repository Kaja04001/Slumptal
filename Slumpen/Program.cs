using System;

namespace Slumpen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int slump = rnd.Next(1, 101);
            int FailCounter = 0;
            Console.WriteLine("Ange ett heltal");
            while(true)
            {
                int answer = int.Parse(Console.ReadLine());

                if(answer == slump)
                {
                    Console.WriteLine("Du gissade rätt! Det tog: " + FailCounter + " försök!");
                    break;
                }
                else if(answer > slump)
                {
                    Console.WriteLine("Du gissade för högt!");
                    FailCounter++;
                }
                else if(answer < slump)
                {
                    Console.WriteLine("Du gissade för lågt!");
                    FailCounter++;
                }
            }
        }
    }
}
