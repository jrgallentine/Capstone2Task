 using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone2TaskList
{
    class Tazk
    {


        private string _person;
        private string _status;
        private string _taskDesc;
        private string _due;


        public string Person { get; set; }
        public string Status { get; set; }
        public string TaskDesc { get; set; }
        public string Due { get; set; }

        public Tazk(string person, string status, string taskDesc, string due)
        {
            this.Person = person;
            this.Status = status;
            this.TaskDesc = taskDesc;
            this.Due = due;

        }

        public void PrintTask()
        {

            Console.WriteLine("\t------------------------");
            Console.WriteLine($"\t- Person: {Person} \n\t- Status: {Status} \n\t- Date Due: {Due} \n\t- Description: {TaskDesc}");
            Console.WriteLine("\t------------------------");
        }



    }
}
