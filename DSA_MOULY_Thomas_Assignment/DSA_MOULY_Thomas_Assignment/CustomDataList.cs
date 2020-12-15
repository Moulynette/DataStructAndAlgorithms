using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_MOULY_Thomas_Assignment
{
    public class CustomDataList
    {
        public List <Student> studentList;


        public CustomDataList(List <Student> studentList)
        {
            this.studentList = studentList;
        }


        public void PopulateWithSampleData()
        {
            string firstName1 = "George";
            string firstName2 = "Katie";
            string firstName3 = "Luca";
            string lastName1 = "Biro";
            string lastName2 = "Miro";
            string lastName3 = "Zeta";
            string studentNumber1 = "HLMN20";
            string studentNumber2 = "MLN444";
            string studentNumber3 = "MIRA19";
            float averageScore1 = 16.5f;
            float averageScore2 = 13.42f;
            float averageScore3 = 17.4f;
            Student s1 = new Student(firstName1, lastName1, studentNumber1, averageScore1);
            Student s2 = new Student(firstName2, lastName2, studentNumber2, averageScore2);
            Student s3 = new Student(firstName3, lastName3, studentNumber3, averageScore3);
            this.studentList.Add(s1);
            studentList.Add(s2);
            studentList.Add(s3);
        }
        
        public void Add()
        {
            Console.WriteLine("Hello, how many students do you need to register on our database ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            do
            {
                Console.WriteLine(" Please enter your first name");
                string firstName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(" Please enter your last name");
                string lastName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(" Please enter your student number");
                string studentNumber = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(" Please enter the number of score you wanna save");
                int limit = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                float[] score = new float[limit];
                for (int i = 0; i < limit; i++)
                {
                    Console.Clear();
                    Console.WriteLine("Enter a score");
                    score[i] = float.Parse(Console.ReadLine());

                }
                Student s = new Student(firstName, lastName, studentNumber, score);
                studentList.Add(s);
                
                j++;
            } while (j < numberOfStudents);
            Console.WriteLine("thank you, everything is save now");
        }
        public void GetElement(int index)
        {
            Console.WriteLine(this.studentList[index].ToString());
        }

        public void RemoveByIndex(int index)
        {
            this.studentList.RemoveAt(index);
        }

        public void RemoveFirst()
        {
            this.studentList.RemoveAt(0);
        }

        public void RemoveLast()
        {
            this.studentList.RemoveAt(studentList.Count- 1);
        }

        public void DisplayList()
        {
            for(int i=0; i<this.studentList.Count; i++)
            {
                Console.WriteLine(this.studentList[i].ToString());
                Console.WriteLine();
            }
        }
    }
}
