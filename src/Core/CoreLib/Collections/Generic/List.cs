// List.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Runtime.CompilerServices;

namespace System.Collections.Generic {

    /// <summary>
    /// Equivalent to the Array type in Javascript.
    /// </summary>
    [IgnoreNamespace]
    [Imported]
    [ScriptName("Array")]
    public sealed class List<T> : ICollection<T>, IList<T> {

        public List() {
        }

        public List(int capacity) {
        }

        public List(params T[] items) {
        }

        [IntrinsicProperty]
        [ScriptName("length")]
        public int Count {
            get {
                return 0;
            }
        }

        [IntrinsicProperty]
        public T this[int index] {
            get {
                return default(T);
            }
            set {
            }
        }

        public void Add(T item) {
        }

        public void AddRange(T[] items) {
        }

        public void AddRange(IList<T> items) {
        }

        public List<T> Clone() {
            return null;
        }

        public void Clear() {
        }

        public List<T> Concat(params T[] objects) {
            return null;
        }

        public bool Contains(object item) {
            return false;
        }

        public bool Contains(T item) {
            return false;
        }

        public bool Every(ListFilterCallback<T> filterCallback) {
            return false;
        }

        public bool Every(ListItemFilterCallback<T> itemFilterCallback) {
            return false;
        }

        public List<T> Extract(int index) {
            return null;
        }

        public List<T> Extract(int index, int count) {
            return null;
        }

        public List<T> Filter(ListFilterCallback<T> filterCallback) {
            return null;
        }

        public List<T> Filter(ListItemFilterCallback<T> itemFilterCallback) {
            return null;
        }

        public void ForEach(ListCallback<T> callback) {
        }

        public void ForEach(ListItemCallback<T> itemCallback) {
        }

        public IEnumerator<T> GetEnumerator() {
            return null;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {                
           return null;
        }        

        public ListGrouping<T>[] GroupBy(ListItemKeyGenerator<T> keyCallback) {
            return null;
        }

        /*
        // HACK: This should be T instead of object, but we have a problem
        //       handling partial generic types in the compiler.
        public Dictionary<string, object> Index(ListItemKeyGenerator<T> keyCallback) {
            return null;
        }
        */

        public int IndexOf(T item) {
            return 0;
        }

        public int IndexOf(T item, int startIndex) {
            return 0;
        }

        public void Insert(int index, T item) {
        }

        public void InsertRange(int index, T[] items) {
        }

        public string Join() {
            return null;
        }

        public string Join(string delimiter) {
            return null;
        }

        public int LastIndexOf(object item) {
            return 0;
        }

        public int LastIndexOf(object item, int fromIndex) {
            return 0;
        }

        public List<TTarget> Map<TTarget>(ListMapCallback<T, TTarget> mapCallback) {
            return null;
        }

        public List<TTarget> Map<TTarget>(ListItemMapCallback<T, TTarget> mapItemCallback) {
            return null;
        }

        public static List<T> Parse(string s) {
            return null;
        }

        public TReduced Reduce<TReduced>(ListReduceCallback<TReduced, T> callback) {
            return default(TReduced);
        }

        public TReduced Reduce<TReduced>(ListReduceCallback<TReduced, T> callback, TReduced initialValue) {
            return default(TReduced);
        }

        public TReduced Reduce<TReduced>(ListItemReduceCallback<TReduced, T> callback) {
            return default(TReduced);
        }

        public TReduced Reduce<TReduced>(ListItemReduceCallback<TReduced, T> callback, TReduced initialValue) {
            return default(TReduced);
        }

        public TReduced ReduceRight<TReduced>(ListReduceCallback<TReduced, T> callback) {
            return default(TReduced);
        }

        public TReduced ReduceRight<TReduced>(ListReduceCallback<TReduced, T> callback, TReduced initialValue) {
            return default(TReduced);
        }

        public TReduced ReduceRight<TReduced>(ListItemReduceCallback<TReduced, T> callback) {
            return default(TReduced);
        }

        public TReduced ReduceRight<TReduced>(ListItemReduceCallback<TReduced, T> callback, TReduced initialValue) {
            return default(TReduced);
        }

        public bool Remove(T item) {
            return false;
        }

        public void RemoveAt(int index) {
        }

        public List<T> RemoveRange(int index, int count) {
            return null;
        }

        public void Reverse() {
        }

        public List<T> Slice(int start) {
            return null;
        }

        public List<T> Slice(int start, int end) {
            return null;
        }

        public bool Some(ListFilterCallback<T> filterCallback) {
            return false;
        }

        public bool Some(ListItemFilterCallback<T> itemFilterCallback) {
            return false;
        }

        public void Sort() {
        }

        public void Sort(CompareCallback<T> compareCallback) {
        }

        public void Splice(int start, int deleteCount) {
        }

        public void Splice(int start, int deleteCount, params T[] itemsToInsert) {
        }

        public void Unshift(params T[] items) {
        }

        public static explicit operator Array(List<T> list) {
            return null;
        }
    }
}
