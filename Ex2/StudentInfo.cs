using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    public class StudentInfo
    {
        public string firstName { get;set; }    
        public string lastName { get;set; }
        public string SID { get;set; }
        public double Exam1Gr { get; set; }
        public double Exam2Gr { get; set; }
        public double Exam3Gr { get; set; }
        public double AveGr;
        public char LetterGr;

        public StudentInfo()
        {
            firstName = "";
            lastName = "";
            SID = "";
            Exam1Gr = 0;
            Exam2Gr = 0; ;
            Exam3Gr = 0;
            AveGr = 0;
            LetterGr = '\0';
        }

        public StudentInfo(string fn, string ln, string id, double ex1, double ex2, double ex3, double ave)
        {
            this.firstName = fn;
            this.lastName = ln;
            this.SID = id;
            this.Exam1Gr = ex1;
            this.Exam2Gr = ex2;
            this.Exam3Gr = ex3;
            this.AveGr = ave;

        }
        public override string ToString()
        {
            string message = string.Format($"{firstName },{lastName },({SID}),Exam1:{Exam1Gr},Exam 2:{Exam2Gr},Exam 3:{Exam3Gr}, Average Grade:{AveGr}, Letter Grade:{LetterGr}");
            return message;
        }


        public char CalculateLetterGrade(double CalculateAverage)
        {
            if (CalculateAverage >= 90)
            {
                LetterGr = 'A';
                return LetterGr;
            }
            else if (CalculateAverage >= 80)
            {
                LetterGr = 'B';
                return LetterGr;
            }
            else if (CalculateAverage >= 70)
            {
                LetterGr = 'C';
                return LetterGr;
            }
            else if (CalculateAverage >= 60)
            {
                LetterGr ='D';
                return LetterGr;
            }
            else
            {
                LetterGr='F';
                return LetterGr;
            }


        }
        public double CalculateAverage()
        {


            AveGr = (Exam1Gr + Exam2Gr + Exam3Gr) / 3;
            return AveGr;
        }
        //public void DisplayStudentInfo(string firstName, string lastName, string SID, double Exam1Gr, double Exam2Gr, double Exam3Gr, double CalculateAverage, char CalculateLetterGrade)
        //{
        //    Console.WriteLine($"StudentName:{firstName},{lastName}");
        //    Console.WriteLine($"StudentID: {SID}");
        //    Console.WriteLine($"Exam 1:{Exam1Gr}");
        //    Console.WriteLine($"Exam 2: {Exam2Gr}");
        //    Console.WriteLine($"Exam 3:{Exam3Gr}");
        //    Console.WriteLine($"Your average is:{CalculateAverage}");
        //    Console.WriteLine($"Your LetterGrade is: {CalculateLetterGrade}");

        //}


    }
}




