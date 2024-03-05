using System;

namespace pkgServicies.pkgCollections.pkgLineal.pkgInterfaces
{
    internal interface iADTVector<T> where T : IComparable<T>
    {
        #region Getters
        int opGetCapacity();
        int opGetGrowingFactor();
        #endregion
        #region Setters
        bool opSetCapacity(int prmValue);
        bool opSetGrowingFactor(int prmValue);
        #endregion
        #region Query
        bool opItsFull(); 
        #endregion
    }
}
