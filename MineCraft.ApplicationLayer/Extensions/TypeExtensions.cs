using System;

namespace MineCraft.ApplicationLayer.Extensions
{
    internal static class TypeExtensions
    {
        internal static bool IsConcreteAssignableFrom(this Type type,
            Type otherType)
        {
            if (type.IsAbstract) return false;
            if (type.IsInterface) return false;

            return type.IsAssignableFrom(otherType) || 
                type.IsSubclassOf(otherType);
        }
    }
}
