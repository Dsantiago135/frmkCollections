using System;
using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgNodes;

namespace pkgServices.pkgCollections.pkgLineal.pkgLinked
{
    public class clsLinkedStack<T>: clsADTLinked<T> where T : IComparable<T>
    {
        #region Builder
        public clsLinkedStack()
        { 
        }
        #endregion
        #region CRUDS
        public bool opPush(T prmItem)
        {
            clsLinkedNode<T> varNewNode = new clsLinkedNode<T>(prmItem);
            if (attLength != 0) varNewNode.opSetNext(attFirst);

            //operacion para asignar puertas de entrada
            opGo(0);
            attFirst = varNewNode;
            opGo(attLength/4);
            attFirstQuarter = attCurrentNode;
            opGo(attLength/2);
            attMiddle = attCurrentNode;
            opGo((attLength/2)+(attLength/4));
            attLastQuarter = attCurrentNode;
            opGo(attLength - 1);
            attLast = attCurrentNode;

            attCurrentNode = varNewNode;
            attCurrentIdx = 0;
            attCurrentItem = attCurrentNode.opGetItem();
            attLength++;
            return true;
        }
        public bool opPeek(ref T prmItem)
        {
            if (attLength==0)return false ;
            opGoFirst();
            prmItem = attCurrentItem;
            return true;
        }
        public bool opPop(ref T prmItem)
        {
            if (attLength==0) return false;

            opGoFirst();
            prmItem = attCurrentItem;
            opGoNext();
            attFirst = attCurrentNode;

            //operacion para asignar puertas de entrada

            attCurrentIdx = 0;
            attCurrentItem = attCurrentNode.opGetItem();
            attLength--;
            return true;
        }
        #endregion
    }
}