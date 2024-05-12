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
            clsLinkedNode<T> varNewNode = new clsLinkedNode<T>(prmItem);
            if (attLength != 0) attLast.opSetNext(varNewNode);
            attLength++;

            //operacion para asignar puertas de entrada
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

            //operacion para asignar puertas de entrada
            opSetAccessDoors();

            opGo(0);
            attCurrentIdx = 0;
            attCurrentItem = attCurrentNode.opGetItem();
            return true;
        }
        #endregion
    }
}
