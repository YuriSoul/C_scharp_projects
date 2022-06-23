﻿//Функция определяющая максимум из 3-х чисел
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


int a1 = 1000000;
int b1 = 21;
int c1 = 39;

int a2 = 12;
int b2 = 5000;
int c2 = 33;

int a3 = 13;
int b3 = 23;
int c3 = 33;

//С помощью функции Max вычислим максимальное число из трех троек чисел
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.Write(max);
