// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// ибо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// *Примеры:*
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();

Console.Write("Введите первый элемент (1/5): ");
string a1 = Console.ReadLine();
Console.Write("Введите второй элемент (2/5): ");
string a2 = Console.ReadLine();
Console.Write("Введите третий элемент (3/5): ");
string a3 = Console.ReadLine();
Console.Write("Введите четвертый элемент (4/5): ");
string a4 = Console.ReadLine();
Console.Write("Введите пятый элемент (5/5): ");
string a5 = Console.ReadLine();


string[] array = GetArray(a1, a2, a3, a4, a5);
Console.WriteLine();
Console.WriteLine("Изначальный массив: ");
PrintArray(array);

string[] filteredArray = FilterArrayByLength(array, 3);
Console.WriteLine();
Console.WriteLine("Отфильтрованный массив (>= 3 символов): ");
PrintArray(filteredArray);


string[] GetArray(string a1, string a2, string a3, string a4, string a5)
    {
        string[] array = { a1, a2, a3, a4, a5 };
        return array;
    }

void PrintArray(string[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + ", ");
         }
        Console.WriteLine();
    }

string[] FilterArrayByLength(string[] array, int maxLength)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= maxLength)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= maxLength)
            {
                result[index] = array[i];
                index++;
            }
        }

        return result;
    }