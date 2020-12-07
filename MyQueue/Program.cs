using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<string> st = new MyQueue<string>();
            while(true)
            {
                Console.WriteLine("what do you want with QUEUE? :");
                Console.WriteLine("1: EnQueue");
                Console.WriteLine("2: DeQueue");
                Console.WriteLine("3: Front");
                int num = int.Parse(Console.ReadLine());
                switch(num)
                {
                    case 1:
                        Console.WriteLine("Enter value QUEUE: ");                       
                        string valueQueue = Console.ReadLine();
                        st.EnQueue(valueQueue);
                        break;
                    case 2:
                        Console.WriteLine("<<<Remove>>> "+ st.DeQueue() +" <<<in QUEUE>>>");
                        Console.WriteLine("Enter to continue");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Value front in QUEUE is:>>" + st.Front());
                        Console.WriteLine("Enter to continue");
                        Console.ReadLine();
                        break;
                }
            }
        }   
    }
}
