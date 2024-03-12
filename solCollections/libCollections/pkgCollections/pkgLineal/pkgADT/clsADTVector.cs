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
        protected clsADTVector()
        {
        }
        protected clsADTVector(int prmCapacity)
        {
            try
            {
                attCapacity = prmCapacity;
                attItems = new T[attCapacity];
            }
            catch (Exception e)
            {
                attLength = 0;
                attitsOrdenedAscending = false;
                attitsOrdenedDescending = false;
                attCapacity = 100;
                attItems = new T[100];
                attItsFlexible = false;
                attGrowingFactor = 100;
            }
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
            return attItsFlexible;
        }
        #endregion 
        #endregion
    }
}