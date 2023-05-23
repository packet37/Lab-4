using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class DynamicArray
    {
        private int[] array;    // Массив для хранения элементовв
        private int size;       // Текущее количество элементов в массиве
        private int capacity;   // Максимальное количество элементов, которое может храниться в массиве

        // Конструктор: для создания нового динамического массивв указанной емкости
        public DynamicArray(int capacity)
        {
            this.array = new int[capacity];
            this.size = 0;
            this.capacity = capacity;
        }

        // Метод автоматического заполнения массива в пределах заданного числового диапазона
        public void Populate(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Add(i);
            }
        }

        // Метод для чтения элемента по индексу
        public int Get(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException();
            }
            return array[index];
        }

        // Метод для записи элемента по индексу
        public void Set(int index, int value)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException();
            }
            array[index] = value;
        }

        // Метод для добавления элемента в конец массива
        public void Add(int element)
        {
            // Проверяем, заполнен ли массив, если да, увеличить емкость
            if (size == capacity)
            {
                int newCapacity = capacity * 2;
                int[] newArray = new int[newCapacity];
                for (int i = 0; i < size; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
                capacity = newCapacity;
            }
            array[size] = element;
            size++;
        }

        // Метод для удаления элемента с конца массива
        public void Remove()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            size--;
        }

        // Метод для вставки элемента по индексу
        public void Insert(int index, int element)
        {
            if (index < 0 || index > size)
            {
                throw new IndexOutOfRangeException();
            }
            // Проверяем, заполнен ли массив, если да, увеличить емкость
            if (size == capacity)
            {
                int newCapacity = capacity * 2;
                int[] newArray = new int[newCapacity];
                for (int i = 0; i < size; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
                capacity = newCapacity;
            }
            // Сдвигаем элементы вправо, чтобы освободить место для нового элемента
            for (int i = size - 1; i >= index; i--)
            {
                array[i + 1] = array[i];
            }
            array[index] = element;
            size++;
        }

        // Метод для удаления элемента по индексу
        public void Delete(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException();
            }
            // Сдвигаем элементы влево, чтобы заполнить пробел
            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }
            size--;
        }
        // Метод для удаления элемента по значению
        public void DeleteValue(int value)
        {
            for (int i = 0; i < size; i++)
            {
                if (array[i] == value)
                {
                    Delete(i);
                }
            }
        }
        // Метод для возврата максимального значения и его индекса в массиве
        public int[] Max()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            int maxIndex = 0;
            for (int i = 1; i < size; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return new int[] { maxIndex, array[maxIndex] };
        }

        // Метод для проверки на переполнение
        public bool IsFull()
        {
            return size == capacity;
        }

        // Метод для возврата фактического количества элементов в массиве
        public int Count()
        {
            return size;
        }
    }
}