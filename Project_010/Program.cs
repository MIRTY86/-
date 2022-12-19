int[] array = {1,3,5,7,8,5,6};

int n = array.Length;
int find = 4;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
    Console.WriteLine(index);
    break;
    }


    index++;
}
