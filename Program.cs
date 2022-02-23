using System.Collections;

namespace HashtableEx
{
    class Program
    {

        public static void Printout(Hashtable ht)
        {
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine("   Key = {0}\tValue = {1} ", de.Key, de.Value);
            }

        }

        static void Main(string[] args)
        {
            Hashtable HScore = new Hashtable();
            HScore.Add("Tom", 70);
            HScore.Add("Bob", 60);
            HScore.Add("Grace", 80);
            HScore.Add("David", 90);

            // 1.原始資料
            Console.WriteLine("1. 原始資料：");
            Printout(HScore);
            Console.WriteLine("\n");


            while (true)
            {
                Console.Write("請輸入要執行的項目 (1.新增資料 2.刪除資料 3.離開)：");
                int item = int.Parse(Console.ReadLine());

                if (item == 1)
                {
                    // 2.查詢新增作業

                    // (1)若姓名存在
                    Console.Write("請輸入姓名：");
                    string name = Console.ReadLine();
                    if (HScore.ContainsKey(name))
                    {
                        Console.WriteLine("{0} 已存在，成績：{1}，不能重複加入 ...", name, HScore[name]);
                    }
                    else // (2)若姓名不存在
                    {
                        Console.Write("請輸入成績：");
                        int score = int.Parse(Console.ReadLine());
                        HScore.Add(name, score);
                        Console.WriteLine("{0} 資料完成新增 ...");
                        Console.WriteLine("目前資料：");
                        Printout(HScore);
                    }
                }
                else if (item == 2)
                {
                    Console.Write("請輸入姓名：");
                    string name = Console.ReadLine();
                    if (HScore.ContainsKey(name)) // 若資料存在
                    {
                        HScore.Remove(name);
                        Console.WriteLine("{0} 資料已移除 ...", name);
                        Console.WriteLine("目前資料：");
                        Printout(HScore);
                    }
                    else // 若資料不存在
                    {
                        Console.WriteLine("{0} 資料不存在! ...", name);
                        Console.WriteLine("目前資料：");
                        Printout(HScore);
                    }
                }
                else
                {
                    break;
                }
            }
            Console.Read();
        }
    }
}