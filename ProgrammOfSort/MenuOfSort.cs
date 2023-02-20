class MenuTask
{
    private static int[] arr = new int[10];
    public static void Menu(ref int code)
    {
        while (true)
        {
            Console.WriteLine("1 - Заполнить массив. \n2 - Вывести массив. \n3 - Cортировка выбором.\n4 - Пирамидальная сортировка.\n5 - Сортировка пузырьком.\n6 - Шейкер сортировка.\n7 - Выход.");
            Console.Write("Введите код операции: ");
            code = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (code)
            {
                case 1:
                    CreateArray(ref arr);
                    continue;
                case 2:
                    Print(arr);
                    continue;
                case 3:
                    SortChoice(ref arr);
                    continue;
                case 4:
                    continue;
                case 5:
                    BubbleSort(ref arr);
                    continue;
                case 6:
                    ShakerSort(ref arr);
                    Console.WriteLine();
                    continue;
                case 7:
                    Console.WriteLine("Выход из программы.");
                    Console.WriteLine();
                    continue;
                default:
                    Console.WriteLine("Ошибка. Неизвестный код операции.");
                    Console.WriteLine();
                    continue;
            }
        }
    }
    private static void CreateArray(ref int[] arr)
    {
        Console.WriteLine($"Заполните массив {arr.Length} элементами:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Введите элемент на {i} позицию:\t");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Заполнение окончено.");
        Console.WriteLine();
    }
    private static void Print(int[] arr)
    {
        Console.WriteLine("Вывод массива:");
        foreach (int e in arr)
            Console.WriteLine(e);
        Console.WriteLine();
    }
    private static void SortChoice(ref int[] arr)
    {
        int indexOfMin;
        for (int i = 0; i < arr.Length; i++)
        {
            indexOfMin = i;
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[j] < arr[indexOfMin])
                {
                    indexOfMin = j;
                }
            }
            if (arr[indexOfMin] == arr[i])
                continue;

            int temp = arr[i];
            arr[i] = arr[indexOfMin];
            arr[indexOfMin] = temp;
        }
        Console.WriteLine("Сортировка завершена.");
        Console.WriteLine();
    }
    private static void HeapSort(ref int[] arr)
    {
        // не сделал
    }
    private static void BubbleSort(ref int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int k = 0; k < arr.Length - 1 - i; k++)
            {
                if (arr[k] > arr[k + 1])
                {
                    int replacingNum = arr[k];
                    arr[k] = arr[k + 1];
                    arr[k + 1] = replacingNum;
                }
            }
        }
        Console.WriteLine("Сортировка завершена.");
        Console.WriteLine();
    }
    static void Swap(ref int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
    static void ShakerSort(ref int[] arr)
    {
        int left = 0,
        right = arr.Length - 1;
        while (left < right)
        {
            for (int i = left; i < right; i++)
            {
                if (arr[i] > arr[i + 1])
                    Swap(ref arr, i, i + 1);
            }
            right--;
            for (int i = right; i > left; i--)
            {
                if (arr[i - 1] > arr[i])
                    Swap(ref arr, i - 1, i);
            }
            left++;
        }
        Console.WriteLine("Сортировка завершена.");
        Console.WriteLine();
    }
}