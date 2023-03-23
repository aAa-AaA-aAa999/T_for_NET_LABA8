using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8_W
{
    public class Array_Class<T>
    {

        public T[] array;

        public Array_Class(int size)
        {
            array = new T[size];
        }
        public void AddElem(int index, T item) // Добавление элементов
        {
            array[index] = item;
        }
        public void DeleteElem(T item) // удаление элемента
        {
            int index = Array.IndexOf(array, item);
            if (index > -1)
            {
                T[] newItem = new T[array.Length - 1];
                for (int i = 0, j = 0; i < array.Length; i++)
                {
                    if (i == index) continue;
                    newItem[j] = array[i];
                    j++;
                }
                array = newItem;
            }
        }
        public T GetElem(int index) // получение элемента
        {
            return array[index];
        }
        public int GetLength() // получение длинны
        {
            return array.Length;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Array_Class<int> array_int = new Array_Class<int>(4);
            array_int.AddElem(0, 3);
            Array_Class<string> array_string = new Array_Class<string>(5);
            array_string.AddElem(0, " zzz ");
            Array_Class<double> array_double = new Array_Class<double>(6);
            array_double.AddElem(0, 1.2);

        }
    }
}
