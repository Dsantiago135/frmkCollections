using System;
using pkgServicies.pkgCollections.pkgNodes.pkgInterfaces;

namespace pkgServicies.pkgCollections.pkgNodes
{
    internal class clsLinkedNode<T> : clsNode<T>, iLinkedNode<T> where T : IComparable<T>
    {
        #region Attributes
        protected clsLinkedNode<T> attNext = default;
        #endregion
        #region Operations
        #region Builders
        public clsLinkedNode()
        {
        }
        public clsLinkedNode(T prmItem): base(prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Getter
        public clsLinkedNode<T> opGetNext()
        {
            return attNext;
        }
        #endregion
        #region Setter
        public bool opSetNext(clsLinkedNode<T> prmNode)
        {
            attNext = prmNode;
            return true;
        }  
        #endregion
        #endregion
    }
}
