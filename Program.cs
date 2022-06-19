// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа

// Предполагается, что начальный массив не может быть нулевым

string[] ArrayLessThreeSymbol(string[] arr) {
    string[] totalArr = new string[0];
    foreach (string item in arr)
    {
        if (item.Length <= 3) {
            totalArr = IncreaseArrayLength(totalArr);
            totalArr[totalArr.Length - 1] = item;
        }
    }
    return totalArr;
}

string[] IncreaseArrayLength(string[] array) {
    int j = array.Length;
    string[] newArray = new string[j + 1];
    for (int i = 0; i < j; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

void PrintArray(string[] arr) {
    if (arr.Length > 0) {
        foreach (string item in arr)
        {
            Console.Write ($"{item} ");
        }
        Console.WriteLine();
    } else {
        Console.WriteLine("");
    }
}

string[] arr1 = {"hello", "2", "world", ":-)"};
string[] arr2 =  {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};

PrintArray(ArrayLessThreeSymbol(arr1));
PrintArray(ArrayLessThreeSymbol(arr2));
PrintArray(ArrayLessThreeSymbol(arr3));