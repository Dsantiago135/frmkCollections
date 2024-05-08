using pkgServices.pkgCollections.pkgLineal.pkgADT;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgLinked
{
    public class clsLinkedList<T>: clsADTLinked<T> where T : IComparable<T>
    {
        #region Builders
        public clsLinkedList()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region CRUDS
        public bool opAdd(T item) 
        {
            throw new NotImplementedException();
        }
        public bool opRemove(int prmIdx,ref T item) 
        {  
            throw new NotImplementedException();
        }
        #endregion
    }
}