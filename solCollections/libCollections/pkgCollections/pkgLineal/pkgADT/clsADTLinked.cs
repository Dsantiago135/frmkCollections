using pkgServicies.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServicies.pkgCollections.pkgLineal.pkgADT
{
    internal class clsADTLinked<T> : iADTLinked<T> where T : IComparable<T>
    {
    }
}
