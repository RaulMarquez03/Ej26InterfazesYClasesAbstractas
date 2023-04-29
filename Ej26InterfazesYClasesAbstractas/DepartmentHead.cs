using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej26InterfazesYClasesAbstractas
{
    internal class DepartmentHead:Qualified
    {
        int TotalWorkCharge { get; set; }
        String Projects { get; set; }
        Decimal Plus { get; set; }
     public DepartmentHead (String name, String lastname, Decimal baseSalary, String dni, String career, String course, String departament,int totalWorkCharge,String projects, Decimal plus)
            : base(name, lastname, baseSalary, dni,career,course, departament)
        {
            TotalWorkCharge= totalWorkCharge;
            Projects= projects;
            Plus= plus;
        }
    }
}
