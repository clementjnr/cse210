using System;

/*
CREATIVITY:
1. I added multiple prompts and questions.
2. I added spinner animation.
3. I added countdown animation.
*/


class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");

            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing =
                        new BreathingActivity();
                    breathing.Run();
                    break;

                case "2":
                    ReflectionActivity reflection =
                        new ReflectionActivity();
                    reflection.Run();
                    break;

                case "3":
                    ListingActivity listing =
                        new ListingActivity();
                    listing.Run();
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress ENTER to continue...");
                Console.ReadLine();
            }
        }
    }
}

