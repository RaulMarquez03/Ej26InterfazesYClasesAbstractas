using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej26InterfazesYClasesAbstractas
{
    internal class Qualified:Employees
    {
        String Title { get; set; }
        String Plus { get; set; }
        String Departament { get; set; }
        public Qualified(String name, String lastname, Decimal baseSalary, String dni, String title, String plus, String departament)
            : base(name, lastname, baseSalary, dni)
        {
            Title = title;
            Plus = plus;
            Departament = departament;
        }  
        public Qualified() { }
        public override string Information(string valor)
        {
            return $"Title: {Title}, Departament: {Departament} {valor}";
        }
    }
}
