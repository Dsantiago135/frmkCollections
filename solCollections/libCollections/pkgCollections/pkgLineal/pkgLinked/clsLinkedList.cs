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

            //operacion para asignar puertas de entrada
            opSetAccessDoors();

            attLast=varNewNode;
            attCurrentNode = varNewNode;
            attCurrentIdx = attLength;
            attCurrentItem = attCurrentNode.opGetItem();
            attLength++;
            return true;
        }
        public bool opRemove(int prmIdx,ref T prmItem) 
        {
            if(!opGo(prmIdx))return false;
            prmItem = attCurrentItem;
            if (opIsTherePrevious() && opIsThereNext())
            {
                clsLinkedNode<T> varNodeNext = attCurrentNode;
                opGoPrevious();
                attCurrentNode.opSetNext(varNodeNext);

                opGo(attLength / 4);
                attFirstQuarter = attCurrentNode;
                opGo(attLength / 2);
                attMiddle = attCurrentNode;
                opGo((attLength / 2) + (attLength / 4));
                attLastQuarter = attCurrentNode;

                attCurrentNode = varNodeNext;
            }
            else if (!opIsThereNext())
            {
                opGoPrevious();
                attLast = attCurrentNode;
                attCurrentNode.opSetNext(default);

                opGo(attLength / 4);
                attFirstQuarter = attCurrentNode;
                opGo(attLength / 2);
                attMiddle = attCurrentNode;
                opGo((attLength / 2) + (attLength / 4));
                attLastQuarter = attCurrentNode;

                attCurrentNode = attLast;
            }
            else
            {
                opGoNext();
                attFirst = attCurrentNode;

                opGo(attLength / 4);
                attFirstQuarter = attCurrentNode;
                opGo(attLength / 2);
                attMiddle = attCurrentNode;
                opGo((attLength / 2) + (attLength / 4));
                attLastQuarter = attCurrentNode;

                attCurrentNode = attFirst;
            }

            attCurrentIdx = 0;
            attCurrentItem = attCurrentNode.opGetItem();
            attLength--;
            return true;
        }
        #endregion
    }
}