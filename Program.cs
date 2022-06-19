// Заменить положительные элементы массива на отрицательные

int [] array = new int [5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
}
void PrintArray(int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}

void Change()
{
for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
}
}

PrintArray(array);
Console.WriteLine();
Change();
PrintArray(array);