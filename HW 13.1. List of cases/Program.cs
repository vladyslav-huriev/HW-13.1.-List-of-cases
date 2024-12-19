namespace HW_13._1._List_of_cases
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            List<(string Task, bool Done)> tasks = new List<(string, bool)>();
            while (true)
            {
                Console.WriteLine("\nThe list of cases: ");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i].Task} [{(tasks[i].Done ? "Done" : "Not done")}]");
                }
                Console.WriteLine("\nResume: \n1. To add the case \n2. Mark as done \n3. Delete the case \n4. Exit");
                Console.Write("Choose the action: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Please enter the case: ");
                        tasks.Add((Console.ReadLine(), false));
                        break;
                    case "2":
                        Console.Write("Please enter the case number to mark as done: ");
                        if (int.TryParse(Console.ReadLine(), out int doneIndex) && doneIndex > 0 && doneIndex <= tasks.Count)
                            tasks[doneIndex - 1] = (tasks[doneIndex - 1].Task, true);
                        else
                            Console.WriteLine("The number is wrong");
                        break;
                    case "3":
                        Console.Write("Please enter the case number to delete: ");
                        if (int.TryParse(Console.ReadLine(), out int deleteIndex) && deleteIndex > 0 && deleteIndex <= tasks.Count)
                            tasks.RemoveAt(deleteIndex - 1);
                        else
                            Console.WriteLine("The number is wrong");
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using the list of cases");
                        return;
                    default:
                        Console.WriteLine("The action is wrong. Try one more time");
                        break;
                }
            }
        }
    }
}