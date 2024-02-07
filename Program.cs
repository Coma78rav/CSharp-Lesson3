// Console.Clear();
// System.Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int count = 0, x = n;
// while (x > 0){ // Количество цифр в числе
//     x /= 10; // x = x / 10
//     count ++; 
// }
// // 5239 = 5 * 10^3 + 2 * 10^2 + 3 * 10^1 + 9 * 10^0
// for (int i = count - 1; i >= 0; i--){ // 5239
//     int m = n / Convert.ToInt32(Math.Pow(10, i)); // m = 5239 / 10.0^3 = 5 
//     // Math.Pow(10, i) возводит 10 в степень i
//     n %=Convert.ToInt32(Math.Pow(10, i)); // n = 5239 % 1000 = 329
//     Console.Write($"{m}, ");
// }

// Функция 
// Выведите наиболшее число среди 2х

// int maxDouble(int x, int y){
//     if (x > y)
//         return x;
//     return y;
// }
// // return - возвращает значение откуда была вызвана фнкция!!!
// // return - моментально прекращает работу функции!!!
// int result = maxDouble(12, 18);
// System.Console.WriteLine(result);
// System.Console.WriteLine(maxDouble(-1, 5));
// Console.WriteLine(maxDouble(134, 8));
// Console.WriteLine(maxDouble(-89, 56));

// Задание 1. Совместная работа
// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// void inputArray(int[]array){ // Передача происходит по ссылке
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 1001); // [1, 1000]
// }
// // [2; n // 2] - без делителей в диапазоне - простое
//  bool isPrime(int x){
//     for (int i = 2; i <= x/2; i++){
//         if (x % i == 0)
//             return false;
//     }
//     return true;
//  }
// Console.Clear();
// Console.Write("Введите количество чисел: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int [n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// int count = 0; // вывод количества элементов
// foreach (int element in array){ //таким образом нельзя изменить элементы массива
//     if (isPrime(element))
//          Console.Write($"{element} ");// вывод простых элементов
//             count++;
// }
// Console.WriteLine(count);

// Задание 2. Работа в сессионных залах
// Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7
// void inputArray(int[]array){ // Передача происходит по ссылке
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 1001); // [1, 1000]
// }
// // [2; n // 2] - без делителей в диапазоне - простое
//  bool isPrime(int x){
//     for (int i = 2; i <= x/2; i++){
//         if (x % i == 0)
//             return false;
//     }
//     return true;
//  }
// Console.Clear();
// Console.Write("Введите количество чисел: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int [n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// int count = 0; // вывод количества элементов
// foreach (int element in array){ //таким образом нельзя изменить элементы массива
//     if (element % 10 == 1 && element % 7 == 0)
//             count++;
// }
// Console.WriteLine(count);

// Задание 3. 
// Заполните массив на N (вводится с консоли, не более 8) 
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем. 


void inputArray(int[]array){ 
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10); // [1, 1000]
}

Console.Clear();
Console.Write("Введите количество чисел: ");
int n = int.Parse(Console.ReadLine()!);
if (n > 8){
    Console.Write("Вы ошиблись\nВведите количество чисел: ");
    n = int.Parse(Console.ReadLine()!);
}    
int[] array = new int [n];
inputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// 55944115 -8 цифр
// 5*10^7 + 5*10^6 + 9*10^5 + ... 5*10^0
int resultNumber = 0; int count = array.Length - 1;
for (int i = 0; i < array.Length; i++){
    resultNumber += array[i] * Convert.ToInt32(Math.Pow(10, count));
    count --;
}
Console.WriteLine(resultNumber);
