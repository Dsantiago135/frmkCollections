﻿using pkgServices.pkgCollections.pkgIterator;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;
using System.Net.Http.Headers;

namespace pkgServices.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTLineal<T> : clsIterator<T>, iADTLineal<T> where T : IComparable<T>
    {
        #region Attributes
        protected static int attMaxCapacity = int.MaxValue / 16;
        protected bool attitsOrdenedAscending = false;
        protected bool attitsOrdenedDescending = false;
        #endregion
        #region Operations
        #region Getter
        public static int opGetMaxCapacity()
        {
            return attMaxCapacity;
        }
        #endregion
        #region Query
        public int opFind(T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opExists(T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opItsOrderedAscending()
        {
            return attitsOrdenedAscending;
        }
        public bool opItsOrderedDescending()
        {
            return attitsOrdenedDescending;
        }
        #endregion
        #region Serialize/Deserialize
        public virtual T[] opToArray()
        {
            if (attLength == 0) return null;
            T[] varArrayItems = new T[attLength];
            opGoFirst();

            for (int varCount = 0; varCount < attLength; varCount++)
            {
                varArrayItems[varCount] = attCurrentItem;
                opGoNext();
            }
            return varArrayItems;
        }
        public string opToString()
        {
            throw new NotImplementedException();
        }
        public virtual bool opToItems(T[] prmArray)
        {
            throw new NotImplementedException();
        }
        public virtual bool opToItems(T[] prmArray, int prmItemsCount)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region CRUD
        public bool opModify(int prmIdx, T prmItem)
        {
            if (!opGo(prmIdx)) return false;
            return opSetCurrentItem(prmItem);
            ;
        }
        public bool opRetrieve(int prmIdx, ref T prmItem)
        {
            if (!opGo(prmIdx)) return false;
            prmItem = attCurrentItem;
            return true;
        }
        public bool opReverse()
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}