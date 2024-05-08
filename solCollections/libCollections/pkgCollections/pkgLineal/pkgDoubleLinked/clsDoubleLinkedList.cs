using System;
using pkgServices.pkgCollections.pkgLineal.pkgADT;

namespace pkgServices.pkgCollections.pkgLineal.pkgDoubleLinked
{
    public class clsDoubleLinkedList<T>: clsADTDoubleLinked<T> where T : IComparable<T>
    {
        #region Builders
        public clsDoubleLinkedList()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region CRUDS
        public bool opAdd(T item)
        {
            throw new NotImplementedException();
        }
        public bool opRemove(int prmIdx, ref T item)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
