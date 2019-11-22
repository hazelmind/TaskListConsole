using System;
using System.Collections;
using System.Collections.Generic;

namespace TaskListConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            List<Task> ListAll = new List<Task>
                        {
                            new Task{Count=i++, Name="Karey", Duedate="01/01/2020", Status="[ ] Incomplete", Description="Help someone reach their goal"},
                            new Task{Count=i++,Name="Larry", Duedate="02/02/2020", Status="[ ] Incomplete", Description="Finish the program"},
                            new Task{Count=i++,Name="Marry", Duedate="03/03/2020", Status="[X] Complete", Description="Finish CAD project"},

                        };
            //welcome prompt
            Console.WriteLine("Hello! What would you like to do?");
            //menu,
            bool go = true;
            while (go)
            {

                Console.WriteLine("[ 1 ] List Tasks");
                Console.WriteLine("[ 2 ] Add Task");
                Console.WriteLine("[ 3 ] Delete Task");
                Console.WriteLine("[ 4 ] Mark Task Complete");
                Console.WriteLine("[ 5 ] Quit");
                int userPick = TryCatchInput("");
                switch (userPick)
                {
                    case 1://PrintList
                        Task.PrintList(ListAll);
                        break;

                    case 2:

                        int taskNum = ListAll.Count;
                        ListAll.Add(new Task { Count = taskNum, Name = Task.GetInputPrompt("Enter team members name: "), Duedate = Task.GetInputPrompt("Enter due date for task"), Status = "[ ] Incomplete", Description = Task.GetInputPrompt("Enter a description of the task: ") });
                        break;

                    case 3:

                        int numDelete = TryCatchInput("What task number would you like to delete?");
                        string askDelete = Task.GetInputPrompt("Are you sure you want to delete " + numDelete);

                        string userSaid = askDelete.ToLower();
                        if (userSaid == "yes" || userSaid == "y")
                        {
                            ListAll.RemoveAt(numDelete);
                        }
                        else
                        {
                        }
                        break;

                    case 4:

                        int numberComp = TryCatchInput("Enter the task number you want to mark complete");
                        int number = numberComp - 1;

                        string input = Task.GetInputPrompt("Would you like to mark as complete? [Yes] [No]");
                        Task.StatusIs(input, number, ListAll);
                        break;

                    case 5:
                        //Quit
                        go = false;
                        break;

                    default:
                        Console.WriteLine("Sorry, thats not an option.");
                        go = true;
                        break;

                }
            }
        }

        public static int TryCatchInput(string message)
        {
            string input = Task.GetInputPrompt(message);
            try
            {
                int userInput = int.Parse(input);
                return userInput;
            }
            catch (FormatException)
            {
                return TryCatchInput("That was not a number. Please enter a number.");
            }
            catch (OverflowException)
            {
                return TryCatchInput("That number was too large. Please try another option.");
            }
            catch (Exception e)
            {
                return TryCatchInput(e.GetType() + " Please enter a number");
            }
        }
    }
}
//public DateTime DateReader()
//{
//    Console.WriteLine("Enter date :");
//    string dateSaid = Console.ReadLine();
//    string[] dateStrings = { dateSaid };
//    foreach (string dateString in dateStrings)
//    {
//        DateTime convertedDate = DateTime.Parse(dateString);
//        return convertedDate;
//    };
//}