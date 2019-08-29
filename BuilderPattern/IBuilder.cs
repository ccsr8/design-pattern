namespace BuilderPattern
{
    public interface IBuilder
    {
        void StartUpOperations();

        void BuildBody();

        void InsertWheels();

        void AddHeadlights();

        void EndOperatons();

        Product GetVehicle();
    }
}