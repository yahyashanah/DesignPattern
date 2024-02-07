using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Builder
{
    public class Car : IBuilder
    {
        private string brandName;
        private Product product;

        public Car(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }
        public void AddHeadights()
        {
            product.Add("Headlights are added");
        }

        public void BuildBody()
        {
            product.Add("Body of cars was added");
        }

        public void EndOperations()
        {
            /*End Operation*/
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
            product.Add($"Car Model name: {this.brandName}");
        }
    }
}
