using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_MOULY_Thomas_Assignment
{
    public class Student
    {
        // attributes

        public string studentNumber;
        public string firstName;
        public string lastName;
        public float averageScore;






        // constructor


        public Student(string firstName, string lastName, string studentNumber, float[] score)

        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentNumber = studentNumber;

            float sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            averageScore = sum / score.Length;

        }
        public Student(string firstName, string lastName, string studentNumber, float averageScore)

        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentNumber = studentNumber;
            this.averageScore = averageScore;
        }



        //methods

        public override string ToString()
        {
            return ("first name :" + this.firstName+"\n" + "this.lastName :" + this.lastName+ "\n"+ "Student number :" + this.studentNumber+ "\n"+  "Average score :" + this.averageScore);
        }

    }
}
