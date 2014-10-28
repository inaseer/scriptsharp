// IList.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
  /// <summary>
  /// Equivalent to the Array type in Javascript.
  /// </summary>
  [IgnoreNamespace]
  [Imported]
  [ScriptName("Array")]
  public interface IList<T> : IEnumerable<T>, IEnumerable
  {
    int IndexOf(T item);

    void Insert(int index, T item);

    void RemoveAt(int index);

    void Add(T item);

    bool Contains(T item);

    [IntrinsicProperty]
    [ScriptName("length")]
    int Count
    {
      get;
    }

    [IntrinsicProperty]
    T this[int index]
    {
      get;
      set;
    }
  }
}
