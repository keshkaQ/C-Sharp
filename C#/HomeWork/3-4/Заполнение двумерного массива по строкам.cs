//class Program
//{
//    static void Main()
//    {
//        const int Rows = 5;
//        const int Cols = 5;
//        int value = 1;

//        var array2d = new int[Rows, Cols];

//        Console.WriteLine("Array before:");
//        for (int i = 0; i < Rows; i++)
//        {
//            for (int j = 0; j < Cols; j++)
//            {
//                Console.Write($"{array2d[i, j]}\t");
//            }
//            Console.WriteLine();
//        }

//        for (int i = 0; i < Rows; i++)
//        {
//            if (i % 2 == 0)
//            {
//                for (int j = 0; j < Cols; j++)
//                {
//                    array2d[i, j] = value;
//                    value++;
//                }
//            }
//            else
//            {
//                for (int j = Cols - 1; j >= 0; j--)
//                {
//                    array2d[i, j] = value;
//                    value++;
//                }
//            }
//        }

//        Console.WriteLine("Array after:");
//        for (int i = 0; i < Rows; i++)
//        {
//            for (int j = 0; j < Cols; j++)
//            {
//                Console.Write($"{array2d[i, j]}\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}