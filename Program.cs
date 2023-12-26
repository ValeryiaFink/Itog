//1. Создать репозиторий на GitHub
//2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
//3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
//4. Написать программу, решающую поставленную задачу
//5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 
//3, и 4 должны быть расположены в разных коммитах)
//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []


using System;

class Program
{
    static void Main()
    {
        string input;
        Console.WriteLine("Введите элементы массива через запятую:");
        input = Console.ReadLine() ?? string.Empty;
        string[] inputArray;
        if (!string.IsNullOrEmpty(input))
        {
            inputArray = input.Split(',');
            string[] resultArray = FilterStrings(inputArray);
            Console.WriteLine("Новый массив строк:");
            foreach (string str in resultArray)
            {
                Console.WriteLine(str);
            }
        }
        else
        {
            Console.WriteLine("Введен пустой массив.");
        }
    }
    static string[] FilterStrings(string[] input)
    {
        int count = 0;
        foreach (string str in input)
        {
            if (!string.IsNullOrWhiteSpace(str) && str.Trim().Length <= 3)
            {
                count++;
            }
        }
        string[] result = new string[count];
        int index = 0;
        foreach (string str in input)
        {
            if (!string.IsNullOrWhiteSpace(str) && str.Trim().Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }
        return result;
    }
}
