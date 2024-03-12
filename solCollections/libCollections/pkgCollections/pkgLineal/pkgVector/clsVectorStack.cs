using System;
using pkgServicies.pkgCollections.pkgLineal.pkgADT;
using pkgServicies.pkgCollections.pkgLineal.pkgInterfaces;

namespace pkgServicies.pkgCollections.pkgLineal.pkgVector
{
    public class clsVectorStack<T> :clsADTVector<T>, iStack<T>  where T : IComparable<T>
    {
        #region Builders
        public clsVectorStack()
        {
        }
        public clsVectorStack(int prmCapacity) : base(prmCapacity)
        {
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
            if (int i = 0;i < attLength;i ++)
            {

            }
            attItems[0] = prmItem;
            return true;
        }
        #endregion
    }
}