using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Singleton
{
    public class Counter
    {
        public int count = 0;
        private static Counter instance = null;
        private static object instanceLock = new object();
        private Counter() { }

        public static Counter GetInstance()
        {
            if (instance == null)
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new Counter();
                    }
                }
            }
           
           return instance;
        }
        public void AddOne()
        {
            count++;
        }
    }
}
