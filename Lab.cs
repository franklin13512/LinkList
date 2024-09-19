using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProject
{
    internal class Lab
    {
        static void Main()
        {

            ////动态数组测试
            //MyList1<string> NameList = new MyList1<string>();
            //NameList.AddAtLast("A");
            //NameList.AddAtLast("B");
            //NameList.AddAtLast("C");
            //NameList.AddAtLast("D");
            //NameList.AddAtLast("E");
            //NameList.AddAtLast("F");
            //NameList.AddAtLast("r");
            ////NameList.AddAtLast("y");
            ////NameList.AddAtLast("k");

            //Console.WriteLine(NameList.Number);
            //Console.WriteLine(NameList.Capacity);

            //for(int i = 0;i < NameList.Number ;i++)
            //{
            //    Console.WriteLine(NameList[i]);
            //}

            //Console.ReadLine();

            //单链表测试
            Link<int> MyLink = new Link<int>();
            MyLink.AddAtFirst(1);
            MyLink.AddAtFirst(2);
            MyLink.AddAtFirst(3);
            MyLink.AddAtFirst(4);

            MyLink.Add(2, 10);

            MyLink.RemoveByIndex(2);
            MyLink.RemoveByData(3);

            Console.WriteLine(MyLink);
            Console.WriteLine(MyLink.Count);
            Console.ReadLine();
        }
    }
}
