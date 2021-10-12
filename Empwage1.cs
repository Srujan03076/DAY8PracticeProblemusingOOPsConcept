using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    namespace HelloWorld
    {
        public class UC1_EmpAttendance
        {
            public static void EmpAttendance()
            {
                int IS_FULL_Time = 1;
                Random random = new Random();
                int result = random.Next(0, 2);
                if (result == IS_FULL_Time)
                    Console.WriteLine("Employee is Present");
                else
                    Console.WriteLine("Employee is absent");
                Console.ReadLine();
            }
        }
    }
  