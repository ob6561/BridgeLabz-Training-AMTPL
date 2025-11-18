using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Generic
{
    internal class Reverse_array
    {
        public static T[] ReverseArrayCopy<T>(T[] array)
        {
            T[] reversed = new T[array.Length];
            int j = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversed[j] = array[i];
                j++;
            }

            return reversed;
        }

    }
}
