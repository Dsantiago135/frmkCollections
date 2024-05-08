using pkgServices.pkgCollections.pkgLineal.pkgADT;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgLinked
{
    public class clsLinkedQueue<T>: clsADTLinked<T> where T : IComparable<T>
    {
        #region Builders
        public clsLinkedQueue() 
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
