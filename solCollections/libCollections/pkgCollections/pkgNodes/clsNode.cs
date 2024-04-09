using System;
using pkgServicies.pkgCollections.pkgNodes.pkgInterfaces;

namespace pkgServicies.pkgCollections.pkgNodes
{
    internal class clsNode<T> : iNode<T> where T : IComparable<T>
    {
    }
}
