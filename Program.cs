using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - 40€.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печатки информации на консоли при помощи интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев
            
            Repository repository = new Repository();
            bool exit = false;

            while (!exit)
            {
                var answer = repository.PrintStartMenu();

                switch (answer)
                {
                    case 1: repository.AddNewStudent(); break;
                    case 2: repository.ShowAll(); break;
                    case 3: repository.DeleteStudent();
                        break;
                    case 4: exit = true; break;
                    default: Console.WriteLine("Only 1 - 4 digits allowed! Try again."); break;
                }
            }

        }
    }
}
