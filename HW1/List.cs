using System;
using System.Runtime.InteropServices;

namespace HW1
{
    public class LinkedList<E> {

        public Node<E> head = null;
        public Node<E> tail = null;
        private int size = 0;
        public LinkedList(){}
        public int Size() { return size; }

        public bool isEmpty()
        {
            return size==0;
        }
        public E first()
        {
   //         if (isEmpty()) return default();
            return head.getElement();
        }
        public E last()
        {
       //     if (isEmpty()) return default();
            return tail.getElement();
        }
        public void addFirst(E e)
        {
            head = new Node<E>(e, head); 
            if (size == 0)
                tail = head;
            size++;
        }
        public void addLast(E e)
        {
            Node<E> newest = new Node<E>(e, null);
            if (isEmpty( )) 
                head = newest;
            else
                tail.setNext(newest); 
            tail = newest;
            size++;
        }
        public E removeFirst()
        {
           // if (isEmpty( )) return default();
            E answer = head.getElement( ); 
            head = head.getNext( );
            size--;
            if (size == 0)
                tail = null; 
            return answer;
        }
        public void ReverseList() 
        { 
            Node<E> tmpprev = null, tmpcur = head, tmpnext = null; 
            while (tmpcur != null) { 
                tmpnext = tmpcur.next; 
                tmpcur.next = tmpprev; 
                tmpprev = tmpcur; 
                tmpcur = tmpnext; 
            } 
            head = tmpprev; 
        }

        public void Insert(int index, Node<E> value)
        {
            if(isEmpty())
                Console.WriteLine("LinkedList is empty");
            Node<E> tmp = head;
            for (int i = 0; i < index; i++)
            {
                tmp = tmp.next;
            }
            value.setNext(tmp.next);
            tmp.setNext(value);
            size++;
        }
        public void print()
        {
            Node<E> tmp = head;
            while (tmp!=null)
            {
                Console.Write(tmp.element+" ");
                tmp = tmp.next;
            }

            Console.WriteLine();
        }
    }
}