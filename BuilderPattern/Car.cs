namespace BuilderPattern
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

        public void AddHeadlights()
        {
            product.Add("2 Headlights are added");
        }

        public void BuildBody()
        {
            product.Add("This is a body of a Car");
        }

        public void EndOperatons()
        {
        }

        public Product GetVehicle()
        {
            return product;
        }

        public void InsertWheels()
        {
            product.Add("4 wheels are added");
        }

        public void StartUpOperations()
        {
            product.Add(string.Format("Car Model name: {0}", this.brandName));
        }
    }
}