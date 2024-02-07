using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Prototype
{
    public abstract class EmployeePrototype
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address EmpAddress { get; set; }
        public abstract EmployeePrototype ShallowCopy();
        public abstract EmployeePrototype DeepCopy();

        public override string ToString()
        {
            return $@"Id: {this.Id} Name: {this.Name} {this.EmpAddress.City} {this.EmpAddress.StreetName} {this.EmpAddress.Building}";
        }
    }
}
