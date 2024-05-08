using System;
using pkgServices.pkgCollections.pkgLineal.pkgADT;

namespace pkgServices.pkgCollections.pkgLineal.pkgDoubleLinked
{
    public class clsDoubleLinkedQueue<T>: clsADTDoubleLinked<T> where T : IComparable<T>
    {
        #region Builders
        public clsDoubleLinkedQueue()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region CRUDS
        public bool opPush(T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opPeek(ref T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opPop(ref T prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
