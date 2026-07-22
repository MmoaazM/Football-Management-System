using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System
{
    public static class ListExtension
    {
        public static void Shuffle<T>(this List<T> list) { }
        public static T GetTop<T>(this List<T> list, int count, Func<T, int> selector) {  }
        public static T GetRandom<T>(this List<T> list, int count) { }
    }
}
