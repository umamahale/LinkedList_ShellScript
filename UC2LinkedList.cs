using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList11
{
    class UC2LinkedList
    {
        internal Node head; //new
        internal void Add(int data)
        {
            Node node = new Node( data);
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
            Console.WriteLine("{30} {56} inserted into the linked list");
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
                Console.Write(" ");
                temp = (Node)temp.next1; //temp=null
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
                newNode.next1 = this.head;
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
                        node.next1 = this.head.next1;
                        head.next1 = node;
                        break;
                    }
                    temp = (Node)temp.next1;//1000
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
            this.head = (Node)this.head.next1;
            return this.head;
        }

    }

    //internal class Node
    //{
       // internal Node next1;
       // private int data;

       // public Node(int data)
       // {
           // this.data = data;
        //}

        //public Node next { get; internal set; }
    }
///}
    

