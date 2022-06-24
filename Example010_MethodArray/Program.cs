//Функция поиска заданного числа в массиве

//создаем массив
int[] array = { 11, 21, 35, 4, 5, 62, 7, 89, 9 };

int n = array.Length; //получаем размер массива

int find = 62; //задаем число для поиска 

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; //если условие выполняется то происходит прерывание цикла
    } 
    index++;
}



