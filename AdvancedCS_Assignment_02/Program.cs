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
            Console.ReadKey();
        }
    }
}
