using System;
using System.Collections.Generic;
using System.Text;
using static Lesson8.IPrinter;

namespace Lesson8
{
    public delegate void TaskCompleted(string taskResult);
    public class UIDelegat
    {
        public void ContinueWork(TaskCompleted taskComplited)
        {
            Console.WriteLine("You want continue?");
            if (Console.ReadLine() == "Yes")
            {
                UIStartApp.DeleteAllString();
                if (taskComplited != null)
                {
                    UIStartApp.Start();
                }
            }

        }
    }
}
