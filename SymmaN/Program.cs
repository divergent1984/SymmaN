using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmaN
{
    class Program
    {
       
        static void Main(string[] args)
        {
          //Просим пользователя ввести целое число.
            Console.WriteLine("Введите целое число");
            int namber =Convert.ToInt32( Console.ReadLine());
            // создаём переменную для начала счета.
            var nam = 1;
            //Если полученное число больше 0 то запускаем цикл
            if (namber>0) 
            {
                // цикл проходит до полученного числа, слаживая все результаты.
                for (int i = 2; i <= namber; i++)
                    nam += i;
                Console.WriteLine("Сумма чисел:" + " "+ namber + " "+"равна "+ nam);
            }
            //Если число меньше нуля виводим ошибку. 
            else
            {
                Console.WriteLine("Вы ввели некоректное значение.");
            }
              Console.ReadKey();
        }
    }
}

