using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskListConsole
{
    class Task
    {
        //field

        string name;
        string duedate;
        string status;
        string description;
        //properties

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Duedate
        {
            get
            {
                return duedate;
            }
            set
            {
                duedate = value;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public int Count
        {
            get; set;
        }



        //constructors

        public Task()
        {

        }

        public Task(string _name, string _duedate, string _status, string _description)
        {
            name = _name;
            duedate = _duedate;
            status = _status;
            description = _description;
        }
        public void PrintInfo()
        {
            //
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("Task Number " + (Count) + "]  Team member: " + Name + "");
            Console.WriteLine("Task Description: " + Description);
            Console.WriteLine("Due Date: " + Duedate + "   Status: " + Status);
            Console.WriteLine("_________________________________________________");
        }
        public static string GetInputPrompt(string prompt)
        {
            Console.WriteLine(prompt);
            string inputPrompted = Console.ReadLine();
            return inputPrompted;
        }

        public static List<Task> PrintList(List<Task> list)
        {

            foreach (Task l in list)
            {

                l.PrintInfo();
            }
            return list;

        }
        public static List<Task> StatusIs(string input, int number, List<Task> statusUpdate)
        {
            string userSaid = input.ToLower();
            if (userSaid == "yes" || userSaid == "y")
            {
                if (number == 0)
                {
                    statusUpdate[0].Status = "[X] Complete";
                    return statusUpdate;
                }
                if (number == 1)
                {
                    statusUpdate[1].Status = "[X] Complete";
                    return statusUpdate;
                }
                if (number == 2)
                {
                    statusUpdate[2].Status = "[X] Complete";
                    return statusUpdate;
                }
                if (number == 3)
                {
                    statusUpdate[3].Status = "[X] Complete";
                    return statusUpdate;
                }
                else
                {
                    return statusUpdate;
                }
            }
            else
            {
                return statusUpdate;
            }
        }
        //public static DateTime DateReader(string prompt)
        //{

        //    string dateSaid = Console.ReadLine();
        //    string[] dateStrings = { dateSaid };


        //    foreach (string dateString in dateStrings)
        //    {
        //        DateTime convertedDate = DateTime.Parse(dateString);
        //        //string dateIs = string.Parse(convertedDate);
        //       return  Console.WriteLine($"{convertedDate}");
        //        convertedDate;
        //    }
        //}



    }
}