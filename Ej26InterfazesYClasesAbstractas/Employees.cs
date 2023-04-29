using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej26InterfazesYClasesAbstractas
{
    internal class Employees
    {
        String Name { get; set; }
        String Lastname { get; set; }
        Decimal BaseSalary { get; set; }
        String Dni { get; set; }
       public Employees(String name, String lastname , Decimal baseSalary, String dni) 
        {
            Name= name;
            Lastname= lastname;
            BaseSalary= baseSalary;
            Dni= dni;
        }
       public Employees() { }
        public virtual string Information(String valor) {
            return $"La información de este objeto es {valor}.";
        } 
    }
    
}
