using System;
using pkgServices.pkgCollections.pkgNodes.pkgInterfaces;

namespace pkgServices.pkgCollections.pkgNodes
{
    public class clsNode<T> : iNode<T> where T : IComparable<T>
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
            attItem= prmItem;
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
            attItem = prmcontent;
            return true;
        } 
        #endregion
        #endregion
    }
}