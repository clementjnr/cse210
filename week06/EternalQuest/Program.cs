class Program
{
    static void Main(string[] args)
    {
        // Creativity:
        // Added bonus score milestones:
        // 1000 points = Bronze Adventurer
        // 5000 points = Silver Adventurer
        // 10000 points = Gold Adventurer

        GoalManager manager = new GoalManager();

        bool running = true;

        while (running)
        {
            manager.DisplayScore();

            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.CreateGoal();
                    break;

                case "2":
                    manager.ListGoals();
                    break;

                case "3":
                    manager.RecordEvent();
                    break;

                case "4":
                    manager.SaveGoals();
                    break;

                case "5":
                    manager.LoadGoals();
                    break;

                case "6":
                    running = false;
                    break;
            }
        }
    }
}

