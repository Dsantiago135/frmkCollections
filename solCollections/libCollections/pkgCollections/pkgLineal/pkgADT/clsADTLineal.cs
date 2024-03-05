using pkgServicies.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServicies.pkgCollections.pkgLineal.pkgADT
{
    internal class clsADTLineal<T>: iADTLineal<T> where T : IComparable<T>
    {
        #region Attributes
        protected int attLength = 0;
        protected bool itsOrdenedAscending = false;
        protected bool itsOrdenedDescending = false;
        #endregion
        #region Operations
        #region Getters
        public int opGetLength()
        {
            throw new NotImplementedException();
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
        #endregion
        #region Serialize/Deserialize
        public T[] opToArray()
        {
            throw new NotImplementedException();
        }
        public bool opToItems(T prmArray)
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
            throw new NotImplementedException();
        }
        public bool opRetrieve(int prmIdx, ref T prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion 
        #endregion
    }
}
