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
            list.Insert(index, newElement);
        }
    }
}
