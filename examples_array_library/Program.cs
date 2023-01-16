﻿void FillArray (int[] collection)

{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next (1,10);
        //index = index + 1 
        index ++;
    }
}
void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine( col [position]);
        position++;
    }
}

int IndexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection [index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10];

FillArray (array);
array [3] = 7;
array [5] = 7;

PrintArray (array);
System.Console.WriteLine();

int pos = IndexOf (array, 7);
System.Console.WriteLine(pos);