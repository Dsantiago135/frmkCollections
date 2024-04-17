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
            if (opGetLength() != opGetTotalCapacity())
            {
                if (opGetLength() != 0)
                {
                    int i = 0;
                    int varIdx = attLength;
                    do
                    {
                        attItems[varIdx] = attItems[varIdx - 1];
                        varIdx--;
                        i++;
                    } while (i<opGetLength());
                    attItems[0] = prmItem;
                    attLength++;
                }
                else
                {
                    attItems[0] = prmItem;
                    attLength++;
                }
            }
            else if (!opItsFlexible())
            {
                return false;
            }
            else
            {
                opIncreaseCapacity();
                int i = 0;
                int varIdx = attLength;
                do
                {
                    attItems[varIdx] = attItems[varIdx - 1];
                    varIdx--;
                    i++;
                } while (i < opGetLength());
                attItems[0] = prmItem;
                attLength++;
            }
            return true;
        }
        public bool opPeek(ref T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opPop(ref T prmItem)
        {
            if (attLength != 0)
            {
                prmItem= attItems[0];
                int varCount = 0;
                do
                {
                    attItems[varCount] = attItems[varCount + 1];
                    varCount++;
                } while (varCount < opGetLength());

                attLength--;
            }
            else return false;
            return true;
        }

        #endregion
    }
}