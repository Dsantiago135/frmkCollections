using pkgServicies.pkgCollections.pkgLineal.pkgADT;
using pkgServicies.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServicies.pkgCollections.pkgLineal.pkgVector
{
    public class clsVectorQueue<T> : clsADTVector<T>, iQueue<T> where T : IComparable<T>
    {
        #region Buliders
        public clsVectorQueue()
        {
        }
        public clsVectorQueue(int prmCapacity) : base(prmCapacity)
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
            if (attLength == 0) return false;
            prmItem = attItems[0];
            int varCount = 0;
            do
            {
                attItems[varCount] = attItems[varCount + 1];
                varCount++;
            } while (varCount < opGetLength());

            attLength--;
            return true;
        }
        public bool opPush(T prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
