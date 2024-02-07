using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Adapter
{
    public class SalaryAdapter : SalaryCalculator
    {
        private Employee emp;
        public double CalcSalary(MachineOperator machineOperator)
        {
            emp = new Employee();
            emp.BasicSalary = machineOperator.BasicSalary;
            return base.CalcSalary(emp);
        }
    }
}
