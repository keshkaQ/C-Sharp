//// Массив
//var array3 = new int[4] { 4, 5, 9, 20 }; //инициализицая по умолчанию

//var array1 = new int[5];
//array1[0] = 1; // O()
//var array2 = new int[6];

//for (int i = 0; i < 5; i++)
//{
//    array2[i] = array1[i];
//}
//array2[5] = 3; // О(n)

//// Алгоритм ищет элемент key в массиве arr, но с одной хитростью
//// — он временно заменяет последний элемент искомым значением,
//// чтобы гарантировать, что цикл остановится,
//// даже если элемента нет в массиве.

////Преимущества метода - не надо проверять границы, одно условие для проверки
//int LinearSearch(int[] arr, int size, int key)
//{
//    //for(int i = 0; i < size -1; i++)
//    //{
//    //    if (arr[i] == key)
//    //    {
//    //        return i;
//    //    }
//    //}
//    //return -1;

//    // Как упростить
//    int last = arr[size - 1];
//    arr[size - 1] = key;
//    int i = 0;
//    while (arr[i] != key)
//    {
//        i++;
//    }
//    arr[size - 1] = last;
//    if (i < size - 1 || arr[size - 1] == key)
//    {
//        return i;
//    }
//    return -1;
//}

//// Двумерные массивы
//var array2D = new int[2, 3]; // 2 строки, 3 столбца
//// Перебор элементов
//for(int i = 0; i < array2D.Length; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        array2D[i, j] = 1;
//    }
//}

