int[] array = { 1, 24, 45, 14, 45, 56, 45, 78 };

int n = array.Length;
int find = 45;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;    
    }
    // index = index + 1;
    index++;
}