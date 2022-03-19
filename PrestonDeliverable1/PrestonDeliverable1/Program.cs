using System;

namespace PrestonDeliverable1
{
    class Program
    {
       public static bool repeat = true;
        static void Main(string[] args)
        {
           
            if(repeat = true)
            {
                Console.WriteLine("How many people are we making PB&J sandwhiches for?");
                int sandwhiches = int.Parse(Console.ReadLine());
                int JarPB = 32;
                int JarJ = 48;
                int loaf = 28;
                double PBNeeded = sandwhiches * 2;
                double JellyNeeded = sandwhiches * 4;
                double BreadNeeded = sandwhiches * 2;
                double PBJarsNeeded = Math.Ceiling(PBNeeded / 32);
                double JellyJarsNeeded = Math.Ceiling(JellyNeeded / 48);
                double BreadLoafsNeeded = Math.Ceiling(BreadNeeded / 28);
                Console.WriteLine("You need:");
                Console.WriteLine(BreadNeeded + " slices of bread");
                Console.WriteLine(PBNeeded + " tablespoons of peanut butter");
                Console.WriteLine(JellyNeeded + " tablespoons of jelly");

                Console.WriteLine("which is...");

                Console.WriteLine(BreadLoafsNeeded + " slices of bread");
                Console.WriteLine(PBJarsNeeded + " jars of peanut butter");
                Console.WriteLine(JellyJarsNeeded + " jars of jelly");

                Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
                string loopcontrol = Console.ReadLine();

                if (loopcontrol == "yes")
                {
                    repeat = true;
                }
                else if (loopcontrol == "y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                    Console.WriteLine("Goodbye!");

                }

            }
        }
    }
}
