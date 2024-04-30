using System;
using System.Diagnostics.Eventing.Reader;
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
            attLength++;
            return true;
        }
        public bool opPeek(ref T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opPop(ref T prmItem)
        {
            if (attLength == 0) return false;
            prmItem = attItems[0];           
            if (attLength > 1) {
                for (int idx = 0; idx < attLength - 1; idx++)
                {
                    attItems[idx] = attItems[idx + 1];
                }
            }
            attLength--;
            return true;
        }
        #endregion
    }
}