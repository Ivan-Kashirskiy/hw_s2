using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;

namespace LinkedList
{
    internal class ListNode<T>
    {
        internal T value;
        internal ListNode<T> prev;
        internal ListNode<T> next;

        public ListNode(T newValue)
        {
            value = newValue;
        }


        public ListNode(T newValue, ListNode<T> newPrev, ListNode<T> newNext)
        {
            value = newValue;
            prev = newPrev;
            next = newNext;
        }

    }
    
}
