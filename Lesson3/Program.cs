using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson3
{
    class Program
    {
        // array list : n'importe quel type d'objets, list : un seul type d'objet


        static void Arrays()
        {
            ArrayList list = new ArrayList();
            foreach (var item in list)
                Console.WriteLine(item);


            string[] names = { "Flo", "Paul", "Nico", "Max", "Pierre", "Sarah" }



            DateTime[] bdays = new DateTime[names.Length];
            bdays[0] = new DateTime(2000, 01, 22);
            bdays[1] = new DateTime(2001, 01, 22);
            bdays[2] = new DateTime(2002, 01, 22);
            bdays[3] = new DateTime(2003, 01, 22);
            bdays[4] = new DateTime(2004, 01, 22);


            Console.WriteLine("Index ? (0 - 4)");
            int index = Convert.ToInt32(Console.ReadLine());


            string periofOfMonth = GetPeriodOfMonth(bdays, index);
            string monthName = GetMonthName(bdays[index].Month);


            Console.WriteLine(names[index] + "'s birthday is in the " + periofOfMonth + " in " + monthName);

        }

        private static string GetPeriodOfMonth(DateTime[] bdays, int index)
        {
            int day = bdays[index].Day;
            string periodOfMonth = "beginning";
            if (day > 10)
            {
                periodOfMonth = "middle";
            }
            if (day > 20)
            {
                periodOfMonth = "end";
            }
            return periodOfMonth;
        }


        private static string GetMonthName(int month)
        {
            if (month == 1) return "January";
            if (month == 2) return "February";
            if (month == 3) return "March";
            if (month == 4) return "April";
            if (month == 5) return "May";
            if (month == 6) return "June";
            if (month == 7) return "July";
            if (month == 8) return "August";
            if (month == 9) return "September";
            if (month == 10) return "October";
            if (month == 11) return "November";
            if (month == 12) return "December";

            return "unknown";

        }

        static void Task2()
        {
            Console.WriteLine("Write a sentence : ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(" ");

            string longestword = "";

            foreach (string word in words)
            {
                if (longestword.Length < CleanWord(word).Length)
                {
                    longestword = word;
                }
            }


            Console.WriteLine($"The longest word is : {longestword}");

        }
        private static string CleanWord(string word)
        {
            return word.Replace(".", "").Replace(",", "");
        }

        static void Invert()
        {
            Console.WriteLine("Write a sentence : ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(" ");
            Stack<string> stack = new Stack<string>();

            foreach (string word in words)
            {
                stack.Push(word);
            }
            while (stack.Count > 0)
                Console.WriteLine(stack.Pop() + " ");

        }

        static void Array()
        {
            // bool result = false;
            ArrayList array = new ArrayList();
            for (int i = 0; i <= 10; i++)
            {
                array.Add(i);
            }
            foreach (int item in array)
            {
                Console.WriteLine(item + "\n");
            }
            Console.WriteLine("Write a number to check if it's in the array : ");
            int check = int.Parse(Console.ReadLine());
            if (array.Contains(check) == true)
            {
                Console.WriteLine("\nThe number is in the array");
            }
            else
                Console.WriteLine("\nThe number is not in the array");

            //foreach (int item in array)
            //{
            //    if (check == item)
            //    {
            //        result = true;
            //    }
            //    else
            //    {
            //        result = false;
            //    }
            //}
            //Console.WriteLine($"The number is in the array : {result}"); 
            /////////// fonctionne pas jcp pk /////////////////
        }

        static void Stack()
        {
            Stack<int> mystack = new Stack<int>();
            for (int i = 0; i <= 10; i++)
            {
                mystack.Push(i);
            }
            foreach (int item in mystack)
            {
                Console.WriteLine($"\n{item}");
            }
            Console.WriteLine("Write a number to check if it's in the stack : ");
            int check = int.Parse(Console.ReadLine());
            if (mystack.Contains(check) == true)
            {
                Console.WriteLine("\nThe number is in the stack");
            }
            else
                Console.WriteLine("\nThe number is not in the stack");

        }
        static void Queues()
        {
            Queue<int> myqueue = new Queue<int>();
            for (int i = 0; i <= 10; i++)
            {
                myqueue.Enqueue(i);
            }
            foreach (int item in myqueue)
            {
                Console.WriteLine($"\n{item}");
            }
            Console.WriteLine("Write a number to check if it's in the queue : ");
            int check = int.Parse(Console.ReadLine());
            if (myqueue.Contains(check) == true)
            {
                Console.WriteLine("\nThe number is in the queue");
            }
            else
                Console.WriteLine("\nThe number is not in the queue");

        }
        static void List()
        {
            List<int> mylist = new List<int>();
            for (int i = 0; i <= 10; i++)
            {
                mylist.Add(i);
            }
            foreach (int item in mylist)
            {
                Console.WriteLine($"\n{item}");
            }
            Console.WriteLine("Write a number to check if it's in the list : ");
            int check = int.Parse(Console.ReadLine());
            if (mylist.Contains(check) == true)
            {
                Console.WriteLine("\nThe number is in the list");
            }
            else
                Console.WriteLine("\nThe number is not in the list");

        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n Task 1 : \n\n"
                                     + " 1 : Names and birth dates (arrays)"

                                     + "\nTask 2 : Longest word in a sentence"
                                     + "\n Task 3 : Reverse the words of a sentence"

                        + "\n\nHomework : "
                  + "\n\n 4 : Array"
                   + "\n\n 5 : Stack"
                    + "\n\n 6 : Queues"
                     + "\n\n 7 : List<T>"

                                     + "\n\n Please choose : ");
                int exo = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (exo)
                {
                    case 1:
                        Arrays();
                        break;

                    case 2:
                        //    Task2();
                        break;

                    case 3:
                        Invert();
                        break;
                    case 4:
                        Array();
                        break;
                    case 5:
                        Stack();
                        break;
                    case 6:
                        Queues();
                        break;
                    case 7:
                        List();
                        break;
                }
                Console.WriteLine("\nPress any key to exit... ");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
            Console.ReadKey();
        }
    }
}
