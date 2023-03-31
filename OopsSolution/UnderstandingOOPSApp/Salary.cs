using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPSApp
{
    internal class Salary
    {
        internal virtual double CalculateSalary(double basic,double deductions)
        {
            double result = basic - deductions;
            return result;
        }
    }
    internal class ExecutiveSalary: Salary
    {
        internal sealed override double CalculateSalary(double basic, double deductions)
        {
            double result = basic - (basic * 10 / 100);
            result = result - deductions;
            return result;
        }
    }
    internal class ExecutiveAdvancedSalary : Salary
    {
        internal override double CalculateSalary(double basic, double deductions)
        {
            double result = basic - (basic * 12 / 100);
            result = result - deductions;
            return result;
        }
    }
}
