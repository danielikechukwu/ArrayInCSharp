using System;

namespace CSharpCode
{
    class GeeksArray
    {
        public static void Main(string[] args)
        {
            int[] myArr = new int[] {1,2,34};

            int[] myArr1 = { 1, 2, 34 };

            var myArr2 = new int[] { 3, 4,4};

            int[] myArr3 = {1,2,3,4,5};

            int[] myArr4;

            myArr4 = new int[8] {2,3,4,4,5,6, 7,4};

            string[] myNames = new string[] { "peter", "jojo", "stephen", "kelly", "Ben", "jane" };

            foreach (string i in myNames)
            {
                Console.WriteLine(i);
            };

            Console.WriteLine(myArr.Length);

        }
    }
}