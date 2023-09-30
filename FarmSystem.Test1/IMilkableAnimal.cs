using FarmSystem.Test;

namespace FarmSystem.Test2
{
    /// <summary>
    /// Interface which exposes method to milk animals
    /// </summary>
    public interface IMilkableAnimal : IAnimal
    {
        #region  Public Methods

        void ProduceMilk();

        #endregion
    }
}