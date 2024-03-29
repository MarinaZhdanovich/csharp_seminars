﻿/*
1. Константные (сумма чисел от 1 до n) - O(1)
2. Линейные (сумма чисел от 1 до n) - O(n)
3. Квадратичные (сортировка пузырьком, выбором, вставками) - O(n^2)
4. Логарифмические (Бинарный поиск) - O(log2(n))
5. Линейно-логарифмические(Быстрая сортировка) - O(n * log2(n))
6. Кубические(заполнение трехмерного массива)
Сложность алгоритма - это кол-во действий, которое необходимо выполнить, для получения
конечного результата.
*/

// 1. O(1)
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Результат: {(1 + n) / 2.0 * n}");

// 2. O(n)
int result = 0; 
for (int i = 1; i <= n; i++)
    result += i;
Console.WriteLine($"Результат: {result}");

// 4. Загадали число 67.

// -> 1
// -> 100
// от 1 до 100
// 50? - да от 50 до 100
// 75? - нет от 50 до 75
// 62? - да  от 62 до 75
// 68? - нет от 62 до 68
// 65? - да  от 65 до 68
// 66? - да  от 66 до 68
// 67? - нет = 67
// O(log2(n)) -> log2(100) -> 7
// 1000 -> 10
// 2000 -> 11


// 5. O(n * log2(n))

// [4, 21, -3, 56, 78, 5]
// Опорный элемент = 4
// [-3] + [4] + [21, 56, 78, 5]
// [21, 56, 78, 5]
// Опорный элемент = 21
// [5] + [21] + [56, 78]
// [-3] + [4] + [5] + [21]
// Опорный элемент = 56
// [] + [56] + [78]
// [-3] + [4] + [5] + [21] + [56] + [78]


// 3. O(n ^ 2)

/* 
[4, 21, -3, 56, 78, 5]
4 < 21
21 < -3!!! -3 <-> 21
[4, -3, 21, 56, 78, 5]
21 < 56
56 < 78
78 < 5!!! 5 <-> 78
[4, -3, 21, 56, 5, 78]
4 < -3 !!! -3 <-> 4
[-3, 4, 21, 56, 5, 78]
4 < 21
21 < 56
56 < 5 !!! 5 <-> 56
[-3, 4, 21, 5, 56, 78]
56 < 78
-3 < 4
4 < 21
21 < 5 !!! 5 <-> 21
[-3, 4, 5, 21, 56, 78]
*/