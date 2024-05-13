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
        public bool opRemove(int prmIdx,ref T prmItem) 
        {
            if(!opGo(prmIdx))return false;
            prmItem = attCurrentItem;
            if (opIsTherePrevious() && opIsThereNext())
            {
                clsLinkedNode<T> varNodeNext = attCurrentNode;
                attCurrentNode = null;
                attCurrentNode = varNodeNext;
                opGoPrevious();
                attCurrentNode.opSetNext(varNodeNext.opGetNext());
                attLength--;

                opSetAccessDoors();

                opGo(prmIdx);
            }
            else if (!opIsThereNext())
            {
                opGoPrevious();
                attLast = null;
                attLast = attCurrentNode;
                attCurrentNode.opSetNext(default);
                attLength--;

                opSetAccessDoors();

                attCurrentNode = attLast;
            }
            else
            {
                opGoNext();
                attFirst = null;
                attFirst = attCurrentNode;
                attLength--;

                opSetAccessDoors();

                attCurrentNode = attFirst;
            }

            attCurrentIdx = 0;
            attCurrentItem = attCurrentNode.opGetItem();
            return true;
        }
        #endregion
    }
}