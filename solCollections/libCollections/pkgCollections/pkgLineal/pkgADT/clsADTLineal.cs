using pkgServices.pkgCollections.pkgIterator;
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
            throw new NotImplementedException();
        //    if (opItsEmpty()) return null;
        //    T[] varArray = new T[attLength];
        //    opGoFirst();
        //    do
        //    {
        //        varArray[attCurrentIdx] = attCurrentItem;
        //    } while (opGoNext());

        //    return varArray;
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
        public virtual bool opRetrieve(int prmIdx, ref T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opReverse()
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}