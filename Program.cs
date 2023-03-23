//1 Создать обобщенный класс, который может хранить 2 в массиве объекты любого одного типа.
//Данный класс должен иметь методы для 3 добавления данных в массив, 4 удаления из массива,
//5 получения элемента из массива по индексу и метод, 6 возвращающий длину массива.
//7 Создать три объекта - целочисленный массив, строковый массив и массив чисел с плавающей точкой.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8
{
    public class Array_Class<T> //1
    {
        public T[] array; //2

        public Array_Class(int size)
        {
            array = new T[size];
        }
        public void AddElem(int index, T item) // 3
        {
            array[index] = item;
        }
        public void DeleteElem(T item) // 4
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
        public T GetElem(int index) // 5
        {
            return array[index];
        }
        public int GetLength() // 6
        {
            return array.Length;
        }
    }
    internal class Program
    {
        static void Main(string[] args) //7
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
