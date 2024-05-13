using System;
using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgNodes;

namespace pkgServices.pkgCollections.pkgLineal.pkgDoubleLinked
{
    public class clsDoubleLinkedStack<T>: clsADTDoubleLinked<T> where T : IComparable<T>
    {
        #region Builder
        public clsDoubleLinkedStack()
        {
           
        }
        #endregion
        #region CRUDS
        public bool opPush(T prmItem)
        {
            if (attLength == attMaxCapacity) return false;
            clsDoubleLinkedNode<T> varNewNode = new clsDoubleLinkedNode<T>(prmItem);
            if (attLength != 0)
            {
                varNewNode.opSetNext(attFirst);
                attFirst.opSetPrevious(varNewNode);
            }
                attFirst = varNewNode;
                attLength++;

                opSetAccessDoors();

                attCurrentNode = varNewNode;
                attCurrentIdx = 0;
                attCurrentItem = attCurrentNode.opGetItem();
                return true;
            }
        public bool opPeek(ref T prmItem)
        {
            if (attLength == 0) return false;
            opGoFirst();
            prmItem = attCurrentItem;
            return true;
        }
        public bool opPop(ref T prmItem)
        {
            if (attLength == 0) return false;

            opGoFirst();
            prmItem = attCurrentItem;
            opGoNext();
            attFirst = null;
            attFirst = attCurrentNode;
            attCurrentNode.opSetPrevious(null);
            attLength--;

            opSetAccessDoors();

            opGoFirst();
            attCurrentIdx = 0;
            attCurrentItem = attCurrentNode.opGetItem();
            return true;
        }
        #endregion
    }
}
