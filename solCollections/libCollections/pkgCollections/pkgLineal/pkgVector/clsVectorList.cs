using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgVector
{
    public class clsVectorList<T> : clsADTVector<T>, iList<T> where T : IComparable<T>
    {
        #region Builders
        public clsVectorList()
        {
        }
        public clsVectorList(int prmCapacity) : base(prmCapacity)
        {
            
        }
        #endregion
        #region CRUDs
        public bool opAdd(T prmItem)
        {
            if (attLength == attMaxCapacity) return false;
            if (attTotalCapacity == attLength && !attItsFlexible) return false;
            if (attTotalCapacity == attLength) opIncreaseCapacity();

            attItems[attLength] = prmItem;
            attCurrentIdx = attLength;
            attCurrentItem = attItems[attLength];
            attLength++;
            return true;
        }
        public bool opInsert(int prmIdx, T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opRemove(int prmIdx, ref T prmItem)
        {
            if (!opIsValid(prmIdx)) return false;
            prmItem = attItems[prmIdx];
            if (prmIdx != attLength - 1)
                for (int varCount = prmIdx; varCount < attLength ; varCount++)
                {
                    attItems[varCount] = attItems[varCount + 1];
                }
            attLength--;
            attCurrentIdx = attLength - 1;
            attCurrentItem = attItems[attCurrentIdx];
            return true;
        } 
        #endregion
    }
}