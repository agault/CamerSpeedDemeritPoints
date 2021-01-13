using System;

namespace CamerSpeedDemeritPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            //cw what is your speed?
            Console.WriteLine("what is your speed?:");
            //cr as var speed
            var userSpeed = Convert.ToDecimal(Console.ReadLine());

            //if < var speed limit cw"great job not going over the speed limit"
            if (userSpeed <= 60)
            {
                Console.WriteLine("Carry on there Sooper Trooper");
            }
            //else
            else
            {
                decimal difference = userSpeed - 60;
                decimal points = difference / 5;
               
                if (points<= 1)
                {
                    Console.WriteLine("You're close so I'll let you off with a warning");
                }
                else if (1<=points ==true & points<2)
                {
                    Console.WriteLine("That will be one demerit point");
                }
                else if (2 <= points == true & points < 3)
                {
                    Console.WriteLine("That will be two demerit point");
                }
                else if (3 <= points == true & points < 4)
                {
                    Console.WriteLine("That will be three demerit point");
                }
                else if (4 <= points == true & points < 5)
                {
                    Console.WriteLine("That will be four demerit point");
                }
                else if (6 <= points == true & points < 6)
                {
                    Console.WriteLine("That will be five demerit point");
                }
                else if (6 <= points == true & points <7)
                {
                    Console.WriteLine("That will be six demerit point");
                }

                else
                {
                    Console.WriteLine("I'm just going to go a head and suspend that license ");
                }

            }

        }
    }
}
