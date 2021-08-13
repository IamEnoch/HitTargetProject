using System;

namespace HitTargetProject
{
    class Program
    {
        static double Time(double a, double b, double c, double d)
        {
            return a / (b * Math.Cos(c * d));
        }
        static double Height(double a,double b, double c,double d,double e)
        {
            return ((0.5 * -1) * a * b * b) + (c * b * Math.Sin(d * e) + 10.75);
        }
        static void Main(string[] args)
        {
            const double degrees = Math.PI / 180;
            const double grav = 9.81;
            double len = 3.5;
            int sum1 = 0; 
            int sum2 = 0;

            Console.Write("==PLAYER 1==\nVelocity:");
            var vel1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Angle:");
            var angle1 = Convert.ToDouble(Console.ReadLine());

            var T1 = Time(len, vel1, angle1, degrees);
            var height1 = Height(grav,T1,vel1,angle1,degrees);

            Console.Write("==PLAYER 2==\nVelocoty:");
            var vel2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Angle:");
            var angle2 = Convert.ToDouble(Console.ReadLine());

            var T2 = Time(len, vel2, angle2, degrees);
            var height2 = Height(grav, T2, vel2, angle2, degrees);

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
