using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System
{
    public static class ListExtension
    {
        private static readonly Random _random = new Random();
        public static void Shuffle<T>(this List<T> list) 
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = _random.Next(n + 1);
                (list[k], list[n]) = (list[n], list[k]);
            }
        }
        public static List<T> GetTop<T>(this List<T> list, int count, Func<T, int> selector) => list.OrderByDescending(selector).Take(count).ToList();
        public static List<T> GetRandom<T>(this List<T> list, int count)
        { 
            var newList = new List<T>(list);
            var returnedList = new List<T>();
            while (count>0)
            {
                count--;
                T selectedItem = newList[_random.Next(newList.Count + 1)];
                returnedList.Add(selectedItem);
                newList.Remove(selectedItem);
            }
            return returnedList;
        }
    }
}
