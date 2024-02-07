using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Factory
{
    public class BankB : IBank
    {
        public string Withdrow()
        {
            return "Your request is handling by BankB";
        }
    }
}
