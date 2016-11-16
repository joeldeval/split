using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SplitEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string texto = "Lorem ipsum dolor sit amet\r\nconsectetur adipiscing elit.\r\nCurabitur ac lacinia massa.\r\n Etiam lorem felis, dignissim nec tristique non, sodales quis tellus.";
            //arreglo sin datos vacíos
            string[] arregloTexto = texto.Split('\r', '\n').Where(x => !string.IsNullOrEmpty(x)).ToArray();
            
            foreach(string dato in arregloTexto){
                Console.Write(dato);
            }
            Console.ReadLine();

        }

    }
}
