using System;
using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgNodes.pkgInterfaces;


namespace pkgServices.pkgCollections.pkgNodes
{
    public class clsDoubleLinkedNode<T>: clsNode<T>, iDoubleLinkedNode<T> where T : IComparable<T>
    {
        #region Attributes
        protected clsDoubleLinkedNode<T> attPrevious = default;
        protected clsDoubleLinkedNode<T> attNext = default;
        #endregion
        #region Operations
        #region Builders
        public clsDoubleLinkedNode()
        {
        }
        public clsDoubleLinkedNode(T prmItem): base(prmItem)
        {
            attItem = prmItem;
            attNext = default;
            attPrevious = default;
        }
        #endregion
        #region Getter
        public clsDoubleLinkedNode<T> opGetNext()
        {
            return attNext;
        }
        public clsDoubleLinkedNode<T> opGetPrevious()
        {
            return attPrevious;
        }
        #endregion
        #region Setter
        public bool opSetNext(clsDoubleLinkedNode<T> prmNode)
        {
            attNext = prmNode;
            return true;
        }
        public bool opSetPrevious(clsDoubleLinkedNode<T> prmNode)
        {
            attPrevious = prmNode;
            return true;
        }  
        #endregion
        #endregion
    }
}