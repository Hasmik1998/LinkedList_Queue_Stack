using System;
using System.Runtime.CompilerServices;

namespace HW1
{
    public class Queue <E>
    {
        private LinkedList<E> queue;

        public Queue()
        {
            queue=new LinkedList<E>();
        }

        public void EnQueue(E element)
        {
            if(!queue.isEmpty())
                queue.addLast(element);
            return;
        }

        public E DeQueue()
        {
            E result = queue.first();
            queue.removeFirst();
            return result;
        }
        public E Peek() 
        {
            return queue.first();
        }
        public bool IsEmpty() 
        {
            return !queue.isEmpty();
        }

        public void Print()  
        {
            if (!queue.isEmpty())
            {
                Console.WriteLine("The stack is empty");
                return;
            }

            Console.WriteLine("The emelents are");
            queue.print();
        }

        public void Reverse()
        {
            queue.ReverseList();
        }
        
        public int Count()
        {
            return queue.Size();
        }
    }
}