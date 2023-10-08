// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 
// 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System.Xml.XPath;

int Enter(string message) {
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int[] FillArray(int length) {
    int[] array = new int[length];
    for (int i=0; i<array.Length; i++) {
        array[i] = Enter($"Введите {i+1}-й элемент массива");
    }
    return array;
}

void PrintArray(int[] array) {
    for (int i=0; i<array.Length; i++) {
        Console.Write(array[i]+ "\t");
    }
    Console.WriteLine();
}

int MoreZero(int[] array) {
    int count = 0;
    for (int i=0; i<array.Length;i++) {
        if (array[i] > 0) {
            count++;
    }
    }
    return count;
}

int length = Enter("Введите количество элементов в массиве");
int[] newArray = FillArray(length);
PrintArray(newArray);
Console.WriteLine($"Элементов в массиве больше 0 - {MoreZero(newArray)}");

