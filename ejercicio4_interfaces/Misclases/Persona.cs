using ejercicio4_interfaces.Misinterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4_interfaces.Misclases
{
    internal class Persona: Ipersona
    {
        public string nombre { get; }
        public int edad { get; }

        public void decirminombre(string v)
        {
            Console.WriteLine("Mi nombre es Benjamin");
        }
        public void cumpliraños(int v)
        {
            Console.WriteLine("Mi edad es de 19 años");
        }

        public void decirminombre()
        {
            throw new NotImplementedException();
        }

        public void cumpliraños()
        {
            throw new NotImplementedException();
        }
    }
}
