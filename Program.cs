using System;

namespace Prof
{
    class Program
    {
        static void Main(string[] args)
        {
           Person gerardo = new Person("Gerardo Estrada Martinez ","Minero");
           gerardo.SayHello();
           
           Person angelica = new Person("Angélica de Jesus Rincón Valdes ","Psicológa");
           angelica.SayHello();

           Person erick = new Person("Erick Estrada Wong ","Ing. En Multimedia en desarrollo");
           erick.SayHello();
        }
    }
}
