using System;
using System.Text;
// 下述兩個為最重要的兩個命名空間之引用 –> 核心
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 新增電腦品牌清單至 List<T> 中，成為一個陣列集合物件體
            List<string> PCList = new List<string>();
            PCList.Add("Acer");
            PCList.Add("IBM");
            PCList.Add("ASUS");
            PCList.Add("HP");
            PCList.Add("Lemel");
            PCList.Add("XPC");
            PCList.Add("Seed");
            PCList.Add("Sony");
            PCList.Add("Toshiba");
            PCList.Add("Giga");
            PCList.Add("Vento");
            PCList.Add("Fujitsu");
            PCList.Add("Dell");
            PCList.Add("Apple");
            PCList.Add("Lenovo");


            // 列出電腦清單內容
            Console.WriteLine("→ 原始 PCList 陣列清單");
            foreach (string listone in PCList)
            {
                Console.Write(listone + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // 建立 Linq 語法，並篩選出只有 S 開頭的電腦品牌名稱至 S_BrankPC 中
            IEnumerable<string> S_BrandPC =
                from temp_VarEnum in PCList
                where temp_VarEnum.StartsWith("S")
                select temp_VarEnum;

            Console.WriteLine("→ S 開頭的電腦品牌有：");

            // 列印出其結果
            foreach (string S_PC in S_BrandPC)
            {
                Console.WriteLine(S_PC + ",");
            }

            Console.ReadKey();

        }
    }
}
