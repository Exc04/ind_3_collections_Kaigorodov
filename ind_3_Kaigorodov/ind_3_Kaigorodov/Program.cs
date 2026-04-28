using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ind_3_Kaigorodov
{
    internal class Program
    {
        static IntArray arr1 = null;
        static IntArray arr2 = null;

        static void Main(string[] args)
        {
            Console.WriteLine("=== ОДНОМЕРНЫЙ МАССИВ ЦЕЛЫХ ЧИСЕЛ ===\n");

            int choice;
            do
            {
                ShowMenu();
                Console.Write("Выберите пункт: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        CreateArray(ref arr1, "первый");
                        break;
                    case 2:
                        CreateArray(ref arr2, "второй");
                        break;
                    case 3:
                        AccessElement(arr1, "первого");
                        break;
                    case 4:
                        AccessElement(arr2, "второго");
                        break;
                    case 5:
                        SumArrays();
                        break;
                    case 6:
                        SubtractArrays();
                        break;
                    case 7:
                        MultiplyArray();
                        break;
                    case 8:
                        PrintFullArray(arr1, "первый");
                        break;
                    case 9:
                        PrintFullArray(arr2, "второй");
                        break;
                    case 0:
                        Console.WriteLine("До свидания!");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }

                if (choice != 0)
                {
                    Console.WriteLine("\nНажмите Enter...");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (choice != 0);
        }

        static void ShowMenu()
        {
            Console.WriteLine("1. Создать первый массив");
            Console.WriteLine("2. Создать второй массив");
            Console.WriteLine("3. Вывести элемент первого массива");
            Console.WriteLine("4. Вывести элемент второго массива");
            Console.WriteLine("5. Сложение массивов");
            Console.WriteLine("6. Вычитание массивов");
            Console.WriteLine("7. Умножение массива на число");
            Console.WriteLine("8. Вывести первый массив");
            Console.WriteLine("9. Вывести второй массив");
            Console.WriteLine("0. Выход");
            Console.WriteLine();
        }

        static void CreateArray(ref IntArray arr, string name)
        {
            try
            {
                Console.Write($"Введите размер {name} массива: ");
                int size = int.Parse(Console.ReadLine());

                arr = new IntArray(size);
                arr.InputElements();

                Console.WriteLine("\nМассив создан:");
                arr.PrintArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void AccessElement(IntArray arr, string name)
        {
            if (arr == null)
            {
                Console.WriteLine($"{name} массив не создан!");
                return;
            }

            Console.Write($"Введите индекс элемента {name} массива: ");
            int index = int.Parse(Console.ReadLine());
            arr.PrintElement(index);
        }

        static void SumArrays()
        {
            if (arr1 == null || arr2 == null)
            {
                Console.WriteLine("Оба массива должны быть созданы!");
                return;
            }

            try
            {
                Console.WriteLine("Первый массив:");
                arr1.PrintArray();
                Console.WriteLine("Второй массив:");
                arr2.PrintArray();

                IntArray result = arr1.Add(arr2);
                Console.Write("Результат сложения: ");
                result.PrintArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void SubtractArrays()
        {
            if (arr1 == null || arr2 == null)
            {
                Console.WriteLine("Оба массива должны быть созданы!");
                return;
            }

            try
            {
                Console.WriteLine("Первый массив:");
                arr1.PrintArray();
                Console.WriteLine("Второй массив:");
                arr2.PrintArray();

                IntArray result = arr1.Subtract(arr2);
                Console.Write("Результат вычитания: ");
                result.PrintArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void MultiplyArray()
        {
            if (arr1 == null)
            {
                Console.WriteLine("Первый массив не создан!");
                return;
            }

            try
            {
                Console.Write("Введите число для умножения: ");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("Исходный массив:");
                arr1.PrintArray();

                IntArray result = arr1.Multiply(num);
                Console.Write("Результат умножения: ");
                result.PrintArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void PrintFullArray(IntArray arr, string name)
        {
            if (arr == null)
            {
                Console.WriteLine($"{name} массив не создан!");
                return;
            }

            Console.WriteLine($"{name} массив:");
            arr.PrintArray();
        }

    }
}
