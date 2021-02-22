using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
