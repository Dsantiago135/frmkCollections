using pkgServicies.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServicies.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTVector<T>: clsADTLineal<T>,iADTVector<T> where T : IComparable<T>
    {
        #region Attributes
        protected int attCapacity = 100;
        protected T[] attItems = new T[100];
        protected bool attItsFlexible = false;
        protected int attGrowingFactor = 100;
        #endregion
        #region Operations
        #region Builders
        protected clsADTVector(int attCapacity)
        {
            throw new NotImplementedException();
        }
        protected clsADTVector()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Getters
        public int opGetCapacity()
        {
            return attCapacity;
        }
        public int opGetGrowingFactor()
        {
            return attGrowingFactor;
        }
        #endregion
        #region Setters
        public bool opSetCapacity(int prmValue)
        {
            throw new NotImplementedException();
        }
        public bool opSetGrowingFactor(int prmValue)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Query
        public bool opItsFull()
        {
            throw new NotImplementedException();
        }
        public bool opItsFlexible()
        {
            throw new NotImplementedException();
        }
        #endregion 
        #endregion
    }
}