/* 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int length = Prompt("Введите количество элементов в массиве > ");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");

// Метод для запроса у пользователя ввода и дальнейшнго преобразования введённого в целое число
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

// Метод для заполнения массива элементами, которые ввёл пользователь
int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1}-й элемент: ");
    }
    return array;
}

// Метод для вывода сформированного массива на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i}] = {array[i]}");
    }
}

// Метод нахождения положительных (больше нуля) чисел
int CountPositiveNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > 0) count++;
    }
    return count;
}
