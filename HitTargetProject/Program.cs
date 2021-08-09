using System;

namespace HitTargetProject
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;
            const double degrees = PI / 180;
            const double grav = 9.81;
            double len = 3.5;
            int sum1 = 0;
            int sum2 = 0;

            Console.Write("==PLAYER 1==\nVelocity:");
            var vel1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Angle:");
            var angle1 = Convert.ToDouble(Console.ReadLine());

            var T1 = len / (vel1 * Math.Cos(angle1 * degrees));
            var height1 = ((0.5 * -1) * grav * T1 * T1) + (vel1 * T1 * Math.Sin(angle1 * degrees) + 10.75);

            Console.Write("==PLAYER 2==\nVelocoty:");
            var vel2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Angle:");
            var angle2 = Convert.ToDouble(Console.ReadLine());

            var T2 = len / (vel2 * Math.Cos(angle2 * degrees));
            var height2 = ((0.5 * -1) * grav * T2 * T2) + (vel2 * T2 * Math.Sin(angle2 * degrees) + 10.75);

            if (height1 < 3 || height1 > 3.5)
            {
                sum1 += 0;
            }
            else if (height1 >= 3 || height1 < 3.25) 
            {
                sum1 += 1;
            }
            else 
            {
                sum1 += 2;
            }


            if (height2 < 3 || height2 > 3.5)
            {
                sum2 += 0;
            }
            else if (height2 >= 3 || height2 < 3.25) 
            {
                sum2 += 1;
            }
            else
            {
                sum2 += 2;
            }
            
            if (sum1 > sum2) 
            {
                Console.WriteLine($"Player 1 is the winner with {sum1} points"); 
            }
            else if(sum1 == sum2) 
            {
                Console.WriteLine("A tie");
            }
            else 
            {
                Console.WriteLine($"Player 2 is the winner with {sum2} points"); 
            }
        }
    }
}
