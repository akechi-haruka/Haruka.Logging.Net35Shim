// Decompiled with JetBrains decompiler
// Type: System.Collections.Generic.IReadOnlyCollection`1
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: 3EAA882B-2B1D-42EF-AD22-630EDEEF6F04
// Assembly location: C:\Windows\Microsoft.NET\assembly\GAC_32\mscorlib\v4.0_4.0.0.0__b77a5c561934e089\mscorlib.dll
// XML documentation location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8.1\mscorlib.xml

using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Extensions.Logging {

    public interface IReadOnlyCollection<T> : IEnumerable<T>, IEnumerable {
        /// <summary>Gets the number of elements in the collection.</summary>
        /// <returns>The number of elements in the collection.</returns>
        int Count { get; }
    }
}