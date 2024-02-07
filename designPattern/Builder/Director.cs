using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Builder
{
    public class Director
    {
        IBuilder builder;

        public void Constructor(IBuilder builder)
        {
            this.builder = builder;
            builder.StartUpOperations();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadights();
            builder.EndOperations();
        }
    }
}
