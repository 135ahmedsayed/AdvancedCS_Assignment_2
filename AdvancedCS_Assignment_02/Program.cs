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
            Console.ReadKey();
        }
    }
}
