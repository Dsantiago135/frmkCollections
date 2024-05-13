using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgNodes;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgLinked
{
    public class clsLinkedQueue<T>: clsADTLinked<T> where T : IComparable<T>
    {
        #region Builders
        public clsLinkedQueue() 
        {
            
        }
        #endregion
        #region CRUDS
        public bool opPush(T prmItem)
        {
            if (attLength == attMaxCapacity) return false;
            clsLinkedNode<T> varNewNode = new clsLinkedNode<T>(prmItem);
            if (attLength != 0) attLast.opSetNext(varNewNode);
            attLength++;
            if (attLength == 1) attFirst = varNewNode;

            opSetAccessDoors();

            attCurrentNode = varNewNode;
            attCurrentIdx = attLength;
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
