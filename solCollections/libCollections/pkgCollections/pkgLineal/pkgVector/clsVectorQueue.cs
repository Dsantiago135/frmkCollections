using pkgServicies.pkgCollections.pkgLineal.pkgADT;
using pkgServicies.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServicies.pkgCollections.pkgLineal.pkgVector
{
    internal class clsVectorQueue<T> : clsADTVector<T>, iQueue<T> where T : IComparable<T>
    {
        #region Buliders
        public clsVectorQueue(int prmcapacit)
        {
            throw new NotImplementedException();
        }
        public clsVectorQueue()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region CRUDs
        public bool opPeek(ref T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opPop(ref T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opPush(T prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
