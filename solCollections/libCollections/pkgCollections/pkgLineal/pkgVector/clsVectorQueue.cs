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
            if (attLength==0) return false;
            prmItem = attItems[0];
            return true;
        }
        public bool opPop(ref T prmItem)
        {
            if (attLength == 0) return false;
            prmItem = attItems[0];
            int varIterations = attLength;
            if (attLength == attTotalCapacity) varIterations = attLength - 1;
            if (attLength > 1)
            {
                for (int idx = 0; idx < varIterations; idx++)
                {
                    attItems[idx] = attItems[idx + 1];
                }
            }
            attLength--;
            return true;
        }
        public bool opPush(T prmItem)
        {
            if (attLength == attMaxCapacity) return false;
            if (attTotalCapacity == attLength && !attItsFlexible) return false;
            if (attTotalCapacity == attLength) opIncreaseCapacity();

            attItems[attLength] = prmItem;
            attLength++;
            return true;
        }
        #endregion
    }
}
