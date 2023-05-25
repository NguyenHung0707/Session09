// See https://aka.ms/new-console-template for more information
using System;
namespace Students
{
    class StudentsDetails
    {
        string studName = "Alexander";
        int studId = 30;
        public StudentsDetails()
        {
            Console.WriteLine("Student Name : " + studName);
            Console.WriteLine("Students ID : " + studId);
        }
    }
}

namespace Examination
{
    class ScoreReport
    {
        public string Subject = "Science";
        public int Marks = 60;
        static void Main(string[] args)
        {
            Students.StudentsDetails objStudents = new Students.StudentsDetails();
            ScoreReport objReport = new ScoreReport();
            Console.WriteLine("Subject : " + objReport .Subject);
            Console.WriteLine("Marks : " + objReport.Marks); 
        }
    }
}