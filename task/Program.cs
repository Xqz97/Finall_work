/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше или равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

string[] FormationArray(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            size++;
        }
    }

    string[] array_1 = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            array_1[j] = array[i];
            j++;
        }
    }
    return array_1;
}

string[] array_2 = { "Один", "Два", "Три", "4", "Пять", "6", };
PrintArray(FormationArray(array_2));
