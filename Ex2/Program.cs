using System;
using System.Collections.Generic;



namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<StudentInfo> students = new List<StudentInfo>();
            string answer;
           
            StudentInfo S = new StudentInfo();

            Console.WriteLine("Would you like to add new record?");
            answer = Console.ReadLine();
            
            //add new student to students list if condition is yes
            while (answer == "yes")
            {
                

                Console.WriteLine("Enter First Name");
                S.firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                S.lastName = Console.ReadLine();
                Console.WriteLine("Enter studentID");
                S.SID = Console.ReadLine();
                Console.WriteLine("Enter Exam1 Grade");
                S.Exam1Gr = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Exam 2 Grade");
                S.Exam2Gr = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Exam 3 Grade");
                S.Exam3Gr = Convert.ToDouble(Console.ReadLine());

                students.Add(S);


                Console.WriteLine("Would you like to add a new record?");
                answer = Console.ReadLine();

                
                double average = S.CalculateAverage();
                S.CalculateLetterGrade(average);
            }


            //S.DisplayStudentInfo();
            //display all instances in students list
            foreach (var Student in students)
            {
                Console.WriteLine(Student.ToString());
            }



        }
    }
}



