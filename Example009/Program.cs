// See https://aka.ms/new-console-template for more information

/*int Max(int arg1, int arg2, int arg3)
{
        int result = arg1;
        if (arg2 > result) result = arg2;
        if (arg3 > result) result = arg3;
        return result;
}

int[] array = {11,123,2,176,44,21,5,6,145};
*/

void FillArray(int[] collection)

{
    int lenguth = collection.Length;
    int index = 0;
    while (index < lenguth)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
        
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int IndexOf(int[] colection, int find)
{
    int count = colection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(colection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
