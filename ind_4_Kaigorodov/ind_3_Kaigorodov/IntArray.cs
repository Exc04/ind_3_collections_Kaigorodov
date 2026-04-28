using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ind_3_Kaigorodov
{
    internal class IntArray
    {
        private List<int> _array;

        // Конструктор с заданием размерности
        public IntArray(int size)
        {
            if (size <= 0)
                throw new Exception("Размер массива должен быть больше 0");

            _array = new List<int>(size);
            for (int i = 0; i < size; i++)
                _array.Add(0);
        }

        // 1. Обращение к элементу с контролем выхода за границы
        public int GetElement(int index)
        {
            if (index < 0 || index >= _array.Count)
                throw new Exception($"Ошибка: индекс {index} выходит за границы (0-{_array.Count - 1})");

            return _array[index];
        }

        public void SetElement(int index, int value)
        {
            if (index < 0 || index >= _array.Count)
                throw new Exception($"Ошибка: индекс {index} выходит за границы (0-{_array.Count - 1})");

            _array[index] = value;
        }

        // 2. Сложение массивов
        public IntArray Add(IntArray other)
        {
            if (_array.Count != other._array.Count)
                throw new Exception("Ошибка: размеры массивов не совпадают");

            IntArray result = new IntArray(_array.Count);
            for (int i = 0; i < _array.Count; i++)
                result.SetElement(i, _array[i] + other._array[i]);

            return result;
        }

        // 2. Вычитание массивов
        public IntArray Subtract(IntArray other)
        {
            if (_array.Count != other._array.Count)
                throw new Exception("Ошибка: размеры массивов не совпадают");

            IntArray result = new IntArray(_array.Count);
            for (int i = 0; i < _array.Count; i++)
                result.SetElement(i, _array[i] - other._array[i]);

            return result;
        }

        // 3. Умножение элементов массива на число
        public IntArray Multiply(int number)
        {
            IntArray result = new IntArray(_array.Count);
            for (int i = 0; i < _array.Count; i++)
                result.SetElement(i, _array[i] * number);

            return result;
        }

        // 4. Вывод элемента по индексу
        public void PrintElement(int index)
        {
            try
            {
                Console.WriteLine($"Элемент [{index}] = {GetElement(index)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // 4. Вывод всего массива
        public void PrintArray()
        {
            Console.Write("Массив: [");
            for (int i = 0; i < _array.Count; i++)
            {
                Console.Write(_array[i]);
                if (i < _array.Count - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }

        // Ввод элементов с клавиатуры
        public void InputElements()
        {
            Console.WriteLine($"Введите {_array.Count} элементов:");
            for (int i = 0; i < _array.Count; i++)
            {
                Console.Write($"[{i}]: ");
                int value = int.Parse(Console.ReadLine());
                SetElement(i, value);
            }
        }
    }
}
