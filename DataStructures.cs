using System;
using System.Collections;
using System.Text;

namespace DataStructures
{
    public class Node<T>
    {
        T data;
        public Node<T> next;

        public Node()
        {
            data = default(T);
            next = null;
        }

        public Node(T x)
        {
            data = x;
            next = null;
        }

        public void Append(T x)
        {
            if (next == null)
            {
                next = new Node<T>(x);
            }
            else
            {
                next.Append(x);
            }
        }



        public Node<T> GetLast()
        {
            if (next == null)
            {
                return this;
            }
            else
            {
                return next.GetLast();
            }
        }

        public int Count(int x = 0)
        {
            if (next == null)
            {
                return x;
            }
            else
            {
                x++;
                return next.Count(x);
            }
        }

        public void Print()
        {

            if (next != null)
            {
                Console.Write(" | " + data + " | " + "->");
                next.Print();
            }
            else
            {
                Console.WriteLine(" | " + data + " | ");
            }
        }
    }

    public class LinkedList<T>
    {
        Node<T> HeadNode;
        Node<T> LastNode;
        int Count;

        public LinkedList()
        {
            HeadNode = null;
            LastNode = null;
            Count = 0;
        }

        public LinkedList(T x)
        {
            HeadNode = new Node<T>(x);
            LastNode = HeadNode;
            Count = HeadNode.Count();
        }

        public void Append(T x)
        {
            if(HeadNode == null)
            {
                HeadNode = new Node<T>(x);
                LastNode = HeadNode;
            }
            else
            {
                HeadNode.Append(x);
                LastNode = HeadNode.GetLast();
            }
            Count = HeadNode.Count();
        }

        public void Prepend(T x)
        {
            if (HeadNode == null)
            {
                HeadNode = new Node<T>(x);
                LastNode = HeadNode;
            }
            else
            {
                Node<T> temp = new Node<T>(x);
                temp.next = HeadNode;
                HeadNode = temp;
            }
            Count = HeadNode.Count();
        }

        public void Print()
        {
            if (HeadNode == null)
            {
                return;
            }
            HeadNode.Print();
        }
    }
}
