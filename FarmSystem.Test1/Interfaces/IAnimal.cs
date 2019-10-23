namespace FarmSystem.Test1
{
    /// <summary>
    /// Interface which exposes method to milk animals
    /// </summary>
    public interface IAnimal
    {
        #region  Public Methods

        void Enter();
        void Release();
        void Talk();

        //void Walk();

        #endregion
    }
}