void FillArray(int[] Collection)
{
    int length = Collection.Length;
    int index = 0;
    while(index < length)
    {
        Collection[index] = new Random().Next(1, 10);


        index++;
    }



}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;

    }
}

int IdexOf(int[] Collection, int find)
{
    int count = Collection.Length;
    int index = 0;
    int position = 0;
    while(index < count)
    {
        if(Collection[index] == find)
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

int pos = IdexOf(array, 4);
Console.WriteLine(pos);