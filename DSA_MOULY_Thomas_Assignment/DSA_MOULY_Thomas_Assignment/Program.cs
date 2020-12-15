﻿using System.Collections.Generic;
using System.Text;
using System;

namespace DSA_MOULY_Thomas_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>() ;
            CustomDataList dataBase = new CustomDataList(list);
            dataBase.PopulateWithSampleData();
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            do
            {
                Console.Clear();
                Console.WriteLine("Hello, welcome to our databae. Please select an action");
                Console.WriteLine();
                Console.WriteLine("To display all informations about the list enter 1");
                Console.WriteLine();
                Console.WriteLine("To register new students, enter 2");
                Console.WriteLine();
                Console.WriteLine("To remove the first student from the database enter 3");
                Console.WriteLine();
                Console.WriteLine("To remove the last student from the database enter 4");
                Console.WriteLine();
                Console.WriteLine("To get the informations at a specific index, enter 5");
                int answer = Convert.ToInt32(Console.ReadLine());


                switch(answer)
                {
                    case 1:
                        Console.Clear();
                        dataBase.DisplayList();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadKey();

                        break;

                    case 2:
                        Console.Clear();
                        dataBase.Add();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        dataBase.RemoveFirst();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        dataBase.RemoveLast();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Please enter which index in the database is interesting you");
                        int index = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        dataBase.GetElement(index);
                        Console.WriteLine("Press enter to continue");
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("Please enter an index where you want to delete the informations");
                        int index2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        dataBase.RemoveByIndex(index2);
                        Console.WriteLine("Press enter to continue");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
                Console.WriteLine("Press Escape to go back to the menu, press any other key to leave the program");
                cki = Console.ReadKey();
            } while (cki.Key==ConsoleKey.Escape);


        }
    }
}
