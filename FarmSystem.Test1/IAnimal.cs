namespace FarmSystem.Test1
{
    public interface IAnimal
    {
        string Id { get; }
        int NoOfLegs { get; }
        string Species { get; }

        void Run();
        void Talk();
        void Walk();
    }
}