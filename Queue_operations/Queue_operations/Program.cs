using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_operations
{
    class Program
    {
        static void Main(string[] args)
        {   Queue myqueue=new Queue();
            myqueue.enque(6);
            myqueue.enque(4);
             myqueue.enque(8);
             myqueue.enque(9);
             myqueue.enque(40);
            

             Console.WriteLine("pop element are ");
             myqueue.dequeu();
             myqueue.dequeu();
             Console.WriteLine("peek element is ");
             myqueue.peak();
             Console.WriteLine("count are");
             myqueue.count();
            
        }
    }
    public class Queue
    {   int rear=0;
        int front=0;
        
      
        int[]Queue1=new int[5];


        public void enque(int e)
        {
            if (rear == Queue1.Length)
            {

             Console.WriteLine("full");
           }
        else
            {
                Queue1[rear++] = e;
                Console.WriteLine(e);
            }
        }
        public void dequeu()
        {
            if (rear == front)
            {
                Console.WriteLine("empty");
            }
            else
            {
                {
                    int x;
                    x = Queue1[front];
                    front = front + 1;
                    Console.WriteLine(x);
                }

            }
        }
            
            public void peak()
        {
         int y;
            y=Queue1[front];
            Console.WriteLine(y);
        }


            public void count()
            {
                Console.WriteLine(front+1);
            }
    }
    
    }

