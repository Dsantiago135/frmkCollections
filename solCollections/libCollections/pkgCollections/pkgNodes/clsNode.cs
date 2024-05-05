using System;
using pkgServicies.pkgCollections.pkgNodes.pkgInterfaces;

namespace pkgServicies.pkgCollections.pkgNodes
{
    internal class clsNode<T> : iNode<T> where T : IComparable<T>
    {
        #region Attributes
        protected T attItem = default;
        #endregion
        #region Operations
        #region Builders
        public clsNode()
        {
        }
        public clsNode(T prmItem)
        {
        }
        #endregion
        #region Getter
        public T opGetItem()
        {
            return attItem;
        }
        #endregion
        #region Setter
        public bool opSetItem(T prmcontent)
        {
            this.attItem = prmcontent;
            return true;
        } 
        #endregion
        #endregion
    }
}
