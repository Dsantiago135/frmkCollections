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

            //operacion para asignar puertas de entrada
            opGo(0);
            attFirst = attCurrentNode;
            opGo(attLength / 4);
            attFirstQuarter = attCurrentNode;
            opGo(attLength / 2);
            attMiddle = attCurrentNode;
            opGo((attLength / 2) + (attLength / 4));
            attLastQuarter = attCurrentNode;
            attLast = varNewNode;

            attCurrentNode = varNewNode;
            attCurrentIdx = attLength;
            attCurrentItem = attCurrentNode.opGetItem();
            attLength++;
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

            opGoLast();
            prmItem = attCurrentItem;
            opGoPrevious();
            attCurrentNode.opSetNext(default);
            attLast = attCurrentNode;

            //operacion para asignar puertas de entrada

            attLength--;
            attCurrentIdx = attLength-1;
            attCurrentItem = attCurrentNode.opGetItem();
            return true;
        }
        #endregion
    }
}
