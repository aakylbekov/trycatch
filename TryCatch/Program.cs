using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Error
            // 1.	Перехватить исключение запроса к несуществующему веб ресурсу и вывести сообщение о том, что произошла ошибка.Программа должна завершиться без ошибок.
            try
            {
                string url = "http:\\mystatQQQ.com";
                string val = get(url);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
                //throw new Exception("Error");
            }
            #endregion

            //2.	Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы. После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.
            #region Massiv
            try
            {
                int[] massiv = new int[10];
                int val = massiv[12];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region Vyzov
            //3.	Реализовать несколько методов или классов с методами и вызвать один метод из другого. В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.
            try
            {
                class 
            }
            catch (Exception)
            {

                throw;
            }



            #endregion
        }
    }
}
