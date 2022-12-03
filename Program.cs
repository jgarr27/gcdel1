using System;

namespace gcdeliverable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool trigger = false;
            while (trigger == false) {

                Console.WriteLine("How many people are we makig pb&j sandwiches for? (integer people) ");
                int people = int.Parse(Console.ReadLine());
                decimal slices = people * 2;
                decimal tablespoons = people * 2;
                decimal teaspoons = people * 4;
                decimal loaves = slices / 28;
                decimal jarpb = tablespoons / 32;
                decimal jarje = teaspoons / 48;

                Console.WriteLine("you need:");
                Console.WriteLine("slices of bread " + slices);
                Console.WriteLine("tablespoons of peanut butter " + tablespoons);
                Console.WriteLine("teaspoons of jelly " + teaspoons);

                Console.WriteLine("which is...");

                Console.WriteLine("loaves of bread " + Math.Ceiling(loaves));
                Console.WriteLine("jars of peanut butter " + Math.Ceiling(jarpb));
                Console.WriteLine("jars of jelly" + Math.Ceiling(jarje));

                Console.Write("Would you like to restart? Enter yes or y to continue, or enter any other key to exit. : ");
                string cont = (Console.ReadLine());
                trigger = false;
                if (cont != "yes")
                    if (cont != "y")
                    {
                        if (trigger == false)

                            Console.WriteLine("Goodbye");
                        break;

                    }


            }
        }
    } }
