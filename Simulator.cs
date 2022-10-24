using System;
namespace MoonLander
{
    public class Simulation
    {
        public Lander MoonLander { get; set; }

        public void Run()
        {
            Console.WriteLine("Moon Lander game");
            Console.WriteLine("You are at a height of 1000m above the moons surface.");
            Console.WriteLine("If the module rockets are not fired you will accelerate towards the moon at 1.625 m/sec^2");
            Console.WriteLine("You are given the option to burn or coast for a number of seconds.");
            Console.WriteLine("A duration of burn will decelerate you at 0.875 m/sec^2");
            Console.WriteLine("Good luck commander");

            do
            {
                double userTime;
                Console.WriteLine("Enter B for burn C or anything else for coast");
                string userChoice = Console.ReadLine();

                if (userChoice.ToUpper().Substring(0, 1) == "B")
                {
                    Console.Write("Enter a burn duration: ");
                    while (!double.TryParse(Console.ReadLine(), out userTime))
                    {
                        Console.Write("Enter a valid burn duration: ");
                    }
                    MoonLander.Burn(Math.Abs(userTime));
                }
                else
                {
                    Console.Write("Enter a coast duration: ");
                    while (!double.TryParse(Console.ReadLine(), out userTime))
                    {
                        Console.Write("Enter a valid coast duration: ");
                    }
                    MoonLander.Coast(Math.Abs(userTime));
                }
                if (MoonLander.Height <= 0)
                {
                    if (MoonLander.Velocity >= -10)
                    {
                        Console.WriteLine(value: $"Well done Commander you landed safely with a velocity of {MoonLander.Velocity} m/s");
                    }
                    else
                    {
                        string message = "The Earth thanks you for your vallient efforts commander " +
                                         "and you will be posthumously recognised. You crashed with a velocity of";
                        Console.WriteLine($"{message} {MoonLander.Velocity} m/s");
                    }
                }
                else
                {
                    Console.WriteLine("Commander your new height = {0}\nYour new velocity = {1}", MoonLander.Height, MoonLander.Velocity);
                }
            } while (MoonLander.Height > 0);
        }
    }
}