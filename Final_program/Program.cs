// Написать программу, которая из имеющегося массива формирует массив из строк, 
// длина которых меньше или равна 3 символа.
// Примеры:
// ["hello", "2", "world", ":-)] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science", "33"] -> ["-2", "33"]
// ["Russia", "UAE", "Denmark", "Kazan", "RSA", "USA"] -> ["UAE", "RSA", "USA"]

int SizeElement(string[] mass)
{
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        int size = mass[i].Length;
        if (size <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] NewArray(string[] arr, int j)
{
    string[] mass = new string[j];
    int n = 0;
    for (int i = 0; i <arr.Length; i++)
    {
        int size = arr[i].Length;
        if (size <= 3)
        {
            mass[n] = arr[i];
            n++;
        }
    }
    return mass;
}

String[] arr = {"hello", "2", "world", ":-)"};
String[] arr2 = {"1234", "1567", "-2", "computer science", "33"};
String[] arr3 = {"Russia", "UAE", "Denmark", "Kazan", "RSA", "USA"};
Console.Write(String.Join(", ", NewArray(arr,SizeElement(arr))));
Console.WriteLine();
Console.Write(String.Join(", ", NewArray(arr2,SizeElement(arr2))));
Console.WriteLine();
Console.Write(String.Join(", ", NewArray(arr3,SizeElement(arr3))));
