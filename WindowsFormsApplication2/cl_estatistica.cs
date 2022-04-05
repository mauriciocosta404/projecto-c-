using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    static class cl_estatistica
    {
        public static int soma = 0;
        public static int soma_masculino=0;
        public static int soma_femenino = 0;


       public static double calcularmasculino(){
  
            return (soma_masculino * 100)/soma ;
            }
        public static double calcularfemenino()
        {

            return (soma_femenino * 100) / soma;
        }
    }
}
