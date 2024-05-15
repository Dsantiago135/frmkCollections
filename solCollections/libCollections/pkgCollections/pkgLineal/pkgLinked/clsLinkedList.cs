using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgNodes;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgLinked
{
    public class clsLinkedList<T>: clsADTLinked<T> where T : IComparable<T>
    {
        #region Builders
        public clsLinkedList()
        {
            
        }
        #endregion
        #region CRUDS
        public bool opAdd(T prmItem) 
        {
            clsLinkedNode<T> varNewNode = new clsLinkedNode<T>(prmItem);
            if (attLength != 0) attLast.opSetNext(varNewNode);
            attLength++;

            opSetAccessDoors();

            attCurrentNode = varNewNode;
            attCurrentIdx = attLength;
            attCurrentItem = attCurrentNode.opGetItem();
            return true;
        }
        public bool opRemove(int prmIdx, ref T prmItem)
        {
            if (!opGo(prmIdx)) return false;
            prmItem = attCurrentItem;
            if (opIsTherePrevious() && opIsThereNext())
            {
                clsLinkedNode<T> varNodeNext = attCurrentNode;
                attCurrentNode = null;
                attCurrentNode = varNodeNext;
                opGo(prmIdx-1);
                attCurrentNode.opSetNext(varNodeNext.opGetNext());
                attLength--;

                opSetAccessDoors();

            }
            else if (!opIsThereNext())
            {
                opGoPrevious();
                attLast = null;
                attLast = attCurrentNode;
                attCurrentNode.opSetNext(default);
                attLength--;

                opSetAccessDoors();

            }
            else
            {
                opGoNext();
                attFirst = null;
                attFirst = attCurrentNode;
                attLength--;

                opSetAccessDoors();

            }

            attCurrentIdx = 0;
            attCurrentItem = attCurrentNode.opGetItem();
            return true;
        }
        #endregion
    }
}