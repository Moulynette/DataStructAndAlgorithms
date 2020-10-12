using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            do
            {
                Console.Clear();
                    

                Console.WriteLine("What exercice do you want to execute ? " +
                    "tape the number of the exercice and press enter" +
                    " 1 - 2 - 3 - 4  ");
                int result = Convert.ToInt32(Console.ReadLine());

                switch (result)
                {
                    case 1:
                        ex1();
                        Console.ReadKey();
                        Console.WriteLine("Press a key to back on the menu");
                        break;
                    case 2:

                        ex2();
                        Console.ReadKey();
                        Console.WriteLine("Press a key to back on the menu");
                        break;
                    case 3:
                        ex1();
                        Console.ReadKey();
                        Console.WriteLine("Press a key to back on the menu");
                        break;
                    case 4:
                        ex2();
                        Console.ReadKey();
                        Console.WriteLine("Press a key to back on the menu");
                        a = 2;
                        break;
                }

            } while (a == 1);
        }


        static void ex1()
        {
            int[] integerArray = { 1,18,7,5,16,3,12,10,14 };
            Console.WriteLine("enter a number beetween 1 and 20, the console will look for this number in the array");
            int number = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            for(int i=0;i<integerArray.Length;i++)
            {
                if(integerArray[i]==number)
                {
                    found = true;
                    Console.WriteLine(number + " exists in the array and is at the " + i + " position");
                }
            }
            if(found ==false)
            {
                Console.WriteLine("the number doesn't exist");
            }
            Console.WriteLine("press a key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Here is the display of the array");

            for (int i = 0; i < integerArray.Length; i++)
            {
                Console.Write(integerArray[i]+" ");
            }


        }

        static void ex2()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(6);
            stack.Push(7);
            stack.Push(9);
            stack.Push(16);
            stack.Push(17);
            stack.Push(19);
            stack.Push(1);
            stack.Push(5);
            stack.Push(20);
            

            Console.WriteLine("enter a number beetween 1 and 20, the console will look for this number in the array");
            int number = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < stack.Count; i++)
            {
                if (stack.ElementAt(i) == number)
                {
                    found = true;
                    Console.WriteLine(number + " exists in the array and is at the " + i + " position");
                }
            }
            if (found == false)
            {
                Console.WriteLine("the number doesn't exist in this array");
            }
            Console.WriteLine("press a key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Here is the display of the array");

            for (int i = 0; i < stack.Count; i++)
            {
                Console.Write(stack.ElementAt(i) + " ");
            }

        }

        static void ex3()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(9);
            queue.Enqueue(16);
            queue.Enqueue(17);
            queue.Enqueue(19);
            queue.Enqueue(1);
            queue.Enqueue(5);
            queue.Enqueue(20);


            Console.WriteLine("enter a number beetween 1 and 20, the console will look for this number in the array");
            int number = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < queue.Count; i++)
            {
                if (queue.ElementAt(i) == number)
                {
                    found = true;
                    Console.WriteLine(number + " exists in the array and is at the " + i + " position");
                }
            }
            if (found == false)
            {
                Console.WriteLine("the number doesn't exist in this array");
            }
            Console.WriteLine("press a key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Here is the display of the array");

            for (int i = 0; i < queue.Count; i++)
            {
                Console.Write(queue.ElementAt(i) + " ");
            }

        }

        static void ex4()
        {
            List<int> list = new List<int>();
            list.Add(6);
            list.Add(7);
            list.Add(9);
            list.Add(16);
            list.Add(17);
            list.Add(19);
            list.Add(1);
            list.Add(5);
            list.Add(20);


            Console.WriteLine("enter a number beetween 1 and 20, the console will look for this number in the array");
            int number = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i) == number)
                {
                    found = true;
                    Console.WriteLine(number + " exists in the array and is at the " + i + " position");
                }
            }
            if (found == false)
            {
                Console.WriteLine("the number doesn't exist in this array");
            }
            Console.WriteLine("press a key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Here is the display of the array");

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list.ElementAt(i) + " ");
            }

        }




    }
}
