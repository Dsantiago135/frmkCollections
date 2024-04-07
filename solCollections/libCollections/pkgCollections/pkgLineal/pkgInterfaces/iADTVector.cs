using System;

namespace pkgServicies.pkgCollections.pkgLineal.pkgInterfaces
{
    internal interface iADTVector<T> where T : IComparable<T>
    {
        #region Getters
        int opGetTotalCapacity();
        int opGetAvailableCapacity();
        int opGetGrowingFactor();
        #endregion
        #region Setters
        bool opSetTotalCapacity(int prmValue);
        bool opSetGrowingFactor(int prmValue);
        #endregion
        #region Query
        bool opItsFull();
        bool opItsFlexible();
        #endregion
    }
}
