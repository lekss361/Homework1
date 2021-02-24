using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int _taskSelection;
            int _userInput1, _userInput2, _userInput3, _userInput4;
            double result1,result2;
            

            Console.WriteLine("1. Пользователь вводит 2 числа (A и B). Выведите в консоль решение \n Пользователь вводит 2 значения(A и B). Поменяйте содержимое переменных A и B местами.\n" +
                "3. Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления.\n4. Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.\n" +
                "5. Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости. Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки" +
                "\nВведите номер задачи");

            _taskSelection = Convert.ToInt32(Console.ReadLine());

            if (_taskSelection!=5)
            {
                Console.Write("Введите число А\nА=");
                _userInput1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите B\nB=");
                _userInput2 = Convert.ToInt32(Console.ReadLine());
                _userInput3 = 0;
                _userInput4 = 0;
            }
            else
            {
                Console.Write("Введите число X1\nX1=");
                _userInput1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Y1\nY1=");
                _userInput2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число X2\nX2=");
                _userInput3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Y2\nY2=");
                _userInput4 = Convert.ToInt32(Console.ReadLine());
            }
            
            switch (_taskSelection)
            {
                case (1):
                    result1 = (5 * _userInput1 + _userInput2 * _userInput2)/(_userInput2-_userInput1);

                    Console.WriteLine($"Ответ на задачу {_taskSelection}: {result1}");
                    break; 

                case (2):
                    int x = _userInput1;
                    _userInput1 = _userInput2;
                    _userInput2 = x;
                    result1 = _userInput1;
                    result2 = _userInput2;

                    Console.WriteLine($"Ответ на задачу {_taskSelection}: {result1},{result2}");
                    break;

                case (3):
                    result1 = _userInput1 / _userInput2;
                    result2 = _userInput1 % _userInput2;

                    Console.WriteLine($"Ответ на задачу {_taskSelection}: {result1},{result2}");
                    break;

                case (4):
                    Console.WriteLine("Введите число C\nC=");
                    _userInput3= Convert.ToInt32(Console.ReadLine());
                    result1 = (_userInput3 - _userInput2) / _userInput1;

                    Console.WriteLine($"Ответ на задачу {_taskSelection}: {result1}");
                    break;

                case (5):
                    result1 = (_userInput2 - _userInput4) / (_userInput1 - _userInput3);
                    result2 = _userInput4 - result1 * _userInput3;

                    Console.WriteLine($"Ответ на задачу{_taskSelection}:  уравнение прямой={result1}x+{result2}");
                    break;

                default:
                    break;
            }
        }
    }
}
