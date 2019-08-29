using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class MotorCycle : IBuilder
    {
        private string brandName;
        private Product product;

        public MotorCycle(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }

        public void AddHeadlights()
        {
            product.Add("1 Headlights are added");
        }

        public void BuildBody()
        {
            product.Add("This is a body of a Motorcycle");
        }

        public void EndOperatons()
        {
            product.Add(string.Format("Motorcycle Model name: {0}", this.brandName));
        }

        public Product GetVehicle()
        {
            return product;
        }

        public void InsertWheels()
        {
            product.Add("2 wheels are added");
        }

        public void StartUpOperations()
        {
        }
    }
}