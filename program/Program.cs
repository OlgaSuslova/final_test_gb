// Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте алгоритма.  

Console.Clear();

string[] array = {"hello", "2", "world", ":-)"};
int sortnumber = 3; 
Console.Write($"[{String.Join(", ", array)}]");


Console.Write(" -> ");

string[] newarray = SortedArray(array, sortnumber);
Console.Write($"[{String.Join(", ", newarray)}]");


////////////////////////////

static string[] SortedArray (string[] array, int sortnumber)
{ 
    string[] newarray = new string [array.Length];
    int count = 0; 
    for (int i = 0; i < array.Length; i++)
        {      
            if(array[i].Length <= sortnumber)
            {
                newarray[count] = array[i];
                count++;        
            }
        }
    Array.Resize(ref newarray, count);
    return newarray; 
}
