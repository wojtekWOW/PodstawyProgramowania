using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie19
{
    class GnomeSort
    {
        internal static void SwapItems(ref int p1, ref int tempp1, ref int[] array)
        {
            tempp1 = array[p1];
            array[p1] = array[p1 + 1];
            array[p1 + 1] = tempp1;
        }

        internal static void MoveRight(ref int p1)
        {
            p1++;
        }

        internal static void MoveLeft(ref int p1)
        {
            if (p1 > 0)
                p1--;
        }
    }
}
