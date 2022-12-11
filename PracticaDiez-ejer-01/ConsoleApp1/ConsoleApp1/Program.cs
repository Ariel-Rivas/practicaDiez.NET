using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


//1- Crea una Clase "Animal" que implemente la interfaz "IAnimal" , la interfaz "IAnimal" tendrá los métodos, Andar, es perro, saltar. 
//implementa estos métodos en la clase. y usa esa clase en un programa de consola.

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal perro = new Animal();

            perro.Andar();
           
            perro.Saltar();

            ReadLine(); 
        }
    }
}
