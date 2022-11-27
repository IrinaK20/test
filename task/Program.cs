/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

int G = 3; // длина строки нового массива. Если поменяется условие, то так будет проще все изменить 
int size = 3; // размер массива
string[] FirstArray = new string[size]; // создали массив 

Console.WriteLine($"введите набор символов {size} раз(-а), через 'Enter'");

FillArray(FirstArray);
//FillArrayRandom(FirstArray);  // запонение массива рандомно  
Console.Clear();
PrintArray(FirstArray);
Console.WriteLine();
Console.WriteLine("новый массив: ");

if (SecondArraySize(FirstArray) == 0)
{
    Console.WriteLine("элементов для переноса в новый массив - нет");
}
else
{
    string[] SecondArray = MovingElements(FirstArray);
    PrintArray(SecondArray);
}

/*void FillArrayRandom (string[] array)
{
    Random random =new Random();
   string AllSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
   for (int i = 0; i < size; i++)
    {
        int randomElemSize = random.Next(1,6);
        for (int j = 0; j < randomElemSize; j++)
        {
            array[i] += AllSymbols[random.Next(0,AllSymbols.Length)];
        }        
}
}*/

void FillArray(string[] array)   // заполнение массива 
{
    for (int i = 0; i < size; i++)
    {
        array[i] = Console.ReadLine() ?? "";
    }
}

void PrintArray(string[] array)    // печать массива 
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

int SecondArraySize(string[] array) // для получения размера второго массива, используем int чтобы можно было вернуть secondSize
{
    int secondSize = 0; // подсчитывает размер второго массива 
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= G)
        {
            secondSize++;
        }
    }
    return secondSize;
}

string[] MovingElements(string[] array)
{
    string[] SecondArray = new string[SecondArraySize(FirstArray)];

    for (int i = 0, j = 0; i < size; i++)      // i каждый шаг 
    {                                        // j будет только при выпонении if
        if (array[i].Length <= G)
        {
            SecondArray[j] = array[i];
            j++;
        }
    }
    return SecondArray;
}
