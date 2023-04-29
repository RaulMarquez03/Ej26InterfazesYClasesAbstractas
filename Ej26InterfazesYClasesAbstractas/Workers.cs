using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ej26InterfazesYClasesAbstractas
{
    internal class Workers : Employees
    {
        String JobDestination { get; set; }
        int ExtraHours { get; set; }
        Decimal PriceHE { get; set; } 
        public Workers(String name, String lastname, Decimal baseSalary, String dni, String jobDestination, int extraHours, Decimal priceHE)
        : base(name, lastname, baseSalary, dni)
        {
            
            JobDestination = jobDestination;
            ExtraHours = extraHours;
            PriceHE= priceHE;
        }
        public override string Information(string valor)
        {
            return $"JobDestination: {JobDestination}, Price  Extra Hours: {PriceHE}. {valor}";
        }
    }
}
