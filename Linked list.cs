using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16_DatastructureDemo.linkedlist1
{
    class Linkedlist
    {

   
       internal Node head; //new
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list");
        }



        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(  " ");
                temp = temp.next; //temp=null
            }
        }
        // 3 15
        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (position-- != 0) //
                {

                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    temp = temp.next;//1000
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }



        internal Node RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }

    }

    internal class Node
    {
        private int data;

        public Node(int data)
        {
            this.data = data;
        }

        public Node next { get; internal set; }
    }
}

