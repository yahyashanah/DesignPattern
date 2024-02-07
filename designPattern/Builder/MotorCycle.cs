using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Builder
{
    public class MotorCycle : IBuilder
    {
        private string brandName;
        private Product product;

        public MotorCycle(string brend)
        {
            product = new Product();
            this.brandName = brend;
        }
        public void AddHeadights()
        {
            product.Add("Headlights are added");
        }

        public void BuildBody()
        {
            product.Add("Body was added");
        }

        public void EndOperations()
        {
            product.Add($"Motorcycle brand name {this.brandName}");
        }

        public Product GetVehicle()
        {
            return product;
        }

        public void InsertWheels()
        {
            product.Add("wheels are added");
        }

        public void StartUpOperations()
        {
            /*Start*/
        }
    }
}
