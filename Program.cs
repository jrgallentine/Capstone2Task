using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Capstone2TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tazk> tasks = new List<Tazk>();
            {

                tasks.Add(new Tazk("Emma", "Done","Public speech","4/6/2022"));
                tasks.Add(new Tazk("Nestor", "Done", "Read book", "6/20/2021"));
                tasks.Add(new Tazk("Angela", "Done", "Eat breakfast", "5/18/1990"));
                tasks.Add(new Tazk("Martin", "Done", "Go for a walk", "4/19/2022"));
                tasks.Add(new Tazk("Larry David", "Done", "Complain", "12/20/2021"));
                tasks.Add(new Tazk("Larry David", "Done", "I don't know", "12/20/2021"));
                tasks.Add(new Tazk("Larry David", "Done", "Lie", "12/20/2021"));


            }

                //can't use ToArray ??? 
            
            string input = "";
            string person = "";
            string taskDesc = "";
            string due = "";
            string status = "";
            PrintMenu();
            Console.WriteLine();
            int num = 0;

            


            while (true)
            {
                

                int x = tasks.Count();
                input = Console.ReadLine();
                Int32.TryParse(input, out num);
                int ind = 0;
                if (num == 1 || input.Contains("list"))
                {
                    Console.Clear();
                    foreach (Tazk task in tasks)
                    {       
                        Console.WriteLine($"\n\t[{1 + ind++}]");
                        task.PrintTask();

                        continue;
                    }
                    Console.WriteLine("\nPress [ENTER] to return to main menu");
                }
                else if (num == 2 || input.Contains("add"))
                {

                    Console.Write("\tPerson: ");
                    person = Console.ReadLine();
                    status = "In Progress";
                    Console.Write("\tDate Due: ");
                    due = Console.ReadLine();
                    Console.Write("\tDescription: ");
                    taskDesc = Console.ReadLine();
                    tasks.Add(new Tazk(person,status,due,taskDesc));

                    Console.WriteLine("\nTask Created :-P\n");
                    PrintMenu();
                    continue;
                    
                }
                else if (num == 3 || input.Contains("delete"))
                {
                    Console.Clear();
                    Console.Write("Which task would you like remove?: ");
                    Int32.TryParse(Console.ReadLine(), out int index);

                    //had this whole delete section running like a honda until I
                    //did something I can't remember and now it's all fucked up.
                    //this is probably one of those things where it would be nice to have
                    //multiple commits to look back on

                    Console.WriteLine($"Are you sure you'd like to remove task {index}? [y/n]");
                    string response = Console.ReadLine();

                    

                    if (response.ToLower().Contains("y"))
                    {
                        while (true)
                        {

                         
                            try
                            {
                                tasks.RemoveAt(index - 1);
                                Console.WriteLine($"\nTask {index} obliterated :-P\n");
                            }
                            catch
                            {
                                Console.WriteLine("Invalid input");
                                break;
                            }
                            Console.Clear();
                        }

                    }
                    
                    

                    

                    else if (response.ToLower().Contains("n"))
                    {
                        Console.Clear();
                        PrintMenu();
                        continue;
                    }


                    
                    PrintMenu();
                    continue;
                }
                else if (num == 4 || input.Contains("mark"))
                {
                    foreach (Tazk task in tasks)
                    {
                        int index = -1;

                        Console.Write("Which index would you like to mark as complete?");
                        Int32.TryParse(Console.ReadLine(), out index);
                        int temp = index - 1;
                        
                        /// MARK COMPLETE CODE
                        ///////////////////////////// 
                        /// should change to a bool but i need to go to bed before i lose my sanity
                         

                        PrintMenu();
                        Console.Write("Has the take been completed? [y/n]");
                        string inputStatus = Console.ReadLine();
                        if (inputStatus.Contains("y"))
                        {
                            tasks.Insert(temp, task);
                            continue;
                        }
                        continue;
                    }
                }
                else if (num == 5 || input.Contains("quit"))
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n\tLabor is entitled to all it creates.\n\n\n\tHave a nice day :-)\n\n\n");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Input an option from the menu\n");
                    PrintMenu();
                    continue;
                }
            }


        }
        public static void PrintMenu()
        {
            Console.WriteLine("------TASK MANAGER------");
            Console.WriteLine("[1] List tasks");
            Console.WriteLine("[2] Add task");
            Console.WriteLine("[3] Delete task");
            Console.WriteLine("[4] Mark task complete");
            Console.WriteLine("[5] Quit");
            Console.WriteLine("------------------------");

        }

        //I want to try to rebuild this from scratch when I have time, 
        //but I'm gonna have to go to bed and take the loss for now :-/
    }
}
