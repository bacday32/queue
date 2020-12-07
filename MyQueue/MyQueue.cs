using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    class MyQueue<T>
    {
        public int topIndex { get; set; } = -1;
        private T valueQueue { get; set; } = default(T);
        public List<T> list { get; set; } = new List<T>();
        public bool IsEmpty()
        {
            if(list.Count==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public T DeQueue()
        {
            if(IsEmpty())
            {
                Console.WriteLine("<<<<<Queue is empty>>>>>");
                Console.ReadLine();
            }
            T item = list[0];
            list.Remove(item);
            return item;                  
        }
        public void EnQueue(T valueQueue)
        {
            Console.WriteLine("Enter value QUEUE>>>>>");
            list.Add(valueQueue);
        } 
        public T Front()
        {
            return list[0];
        }
    }
}
