using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Prototype
{
    public class RegEmployee : EmployeePrototype
    {
        public override EmployeePrototype DeepCopy()
        {
            RegEmployee emp = new RegEmployee();
            emp = (RegEmployee) this.MemberwiseClone();
            emp.EmpAddress = new Address
            {
                Building = EmpAddress.Building,
                StreetName = EmpAddress.StreetName,
                City = EmpAddress.City,
            };
            emp.Name = this.Name;
            return emp;
        }

        public override EmployeePrototype ShallowCopy()
        {
            return (RegEmployee) this.MemberwiseClone();
        }
    }
}
