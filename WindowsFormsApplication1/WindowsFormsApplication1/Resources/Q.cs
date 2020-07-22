using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{

    public class node
    {
        public string command;
        public node next;
    }

    public class Q
    {
        private node last = new node();
        private node front = new node();


        public Q()
        {
            front = null;
            last = null;
        }
        public void enqeue(string item)
        {
            node temp = new node();
            temp.command = item;
            temp.next = null;
            if (front == null)
            {
                front = temp;
                last = temp;
            }
            else
            {
                last.next = temp;
                last = temp;
            }
        }
        public string dequeue()
        {
            string item;
            node temp = front;
            item = temp.command;
            front = front.next;
            if (front == null)
                last = null;

            return item;
        }
        public bool isEmpty()
        {
            if (front == null)
                return true;
            else
                return false;
        }

        public string peek()
        {
            return front.command;
        }
    };


}