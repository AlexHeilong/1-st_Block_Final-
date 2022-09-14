// Написать программу, которая из имеющегося массива строк
//  формирует массив из строк, длина которых меньше либо равна 3 символам

string[] array = new string[5] {"123", "23", "hello", "world", "res"};

string  [] CreateNewArray(string [] array)
{
    string[] newArray = new string [array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[i] = array[i];
            count++;
        }
    }
    return newArray;
}

void ShowArray(string [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

ShowArray(array);
ShowArray(CreateNewArray(array));
