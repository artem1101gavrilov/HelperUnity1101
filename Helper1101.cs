using System;
using System.Collections.Generic;

namespace Helper1101
{
    public static class List1101
    {
        /*
         Пример обращения :  list.Add(3, 5);
         Допустим был массив 1 2 3 4 5 
         После операции станет 1 2 3 4 5 3
         */
        public static void Add<T>(this List<T> list, T newElement, int index)
        {
            //Если размер меньше, то выходим
            if (index > list.Count) return;
            var lastIndex = list.Count - index;

            //Разбиваю лист на массивы
            T[] arr1 = new T[index];
            T[] arr2 = new T[lastIndex];
            list.CopyTo(0, arr1, 0, index);
            list.CopyTo(index, arr2, 0, lastIndex);

            //Объединение двух массивов и нового числа
            list.Clear();
            list.AddRange(arr1);
            list.Add(newElement);
            list.AddRange(arr2);
        }
    }
}