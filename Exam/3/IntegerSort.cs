

using System;

namespace _3
{
    public class IntegerSort : ISortable
    {
        public void Sort(object[] array)
        {
            int temp;

            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if ((int)array[i] > (int)array[i + 1])
                    {
                        temp = (int)array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
    }
}
