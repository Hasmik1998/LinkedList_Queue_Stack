namespace HW1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace Stack
    {
        public class Stack<T>
        {
            public LinkedList<T> MyCollection;

            public Stack()
            {
                MyCollection = new LinkedList<T>();
            }

            public void Push(T obj) 
            {
                MyCollection.addFirst(obj);   
            }

            public T Peek() 
            {
                return MyCollection.first();
            }

            public T Pop() 
            {
                T result = MyCollection.first();
                MyCollection.removeFirst();
                return result;
            }

            public bool IsEmpty() 
            {
                return !MyCollection.isEmpty();
            }

            public void Print()  
            {
                if (!MyCollection.isEmpty())
                {
                    Console.WriteLine("The stack is empty");
                    return;
                }

                Console.WriteLine("The emelents are");
                MyCollection.print();
            }

            public void Reverse()
            {
                MyCollection.ReverseList();
            }

            public int Count()
            {
                return MyCollection.Size();
            }
        }
    }
}