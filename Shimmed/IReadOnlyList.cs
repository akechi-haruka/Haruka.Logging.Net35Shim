// Decompiled with JetBrains decompiler
// Type: System.Collections.Generic.IReadOnlyList`1
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: 3EAA882B-2B1D-42EF-AD22-630EDEEF6F04
// Assembly location: C:\Windows\Microsoft.NET\assembly\GAC_32\mscorlib\v4.0_4.0.0.0__b77a5c561934e089\mscorlib.dll
// XML documentation location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8.1\mscorlib.xml

using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Extensions.Logging {

    /// <summary>Represents a read-only collection of elements that can be accessed by index.</summary>
    /// <typeparam name="T">The type of elements in the read-only list.</typeparam>
    public interface IReadOnlyList<T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable {
        /// <summary>Gets the element at the specified index in the read-only list.</summary>
        /// <param name="index">The zero-based index of the element to get.</param>
        /// <returns>The element at the specified index in the read-only list.</returns>
        T this[int index] { get; }
    }
}