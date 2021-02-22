using System;
using System.Collections.Generic;
using System.Collections;

namespace CustomLinkedList
{
    class LinkedList<T> : IEnumerable<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        public int Count { get => _count; }

        private int _count = 0;
        public void Add(T data)
        {
            // check data
            if (data == null)
            {
                throw new ArgumentException(nameof(data));
            }

            Node<T> newNode = new Node<T>();
            newNode.Data = data;

            // If list empty - add to head
            // else add to end list(tail)
            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                _tail.Next = newNode;
            }

            // Set new element last
            _tail = newNode;

            // Add 1 to counter of elements list
            _count++;
        }

        public void Delete(T data)
        {
            if (data == null)
            {
                throw new ArgumentException(nameof(data));
            }


            Node<T> currentNode = _head;
            Node<T> previousNode = null;

            while (currentNode != null)
            {
                // If equals data - delete current element an break loop.
                if (currentNode.Data.Equals(data))
                {
                    // If element is in the middle or end of the list
                    // else - element is head of the list
                    if (previousNode != null)
                    {
                        previousNode.Next = currentNode.Next;
                        
                        if (currentNode.Next == null)
                        {
                            _tail = previousNode;
                        }
                    }
                    else
                    {
                        _head = _head.Next;

                        if (_head == null)
                        {
                            _tail = null;
                        }
                    }

                    // Counter --
                    _count--;
                    break;
                }

                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> currentNode = _head;
            while (currentNode != null)
            {
                yield return currentNode.Data;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
