//new int[10]; - создайновый массив в котором будет 10 эелементов
void FillArrey(int[] collection) 
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    collection[index] = new Random().Next(1, 10);    // Обращаемся к арументу collectin на позиции index и кладем туда новое случайное целое число издиапозона 1-10 
    
    index++;
}
void PrintArray(int[] col) // Метод не возвращающий значения, принем не используется оператор return
{
    int cuont = col.Length;
    int position = 0;
    while (position < cuont)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int indexOf(int[] collection, int find)
{
    int cuont = collection.Length;
    int index = 0;
    int position = -1;
    while (index < cuont)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArrey(array);
PrintArray(array);
Console.WriteLine();

int pos = indexOf(array, 4);
Console.WriteLine(pos);