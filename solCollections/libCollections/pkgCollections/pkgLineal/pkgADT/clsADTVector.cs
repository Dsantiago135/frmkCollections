﻿using pkgServicies.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServicies.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTVector<T> : clsADTLineal<T>, iADTVector<T> where T : IComparable<T>
    {
        #region Attributes
        protected int attTotalCapacity = 100;
        protected static int attMaxCapacity = int.MaxValue/16;
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
                if (prmCapacity == attMaxCapacity) attGrowingFactor = 0;
                attTotalCapacity = prmCapacity;
                attItems = new T[prmCapacity];
            }
            catch (Exception)
            {
                attLength = 0;
                attitsOrdenedAscending = false;
                attitsOrdenedDescending = false;
                attTotalCapacity = 100;
                attItems = new T[100];
                attItsFlexible = false;
                attGrowingFactor = 100;
            }
        }
        #endregion
        #region Getters
        public int opGetTotalCapacity()
        {
            return attTotalCapacity;
        }
        public static int opGetMaxCapacity()
        {
            return attMaxCapacity;
        }
        public int opGetGrowingFactor()
        {
            return attGrowingFactor;
        }
        public int opGetAvailableCapacity()
        {
            return attTotalCapacity - attLength;
        }
        #endregion
        #region Serialize/Deserialize
        public override T[] opToArray()
        {
            return attItems;
        }
        public override bool opToItems(T[] prmArray, int prmItemsCount)
        {
            attItems= prmArray;
            attTotalCapacity = prmArray.Length;
            attLength= prmItemsCount;
            return true;
        }
        #endregion
        #region Setters
        public bool opSetTotalCapacity(int prmValue)
        {
            this.attTotalCapacity = prmValue;
            return true;
        }
        public bool opSetGrowingFactor(int prmValue)
        {
            this.attGrowingFactor = prmValue;
            return true;
        }
        public bool opSetFlexible()
        {
            attItsFlexible= true;
            return true;
        }
        public bool opSetInFlexible()
        {
            attItsFlexible = false;
            return true;
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
        #region
        public bool opCapacityIncrease()
        {
            return true;
        }
        #endregion
        #endregion
    }
}