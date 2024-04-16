using System;
using System.Diagnostics;

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
        bool opSetFlexible();
        bool opSetInFlexible();
        #endregion
        #region Serialize/Deserialize
        bool opToItems(T[] prmArray,int prmItemsCount);
        #endregion
        #region Query
        bool opItsFull();
        bool opItsFlexible();
        #endregion
        #region Utilities
        bool opCapacityIncrease();
        #endregion
    }
}
