// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:

//     [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//     [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//     [“Russia”, “Denmark”, “Kazan”] → []

string[] ShrinkArray(string[] array, int count)
{
    var result = new string[count];

    for (int i = 0; i < count; i++)
        result[i] = array[i];

    return result;
}


string[] FilterStringsArray(string[] array)
{
    var resultArray = new string[array.Length];
    var resultIndex = 0;

    int index = 0;

    while (index < array.Length)
    {
        if (array[index].Length <= 3)
        {
            resultArray[resultIndex] = array[index];
            resultIndex++;
        }
        index++;
    }

    return ShrinkArray(resultArray, resultIndex);
}

var MaxStrings = 100;

var inputArray = new string[MaxStrings];

System.Console.WriteLine("Введите строки в массив (не более 100):");

var k = 0;
while (true)
{
    if (k >= MaxStrings)
    {
        System.Console.WriteLine("Ошибка! Введено слишком много строк");
        return;
    }

    Console.Write("Строка: ");
    var s = Console.ReadLine();
    if (string.IsNullOrEmpty(s))
        break;

    inputArray[k] = s;
    k++;
}

void PrintStringArray(string[] arr)
{
    System.Console.Write("[");
    System.Console.Write(string.Join(", ", arr));
    System.Console.WriteLine("]");
}

inputArray = new[] { "Hello", "2", "world", ":-)" };
k = 4;
//     [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//     [“Russia”, “Denmark”, “Kazan”] → []

var array = ShrinkArray(inputArray, k);
PrintStringArray(array);
PrintStringArray(FilterStringsArray(array));

