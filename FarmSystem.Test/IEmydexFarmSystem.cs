namespace FarmSystem.Test
{
    public interface IEmydexFarmSystem
    {
        void Enter(IAnimal animal);
        void MakeNoise();
        void MilkAnimals();
        void ReleaseAllAnimals();
    }
}