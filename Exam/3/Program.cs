using System;

namespace _3
{
    // The third and fourth conditions of the task.
    public class Program
    {
        public static void Main()
        {
            ISortable sortInt = new IntegerSort();
            ISortable sortString = new StringSort();

            object[] arrayInt = { 10, 1, 80, 0 };
            string[] arrayString = { "Ivan", "Asen", "Georgi", "Boro", "Pepo" };

            sortString.Sort(arrayString);
            sortInt.Sort(arrayInt);


            for (int i = 0; i < arrayInt.Length; i++)
            {
                Console.WriteLine(arrayInt[i]);
            }

            for (int i = 0; i < arrayString.Length; i++)
            {
                Console.WriteLine(arrayString[i]);
            }
        }
    }
}
