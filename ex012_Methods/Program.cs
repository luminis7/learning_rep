﻿/*
void Method1()
{
    Console.WriteLine("Текст сообщения");
}
// Method1();

void Method2(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method2(msg: "Текст сообщения", count: 3);

void Method21(string msg)
{
    Console.WriteLine(msg);
}
// Method21("Текст сообщения");

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
*/
// Console.WriteLine(year);
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while( i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(5, "a");
Console.WriteLine(res);
*/
/*
string Method41(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method41(4, "e");
Console.WriteLine(res);

for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{ i } x { j } = {i * j}");
    }
    Console.WriteLine();
}
*/
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
/*
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();
*/

int[] arr = {7, 4, 2, 6, 2, 1, 4, 8, 2};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for(int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
