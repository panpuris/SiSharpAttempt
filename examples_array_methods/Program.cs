int [] arr = { 1,4,5,3,2,6,7,1,1};

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort (int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j< array.Length; j++)
        {
            if (array [j] < array [minPosition]) minPosition = j;
        }
        int temporary = array [i];
        array[i] = array[minPosition];
        array[minPosition] =  temporary;
    }
}
// Для обработки в обратном порядке от наибольшего к меньшему используется та же самя функиция
// только в if мы ставим знак в большую сторону.
// void SelectionSort (int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int maxPosition = i;
//         for (int j = i+1; j< array.Length; j++)
//         {
//             if (array [j] > array [maxPosition]) maxPosition = j;
//         }
//         int temporary = array [i];
//         array[i] = array[maxPosition];
//         array[maxPosition] =  temporary;
//     }
// }



PrintArray(arr);
SelectionSort(arr);

PrintArray (arr);