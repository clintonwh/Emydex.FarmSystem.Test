namespace FarmSystem.Test
{
    public interface IAnimal
    {
        string Id { get; }
        int NoOfLegs { get; }
        string Species { get; }

        void Run();
        void Talk();
        void Walk();
        void Release();
    }
}