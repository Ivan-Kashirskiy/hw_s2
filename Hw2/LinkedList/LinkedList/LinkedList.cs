using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
//using ListNode


namespace LinkedList
{
    internal class LinkedList<T>
    { 
        protected ListNode<T> first;
        protected ListNode<T> last;


        public int count
        {
            get
            {
                int c = 0;
                ListNode <T> cur = first;
                while (cur != null)
                {
                    cur = cur.prev;
                    c++;
                }

                return c;
            }
        }

        public LinkedList()
        {
            first = null;
            last = null;
        }

        public ListNode<T> First()
        {
            return first;
        }

        public ListNode<T> Last()
        {
            return last;
        }

        public void AddFirst(T value)
        {
            if (count == 0)
            {
                first = new ListNode<T>(value, null, null);
                last = first;
            }
            else
            {
                first = new ListNode<T>(value, null, first);
            }
        }

        public void AddLast(T value)
        {
            if (count == 0)
            {
                first = new ListNode<T>(value, null, null);
                last = first;
            }
            else
            {
                first = new ListNode<T>(value, null, first);
            }
        }


        public void AddAfter(ListNode<T> parent, T value)
        {
            if (first == null)
            {
                return;
            }

            ListNode<T> newNode = new ListNode<T>(value);

            ListNode<T> cur = parent.next;
            parent.next = newNode;
            newNode.prev = parent;
            if (cur == null)
            {
                last = newNode;
                newNode.next = null;
            }
            else
            {
                newNode.next = cur;
                cur.prev = newNode;
            }
            
        }

        public void Clear()
        {
            ListNode<T> cur = first;
            for (int i = 1; i < count; i++)
            {
                cur.prev = null;
                cur = cur.next;
                cur.prev.next = null;
            }

            cur = null;
            first = null;
            last = null;
        }


        public bool Containts(T value)
        {
            ListNode<T> cur = first;
            if (count > 0)
            {
                while (cur != null)
                {
                    if (Equals(cur.value, value))
                    {
                        return true;
                    }

                    cur = cur.next;
                }
            }
            return false;
        }

        public ListNode<T> Find(T value)
        {
            ListNode<T> cur = first;

            while (cur != null)
            {
                if (Equals(cur.value, value))
                {
                    return cur;
                }
                cur = cur.next;
            }

            return null;
        }


        public ListNode<T> FindLast(T value)
        {
            ListNode<T> cur = last;

            while (cur != null)
            {
                if (Equals(cur.value, value))
                {
                    return cur;
                }
                cur = cur.prev;
            }

            return null;
        }


        public void RemoveFirst()
        {
            if (count == 1)
            {
                first = null;
                last = null;
            }
            else if (count > 1)
                {
                    first = first.next;
                    first.prev = null;
                }
        }

        public void RemoveLast()
        {
            if (count == 1)
            {
                first = null;
                last = null;
            }
            else if (count > 1)
                {
                    last = last.prev;
                    last.next = null;
                }
        }

        public void Remove(ListNode<T> node)
        {
            if ( (first == node)||(count == 1) )
            {
                RemoveFirst();
                return;
            }

            if (last == node)
            {
                RemoveLast();
                return;
            }

            node.prev.next = node.next;
            node = null;
        }


        public void Remove(T value)
        {
            Remove(Find(value));
        }


        override public bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                LinkedList<T> p = (LinkedList<T>)obj;
                ListNode<T> cur = first;
                ListNode<T> curObj = p.first;
                
                while ((curObj != null) && (cur != null))
                {
                    if ( !Equals(cur.value, curObj.value) )
                        return false;

                    curObj = curObj.next;
                    cur = cur.next;
                }

                if ((curObj == null) && (cur != null))
                    return false;

                if ((curObj != null) && (cur == null))
                    return false;

                return true;
            }
        }


    }
}
