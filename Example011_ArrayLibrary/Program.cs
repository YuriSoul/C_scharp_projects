//Метод заполняющая массив числами 
void FillArray(int[]collection)
{
    int length = collection.Length; //Получаем длину массива
    int index = 0; //Устанавливаем позицию индекса массива в начало

    //Цикл для заполнения массива случайными цислами 
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

//Метод выводящий заполненный массив на печать
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;

    while (position < count)
    {
        Console.Write(coll[position] + ", ");
        position++;
    }
} 

//метод поиска позиции заданного числа в массиве
//в качестве аргументов передаем сгенерированный массив collection и заданное число для поиска
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;//Если элнмент не найден то выведем -1

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
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
Console.Write(pos);
