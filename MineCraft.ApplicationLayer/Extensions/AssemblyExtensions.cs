using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MineCraft.ApplicationLayer.Extensions
{
    internal static class AssemblyExtensions
    {
        internal static IEnumerable<Type> GetConcreteTypesAssignableFrom(
            this Assembly assembly, Type type)
        {
            return assembly
                .GetTypes()
                .Where(assemblyType => assemblyType.IsConcreteAssignableFrom(type));
        }
    }
}
