using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Elementary
{
    public class LimitedQueue<T> : IEnumerable<T>
    {
        private readonly Queue<T> _queue;

        private int _capacity;
        /// <summary>
        /// The capacity of this <see cref="LimitedQueue{T}"/>, any excess will be dismissed and pushed out immediately
        /// </summary>
        public int Capacity
        {
            get => _capacity;
            set
            {
                _capacity = value;

                if (_queue == null) return;
                while (_queue.Count >= _capacity + 1)
                    _queue.Dequeue();
            }
        }

        /// <summary>
        /// Gets the number of elements contained in the <see cref="T:Elementary.LimitedQueue`1" />
        /// </summary>
        public int Count => _queue.Count;

        /// <summary>
        /// Returns the element at the specified index in a sequence
        /// </summary>
        /// <param name="index">The index</param>
        /// <returns>The element at the specified index in a sequence</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public T this[int index] => _queue.ElementAt(index);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="capacity">The capacity of this <see cref="LimitedQueue{T}"/></param>
        public LimitedQueue(int capacity)
        {
            _queue = new Queue<T>(capacity);
            Capacity = capacity;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="capacity">The capacity of this <see cref="LimitedQueue{T}"/></param>
        /// <param name="items">The initial items of this <see cref="LimitedQueue{T}"/></param>
        public LimitedQueue(int capacity, IEnumerable<T> items) : this(capacity)
        {
            foreach (T item in items)
                Enqueue(item);
        }

        /// <summary>
        /// Removes all objects from the <see cref="LimitedQueue{T}"/>
        /// </summary>
        public void Clear() => _queue.Clear();
        /// <summary>
        /// Copies the <see cref="LimitedQueue{T}"/> elements to an existing one-dimensional <see cref="System.Array"/>, starting at the specified array index
        /// </summary>
        /// <param name="array">The array</param>
        /// <param name="index">The index</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        /// <exception cref="System.ArgumentException"></exception>
        public void CopyTo(T[] array, int index) => _queue.CopyTo(array, index);
        /// <summary>
        /// Determines whetever an element is in the <see cref="LimitedQueue{T}"/>
        /// </summary>
        /// <param name="item">The item</param>
        /// <returns>Whetever the element is in this <see cref="LimitedQueue{T}"/></returns>
        public bool Contains(T item) => _queue.Contains(item);
        /// <summary>
        /// Determines whetever a sequence contains a specified element by using a specified <see cref="IEqualityComparer{T}"/>
        /// </summary>
        /// <param name="item">The item</param>
        /// <param name="comparer">The comparer</param>
        /// <returns>Whetever the element is in the <see cref="LimitedQueue{T}"/></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public bool Contains(T item, IEqualityComparer<T> comparer) => _queue.Contains(item, comparer);
        /// <summary>
        /// Removes and returns the object at the beginning of the <see cref="LimitedQueue{T}"/>
        /// </summary>
        /// <returns>The object at the beginning of the <see cref="LimitedQueue{T}"/></returns>
        /// <exception cref="System.InvalidOperationException"></exception>
        public T Dequeue() => _queue.Dequeue();
        /// <summary>
        /// Adds an object to the end of the <see cref="LimitedQueue{T}"/>
        /// </summary>
        /// <param name="item">The item to add</param>
        public void Enqueue(T item)
        {
            if (_queue.Count >= Capacity)
                _queue.Dequeue();

            _queue.Enqueue(item);
        }
        /// <summary>
        /// Returns the object at the beginning of the <see cref="LimitedQueue{T}"/> without removing it
        /// </summary>
        /// <returns>The object at the beginning of the <see cref="LimitedQueue{T}"/></returns>
        /// <exception cref="System.InvalidOperationException"></exception>
        public T Peek() => _queue.Peek();
        /// <summary>
        /// Copies the <see cref="LimitedQueue{T}"/> elements to a new array
        /// </summary>
        /// <returns>The array with the elements of the <see cref="LimitedQueue{T}"/></returns>
        public T[] ToArray() => _queue.ToArray();

        /// <inheritdoc />
        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="T:Elementary.LimitedQueue`1" />
        /// </summary>
        /// <returns>An enumerator that iterates through the <see cref="T:Elementary.LimitedQueue`1" /></returns>
        public IEnumerator<T> GetEnumerator() => _queue.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}