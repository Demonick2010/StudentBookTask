using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace Homework_Theme_01
{
    public class Repository
    {
        // Init new list of student
        List<Student> studentList = new List<Student>();

        // Add student method
        public void AddNewStudent()
        {
            Clear();
            // Create student object
            var tempStudentInfo = new Student();

            // Add student info
            tempStudentInfo.Id = studentList.Count;

            Write("Student name: ");
            tempStudentInfo.FirstName = ReadLine();

            Write("Student Last Name: ");
            tempStudentInfo.LastName = ReadLine();

            Write("Student Age: ");
            tempStudentInfo.Age = int.Parse(ReadLine());

            Write("Student height (cm): ");
            tempStudentInfo.PersonHeight = int.Parse(ReadLine());

            for (int i = 0; i < tempStudentInfo.DisciplineName.Count; i++)
            {
                Write($"Give a {tempStudentInfo.DisciplineName[i]} grade: ");
                tempStudentInfo.DisciplineGrades.Add(int.Parse(ReadLine()));
            }

            // Add data to list
            studentList.Add(tempStudentInfo);

            // Write success message
            WriteLine($"\n\nStudent adding successful! Added data is:\nID: {tempStudentInfo.Id}\nFirs name: {tempStudentInfo.FirstName}\nLast name: {tempStudentInfo.LastName}\nHeight is: {tempStudentInfo.PersonHeight} cm\n");
        }

        public void ShowAll()
        {
            Clear();
            if (studentList.Count <= 0)
            {
                Random rnd = new Random(DateTime.Now.Millisecond);
                for (int i = 0; i < 4; i++)
                {
                    studentList.Add(new Student
                    {
                        Id = i,
                        FirstName = $"FirstNameTest{i}",
                        LastName = $"LastNameTest{i}",
                        Age = rnd.Next(18, 54),
                        PersonHeight = rnd.Next(150, 250),
                    });

                    for (int j = 0; j < studentList[i].DisciplineName.Count; j++)
                    {
                        studentList[i].DisciplineGrades.Add(rnd.Next(1, 5));
                    }
                }
            }

            WriteLine("Show all students:\n ");

            ForegroundColor = ConsoleColor.Blue;
            WriteLine($"{"ID",4} {"First Name",20} {"Last Name",20} {"Age",10} {"Height",10} {"AVG", 10}");
            ResetColor();

            // Start cycle
            foreach (var student in studentList)
            {
                WriteLine(student);
            }
            WriteLine("");
            WriteLine("");
        }

        public int PrintStartMenu()
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("**************************************************");
            WriteLine($"Welcome to note book program!\nPress:\n1 - Add new student\n2 - Show all students\n3 - Delete Student\n4 - Quit");
            WriteLine("--------------------------------------------------");

            var answer = int.Parse(ReadLine());
            ResetColor();
            return answer;
        }

        public void DeleteStudent()
        {
            ShowAll();
            WriteLine();
            Write("Give the student ID for deleting: ");
            var tempId = int.Parse(ReadLine());
            var deleteStudent = studentList.Find(x => x.Id == tempId);

            if (deleteStudent is null)
            {
                WriteLine("\nStudent not found!");
                return;
            }

            studentList.Remove(deleteStudent);
            WriteLine($"\nStudent {deleteStudent.FirstName} {deleteStudent.LastName} deleted success!\n");
        }
    }
}
