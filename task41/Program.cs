void CreateArray(int[] array)
{
    for(int i = 0; i<array.Length; i++){
        Console.WriteLine($"Введите {i+1} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void FindPos(int[] array, int count)
{
    for(int i = 0; i<array.Length; i++){
        if(array[i]>0) count++;
    }
    Console.WriteLine($"Количество чисел больше 0: {count}");
}

Console.Clear();
Console.WriteLine("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
CreateArray(arr);
Console.WriteLine($"[{string.Join(", ", arr)}]");
int count = 0;
FindPos(arr, count);