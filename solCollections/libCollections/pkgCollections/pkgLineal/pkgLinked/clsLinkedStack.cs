using System;
using pkgServices.pkgCollections.pkgLineal.pkgADT;

namespace pkgServices.pkgCollections.pkgLineal.pkgLinked
{
    public class clsLinkedStack<T>: clsADTLinked<T> where T : IComparable<T>
    {
        #region Builder
        public clsLinkedStack()
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
