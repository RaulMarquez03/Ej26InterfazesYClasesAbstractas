using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ej26InterfazesYClasesAbstractas
{
    internal interface Students
    {
        public void Exams()
        {
            Random random = new Random();
            int nota1 = random.Next(0, 11); 
            int nota2 = random.Next(0, 11);
            int nota3 = random.Next(0, 11);
        }
        public void University()
        {
            Console.WriteLine("Harvard");
        }
        public int AverageGrade(int nota1,int nota2,int nota3)
        {
            int Averenge = (nota1 + nota2 + nota3) / 3;
            return Averenge;
        }
    }
}
