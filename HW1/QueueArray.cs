using System;
using System.ComponentModel.Design;

namespace HW1
{
    public class QueueArray
    {
        public int[] arr ;
        private int  size=0, _front;

        public QueueArray(int size) {
            arr = new int[size];
             _front=-1;
        }

        public bool IsEmpty()
        {
            return (size == 0);
        }
        

        public void push(int item)
        {
                 if (size == arr.Length)
                     Console.WriteLine("Queue is full");
                 int avail = (_front + size) % arr.Length;
                  arr[avail] = item;
                 size++;
                 
            
        }

        public int pop()
        {

             if (IsEmpty()) 
                 return default;
             
             int answer = arr[_front];
             arr[_front] = default;
             _front = (_front + 1) % arr.Length;
             --size;
             return answer;
        }

        public int peek()
        {
            if (_front == -1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                return arr[_front];
            }
        }

        public void printQueue()
        {
            if (_front == -1){
                Console.WriteLine("Queue is Empty");
                return;
            } else {
                for (int i = _front+1; i < arr.Length-1; i++) {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        public void Reverse()
        {
            int front = 0;
            int lastIndex = arr.Length - 1;
            for (int i = 0; i < arr.Length / 2; ++i)
            {
                front = arr[i];
                arr[i] = arr[lastIndex];
                arr[lastIndex] = front;
                lastIndex--;
            }
        }
    }
}
    