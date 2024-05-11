using System;
using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;

namespace pkgServices.pkgCollections.pkgLineal.pkgVector
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
        public bool opPush(T prmItem)
        {
            if (attLength == attMaxCapacity) return false;
            if (attTotalCapacity == attLength && !attItsFlexible) return false;
            if (attTotalCapacity == attLength) opIncreaseCapacity();

            int varIdx = attLength;
            for (int i = 0; i < attLength; i++)
            {
                attItems[varIdx] = attItems[varIdx - 1];
                varIdx--;
            }

            attItems[0] = prmItem;
            attCurrentIdx = 0;
            attCurrentItem = attItems[0];
            attLength++;
            return true;
        }
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
            if (attLength == attTotalCapacity)varIterations=attLength - 1;
            if (attLength > 1) {
                for (int idx = 0; idx < varIterations; idx++)
                {
                    attItems[idx] = attItems[idx + 1];
                }
            }
            attCurrentIdx = 0;
            attCurrentItem = attItems[0];
            attLength--;
            return true;
        }
        #endregion
    }
}