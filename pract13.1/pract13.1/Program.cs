using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pract13._1
{
    class Program
    {
        static int Check()
        {
            while (true) {
                try
                {
                    int value = int.Parse(Console.ReadLine());
                    if (value < 0)
                        Console.WriteLine("Введите число больше нуля");
                    else
                        return value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели не число");
                }
            }
        }
        static void Pract13(ArrayList list)
        {
            ArrayList mylist = new ArrayList();
            Console.WriteLine("Введите количество элементов в списке ");
            int n = Check();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i} элемент списка");
                mylist.Add(Console.ReadLine());
            }
            Console.WriteLine("С какого элемента вставить новый лист?");
            int num = Check();
            list.InsertRange(num - 1, mylist);
            Console.WriteLine();
            foreach (object e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Сколько элементов удалить?");
            int k = Check();
            int n1 = n / 2;
            for(int i = 0; i < k; i++)
            {
                list.RemoveAt(n1);
            }
            Console.WriteLine();
            foreach (object e in list)
            {
                Console.WriteLine(e);
            }
        }
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(4.5);
            list.Add(18);
            list.AddRange(new string[] { "Студент", "Петров" });

            foreach(object e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
            list.RemoveAt(0);
            list.Reverse();
            Console.WriteLine(list[1]);
            Console.WriteLine();
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Pract13(list);
            Console.ReadKey();
        }
    }
}
