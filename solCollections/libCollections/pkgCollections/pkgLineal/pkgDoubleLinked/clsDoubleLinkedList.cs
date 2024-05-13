using System;
using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgNodes;

namespace pkgServices.pkgCollections.pkgLineal.pkgDoubleLinked
{
    public class clsDoubleLinkedList<T>: clsADTDoubleLinked<T> where T : IComparable<T>
    {
        #region Builders
        public clsDoubleLinkedList()
        {
            
        }
        #endregion
        #region CRUDS
        public bool opAdd(T prmItem)
        {
            clsDoubleLinkedNode<T> varNewNode = new clsDoubleLinkedNode<T>(prmItem);
            if (attLength != 0)
            {
                attLast.opSetNext(varNewNode);
                varNewNode.opSetPrevious(attLast);
            }
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
                clsDoubleLinkedNode<T> varNodeNext = attCurrentNode;
                attCurrentNode = null;
                attCurrentNode = varNodeNext;
                opGoPrevious();
                attCurrentNode.opSetNext(varNodeNext.opGetNext());
                opGoNext();
                attCurrentNode.opSetPrevious(varNodeNext.opGetPrevious());
                attLength--;

                opSetAccessDoors();

                opGo(prmIdx);
            }
            else if (!opIsThereNext())
            {
                opGoLast();
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
                opGoFirst();
                opGoNext();
                attFirst = null;
                attFirst = attCurrentNode;
                attCurrentNode.opSetPrevious(default);
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
