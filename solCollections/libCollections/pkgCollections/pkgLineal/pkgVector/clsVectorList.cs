using pkgServicies.pkgCollections.pkgLineal.pkgADT;
using pkgServicies.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServicies.pkgCollections.pkgLineal.pkgVector
{
    internal class clsVectorList<T> : clsADTVector<T>, iList<T> where T : IComparable<T>
    {
        #region Builders
        public clsVectorList(int prmCapacity)
        {
            throw new NotImplementedException();
        }
        public clsVectorList()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region CRUDs
        public bool opAdd(T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opInsert(int prmIdx, T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opRemove(int prmIdx, ref T prmItem)
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}