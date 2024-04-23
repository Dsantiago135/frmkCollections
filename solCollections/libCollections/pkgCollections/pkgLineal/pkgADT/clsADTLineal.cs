using pkgServicies.pkgCollections.pkgLineal.pkgInterfaces;
using System;
using System.CodeDom;

namespace pkgServicies.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTLineal<T>: iADTLineal<T> where T : IComparable<T>
    {
        #region Attributes
        protected int attLength = 0;
        protected bool attitsOrdenedAscending = false;
        protected bool attitsOrdenedDescending = false;
        #endregion
        #region Operations
        #region Getters
        public int opGetLength()
        {
            return attLength;
        }
        #endregion
        #region Query
        public bool opExists(T prmItem)
        {
            throw new NotImplementedException();
        }
        public int opFind(T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opIsValidIndex(int index)
        {
            throw new NotImplementedException();
        }
        public bool opItsEmpty()
        {
            throw new NotImplementedException();
        }
        public bool opItsorderAscending()
        {
            return attitsOrdenedAscending;
        }
        public bool opItsorderDescending()
        {
            return attitsOrdenedDescending;
        }
        #endregion
        #region Serialize/Deserialize
        public virtual T[] opToArray()
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
        public string opToString()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region CRUD
        public bool opModify(int prmIdx, T prmItem)
        {
            //if (!opGo(prmIdx)) return false;
            //return opSetCurrentItem(prmItem);
            throw new NotImplementedException();
        }
        public bool opRetrieve(int prmIdx, ref T prmItem)
        {
            //    if (!opGo(prmIdx)) return false;
            //    prmItem = opToArray()[prmIdx];
            //    return true;
            throw new NotImplementedException();
        }
        public bool opToItems(T prmArray)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
