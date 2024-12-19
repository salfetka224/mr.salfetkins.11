using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите задание (1-34) или 0 для выхода:");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    // Задание 1: Вложенный класс Address
                    Console.WriteLine("Задание 1: Вложенный класс Address");
                    break;
                case "2":
                    // Задание 2: Статический конструктор для Counter
                    Console.WriteLine("Задание 2: Статический конструктор для Counter");
                    break;
                case "3":
                    // Задание 3: Вложенный класс Engine внутри Car
                    Console.WriteLine("Задание 3: Вложенный класс Engine внутри Car");
                    break;
                case "4":
                    // Задание 4: Вложенный класс Point внутри Geometry
                    Console.WriteLine("Задание 4: Вложенный класс Point внутри Geometry");
                    break;
                case "5":
                    // Задание 5: Абстрактный класс Shape с вложенным Circle
                    Console.WriteLine("Задание 5: Абстрактный класс Shape с вложенным Circle");
                    break;
                case "6":
                    // Задание 6: Класс Database с статическим методом Connect
                    Console.WriteLine("Задание 6: Класс Database с статическим методом Connect");
                    break;
                case "7":
                    // Задание 7: Класс Logger с методом Log
                    Console.WriteLine("Задание 7: Класс Logger с методом Log");
                    break;
                case "8":
                    // Задание 8: Вложенный класс Inner внутри Outer
                    Console.WriteLine("Задание 8: Вложенный класс Inner внутри Outer");
                    break;
                case "9":
                    // Задание 9: Паттерн Singleton
                    Console.WriteLine("Задание 9: Паттерн Singleton");
                    break;
                case "10":
                    // Задание 10: Класс Matrix с вложенным MatrixOperation
                    Console.WriteLine("Задание 10: Класс Matrix с вложенным MatrixOperation");
                    break;
                case "11":
                    // Задание 11: Класс Game с вложенным Player
                    Console.WriteLine("Задание 11: Класс Game с вложенным Player");
                    break;
                case "12":
                    // Задание 12: Класс Product с вложенным Category
                    Console.WriteLine("Задание 12: Класс Product с вложенным Category");
                    break;
                case "13":
                    // Задание 13: Класс Expression с вложенными классами для выражений
                    Console.WriteLine("Задание 13: Класс Expression с вложенными классами для выражений");
                    break;
                case "14":
                    // Задание 14: Система кэширования
                    Console.WriteLine("Задание 14: Система кэширования");
                    break;
                case "15":
                    // Задание 15: Класс Cache с вложенным CacheItem
                    Console.WriteLine("Задание 15: Класс Cache с вложенным CacheItem");
                    break;
                case "16":
                    // Задание 16: Программа с библиотекой
                    Console.WriteLine("Задание 16: Программа с библиотекой");
                    break;
                case "17":
                    // Задание 17: Класс TemperatureConverter
                    Console.WriteLine("Задание 17: Класс TemperatureConverter");
                    break;
                case "18":
                    // Задание 18: Класс StringHelper
                    Console.WriteLine("Задание 18: Класс StringHelper");
                    break;
                case "19":
                    // Задание 19: Класс MathUtils с методом Factorial
                    Console.WriteLine("Задание 19: Класс MathUtils с методом Factorial");
                    break;
                case "20":
                    // Задание 20: Класс EmailValidator
                    Console.WriteLine("Задание 20: Класс EmailValidator");
                    break;
                case "21":
                    // Задание 21: Класс DateCalculator
                    Console.WriteLine("Задание 21: Класс DateCalculator");
                    break;
                case "22":
                    // Задание 22: Класс Point с вложенным Point3D
                    Console.WriteLine("Задание 22: Класс Point с вложенным Point3D");
                    break;
                case "23":
                    // Задание 23: Класс Shape с абстрактным методом GetArea и вложенным Circle
                    Console.WriteLine("Задание 23: Класс Shape с абстрактным методом GetArea и вложенным Circle");
                    break;
                case "24":
                    // Задание 24: Класс Employee с вложенным Department
                    Console.WriteLine("Задание 24: Класс Employee с вложенным Department");
                    break;
                case "25":
                    // Задание 25: Класс Order с вложенным OrderItem
                    Console.WriteLine("Задание 25: Класс Order с вложенным OrderItem");
                    break;
                case "26":
                    // Задание 26: Класс Student с вложенным Course
                    Console.WriteLine("Задание 26: Класс Student с вложенным Course");
                    break;
                case "27":
                    // Задание 27: Класс NetworkConfig с сетевыми настройками
                    Console.WriteLine("Задание 27: Класс NetworkConfig с сетевыми настройками");
                    break;
                case "28":
                    // Задание 28: Класс RandomNumberGenerator
                    Console.WriteLine("Задание 28: Класс RandomNumberGenerator");
                    break;
                case "29":
                    // Задание 29: Класс FileHelper с методами для чтения/записи в файл
                    Console.WriteLine("Задание 29: Класс FileHelper с методами для чтения/записи в файл");
                    break;
                case "30":
                    // Задание 30: Класс Calculator с вложенным Operation
                    Console.WriteLine("Задание 30: Класс Calculator с вложенным Operation");
                    break;
                case "31":
                    // Задание 31: Класс Product с вложенным Review
                    Console.WriteLine("Задание 31: Класс Product с вложенным Review");
                    break;
                case "32":
                    // Задание 32: Класс User с вложенным Profile
                    Console.WriteLine("Задание 32: Класс User с вложенным Profile");
                    break;
                case "33":
                    // Задание 33: Класс Game с вложенным Score
                    Console.WriteLine("Задание 33: Класс Game с вложенным Score");
                    break;
                case "34":
                    // Задание 34: Класс Settings со статическими свойствами
                    Console.WriteLine("Задание 34: Класс Settings со статическими свойствами");
                    break;
                case "0":
                    // Выход из программы
                    Console.WriteLine("Выход из программы.");
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }

            Console.WriteLine();
        }
    }
}