using System;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace AdvancedCS_Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.Write("Enter Size : ");
            int size = int.Parse(Console.ReadLine()!);
            Console.Write("Enter Number Query : ");
            int QueryNum = int.Parse(Console.ReadLine()!);
            List<int> list = new(size);
            Console.WriteLine("Enter Numbers : ");
            for (int i = 0; i < list.Capacity; i++)
            {
                list.Add(int.Parse(Console.ReadLine()!));
            }
            List<int> query = new(QueryNum);
            Console.WriteLine("Enter Queries : ");
            for (int i = 0; i < query.Capacity; i++)
            {
                query.Add(int.Parse(Console.ReadLine()!));
            }
            int count = 0;
            Console.WriteLine("Output : ");
            for (int i = 0; i < query.Count; i++)
            {
                count = 0;
                for (int j = 0; j < list.Count; j++)
                    if (list[j] > query[i])
                        count++;
                Console.WriteLine(count);
            }
            #endregion

            #region Q2
            Console.WriteLine("\n");
            Console.Write("Enter Size :");
            bool palindrome = false; 
            int N = int.Parse(Console.ReadLine()!);
            List<int> arr = new(N);
            for (int i = 0;i < arr.Capacity; i++)
                arr.Add(int.Parse(Console.ReadLine()!));
            for (int i = 0; i < arr.Count; i++)
                if (arr[i] == arr[arr.Count - i - 1])
                    palindrome = true;
                else
                    palindrome = false;
            Console.WriteLine($"palindrome : {palindrome}");
            #endregion

            #region Q3
            Console.WriteLine("\n");
            Queue<string> str = new();
            Stack<string> reverse = new();
            str.Enqueue("Ahmed");
            str.Enqueue("Sayed");
            str.Enqueue("Mohamed");
            str.Enqueue("Hassan");
            foreach (var item in str)
            {
                reverse.Push(item);
            }
            foreach (var item in reverse)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Q4
            Console.WriteLine("\n");
            Console.Write("Enter expression: ");
            string input = Console.ReadLine()!;
            Stack<char> stack = new Stack<char>();
            bool isBalanced = true;
            foreach (char ch in input)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0)
                        isBalanced= false;

                    char top = stack.Pop();

                    if (!IsMatching(top, ch))
                        isBalanced = false;
                }
                
            }
            static bool IsMatching(char open, char close)
            {
                return (open == '(' && close == ')') ||
                       (open == '{' && close == '}') ||
                       (open == '[' && close == ']');
            }
            if (isBalanced && stack.Count == 0)
                Console.WriteLine("The expression is balanced.");
            else
                Console.WriteLine("The expression is not balanced.");
            #endregion

            #region Q5
            int[] ints = { 1, 2, 3, 42, 323, 2, 1, 3, 3, 3, 2, 2, 1, 1 };
            HashSet<int> nums = new(ints);
            foreach (int i in nums)
                Console.Write($"{i}  ");
            #endregion

            #region Q6
            Console.WriteLine("\n");
            Console.Write("Numbers are Even : ");
            ArrayList arrayList = new ArrayList();
            int[] Int = {1,3,4,2,4,23,90,100,7,9 };
            arrayList.AddRange(Int);
            foreach (int i in Int)
                if (i % 2 != 0)
                    arrayList.Remove(i);
                else
                    Console.Write($"{i}  ");
            #endregion

            #region Q7
            Console.WriteLine("\n");
            Queue<object> queue = new Queue<object>();
            queue.Enqueue(1);
            queue.Enqueue("Apple");
            queue.Enqueue(5.28);
            foreach (object i in queue)
                Console.WriteLine(i);
            #endregion

            #region Q8
            Console.WriteLine("\n");
            int[] numbers=new int[5];
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter Number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine()!);
            }
            Console.WriteLine("Enter th Target : ");
            int target = int.Parse(Console.ReadLine()!);
            Stack<int> S = new Stack<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                S.Push(numbers[i]);
                if (numbers[i] == target)
                {
                    Console.WriteLine($"Target was found successfully and the count = {S.Count}");
                    break;
                }
                if (S.Count == numbers.Length)
                    Console.WriteLine("Target was not found");
            }
            #endregion

            #region Q9
            Console.Write("Enter Size List1 : ");
            int size1 = int.Parse(Console.ReadLine()!);
            Console.Write("Enter Size List2 : ");
            int size2 = int.Parse(Console.ReadLine()!);
            List<int> list1 = new List<int>(size1);
            List<int> list2 = new List<int>(size2);
            Console.WriteLine("Enter Numbers list1 : ");
            for (int i = 0; i < list1.Capacity; i++)
            {
                list1.Add(int.Parse(Console.ReadLine()!));
            }
            Console.WriteLine("Enter Numbers list2 : ");
            for (int i = 0; i < list2.Capacity; i++)
            {
                list2.Add(int.Parse(Console.ReadLine()!));
            }
           
            foreach (int i in list1)
            {
                foreach (int j in list2)
                {
                    if (i == j)
                    {
                        Console.Write($"{i}  ");
                        break;
                    }
                }
            }
            #endregion
            Console.ReadKey();
        }
    }
}
