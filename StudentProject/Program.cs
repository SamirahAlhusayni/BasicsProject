using System;
using System.Collections.Generic;


namespace StudentProject
{ 
    class Program
    {
        public static int gradeMatch (List<int> grades, int serchGrade)
        {
            int count = 0;
            for (int j = 0; j < grades.Count; j++)
            {
                if (grades[j]== serchGrade)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            
            
            List<string> StudentNames = new List<string> ();
            List<int> StudentGrades = new List<int>();

            int searchGrade;
            Console.WriteLine($"\t------Welcome in Students' Grades Project------");

            string selection = "Yes";
            do
            {
                Console.WriteLine("Student Name:");
                StudentNames.Add(Console.ReadLine());
                Console.WriteLine("Student Grade:");
                StudentGrades.Add(int.Parse (Console.ReadLine()));

                Console.WriteLine("Add Another Student: (Yes/No) ");

                selection = Console.ReadLine();
            } while (selection == "Yes" || selection == "yes");


            Console.WriteLine("\tStudents' Names & Grades ");



            for (int i = 0; i < StudentNames.Count; i++)
            {

                Console.WriteLine($"Student Name: {StudentNames[i]}, Student Grade: {StudentGrades[i]}" );
            }
            Console.WriteLine("Enter the grade to search:");
            searchGrade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Number of Student with Grade {searchGrade} is: {gradeMatch(StudentGrades, searchGrade)}");
        }
        
    }
}
