using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 
namespace ConsoleApp1
{
    class Animal : IAnimal 
    {
      
     
        public void Andar()
        {
            WriteLine("Ya estoy caminando");
        }

        public bool EsPerro() 
        {
            throw new NotImplementedException();
        }

        public void Saltar()
        {
            WriteLine(" Estoy saltando");
        }
    }
}
