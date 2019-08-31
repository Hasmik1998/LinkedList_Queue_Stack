using System;

namespace HW1
{
    public class DoublyLinkedList<E>
    {
        public DoublyNode<E> head { get; set; }
        public DoublyNode<E> tail { get; set; }
        public int size;

        public DoublyLinkedList()
        {
            size = 0;
        }

        public bool isEmpty()
        {
           return size == 0;
        }

        public E first()
        {
           // if (isEmpty()) return default();
            return head.element;
        }
        public E last()
        {
         //   if (isEmpty()) return default();
            return tail.element;
        }

        public void addFirst(E value)
        {
            if (size == 0)
            {
                DoublyNode<E> newNode = new DoublyNode<E>(value, null, null);
                head = newNode;
                tail = newNode;
            }
            else
            {


                DoublyNode<E> newNode = new DoublyNode<E>(value, head, null);
                head.previous = newNode;
                head = newNode;
            }
            size++;

        }
        public void addLast(E value)
        {
            if (size == 0)
            {
                DoublyNode<E> newNode = new DoublyNode<E>(value, null, null);
                head = newNode;
                tail = newNode;
            }
            else
            {


                DoublyNode<E> newNode = new DoublyNode<E>(value, null, tail);
                tail.next = newNode;
                tail = newNode;
            }
            size++;

        }

        public void RemoveFirst()
        {
         DoublyNode<E> tmp = head;
         head = head.next;
         tmp = null;
         size--;
        }

        public void RemoveLast()
        {
            DoublyNode<E> tmp = tail;
            tail.previous = tail;
            tmp = null;
        }

        public void Remove(int index)
        {
            DoublyNode<E> tmp = head;
            DoublyNode<E> tmp1;
            DoublyNode<E> tmp2;


            for (int i = 0; i < index; ++i)
            {
                tmp = tmp.next;
            }

            tmp1 = tmp.next;
            tmp2 = tmp1.next;
            tmp.next = tmp2;
            tmp2.previous = tmp;
            tmp1 = null;
            size--;
        }

        public void Revers()
        {
            DoublyNode<E> tmpprev = null, tmpcur = head, tmpnext = null;
            while (tmpcur != null) { 
                tmpnext = tmpcur.next; 
                tmpcur.next = tmpprev; 
                tmpprev = tmpcur; 
                tmpcur.previous = tmpnext;
                tmpcur = tmpnext;
               
            } 
            head = tmpprev; 

        }
        public void print()
        {
            DoublyNode<E> tmp = head;
            while (tmp!=null)
            {
                Console.Write(tmp.element+" ");
                tmp = tmp.next;
            }

            Console.WriteLine();
        }
        
        public void Insert(int index, DoublyNode<E> value)
        {
            if(isEmpty())
                Console.WriteLine("LinkedList is empty");
            DoublyNode<E> tmp = head;
            for (int i = 0; i < index; i++)
            {
                tmp = tmp.next;
            }

            value.next = tmp.next;
            value.previous =tmp;
            size++;
        }
        
        
    }
}