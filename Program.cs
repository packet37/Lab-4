using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ёмкость массива:");
            int capacity = int.Parse(Console.ReadLine());
            DynamicArray array = new DynamicArray(capacity); array.Populate(1, 5);
            Console.WriteLine("Массив после заполнения значениями от 1 до 5:");
            for (int i = 0; i < array.Count(); i++)
            {
                Console.Write(array.Get(i) + " ");
            }
            Console.WriteLine();

            array.Add(6);
            Console.WriteLine("Массив после добавления 6:");
            for (int i = 0; i < array.Count(); i++)
            {
                Console.Write(array.Get(i) + " ");
            }
            Console.WriteLine();

            array.Remove();
            Console.WriteLine("Массив после удаления последнего элемента:");
            for (int i = 0; i < array.Count(); i++)
            {
                Console.Write(array.Get(i) + " ");
            }
            Console.WriteLine();

            array.Insert(2, 10);
            Console.WriteLine("Массив после вставки 10 в индекс 2:");
            for (int i = 0; i < array.Count(); i++)
            {
                Console.Write(array.Get(i) + " ");
            }
            Console.WriteLine();

            array.Delete(3);
            Console.WriteLine("Массив после удаления элемента по индексу 3:");
            for (int i = 0; i < array.Count(); i++)
            {
                Console.Write(array.Get(i) + " ");
            }
            Console.WriteLine();

            array.DeleteValue(2);
            Console.WriteLine("Массив после удаления элемента со значением 2:");
            for (int i = 0; i < array.Count(); i++)
            {
                Console.Write(array.Get(i) + " ");
            }
            Console.WriteLine();

            int[] max = array.Max();
            Console.WriteLine($"Максимальное значение в массиве {max[1]} с индексом {max[0]}");

            Console.WriteLine($"Массив заполнен?: {array.IsFull()}");

            Console.WriteLine($"Количество элементов в массиве: {array.Count()}");
        }
    }
}