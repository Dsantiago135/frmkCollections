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
            if (attLength==0) return false;

            opGoFirst();
            prmItem = attCurrentItem;
            opGoNext();
            attFirst= null;
            attFirst = attCurrentNode;

            //operacion para asignar puertas de entrada
            opSetAccessDoors();

            opGo(0);
            attCurrentIdx = 0;
            attCurrentItem = attCurrentNode.opGetItem();
            attLength--;
            return true;
        }
        #endregion
    }
}