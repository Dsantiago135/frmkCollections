using System;
using pkgServicies.pkgCollections.pkgNodes.pkgInterfaces;

namespace pkgServicies.pkgCollections.pkgNodes
{
    internal class clsLinkedNode<T> : iLinkedNode<T> where T : IComparable<T>
    {
    }
}
