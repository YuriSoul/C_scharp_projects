//Функция определяющая максимум из 3-х чисел
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1; //пусть в начале arg1 будет пердположительно
    //максимальным числом из 3-х. Присвоим его нашему result 
    //далее будем сравнивать числа с нашим максимальным которое хранится в result
    //и если текущее число больше result то перепишем его в result как новое максимальное
    //так будем проверять все числа пока не определим максимальное.
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;

    return result;
}

//              0   1   2   3  4  5   6  7   8
int [] array = {11, 21, 35, 4, 5, 62, 7, 89, 9};

//С помощью функции Max вычислим максимальное число из трех троек чисел
int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.Write(max);
