using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej26InterfazesYClasesAbstractas
{
    internal class Scholar: Employees
    {
     String Career { get; set; }
     String Course { get; set; }
     String Departament { get; set; }

        public Scholar(String name, String lastname, Decimal baseSalary, String dni,String career, String course, String departament)
            : base(name, lastname, baseSalary, dni)
        {
            Career= career;
            Course = course;
            Departament= departament; 
        }
        public override string Information(string valor)
        {
            return $"Career: {Career}, Departament: {Departament}. {valor}";
        }
    }
}