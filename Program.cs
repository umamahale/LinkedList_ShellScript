using System;
using System.Collections.Generic;

namespace LinkedList11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            UC2LinkedList list = new UC2LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //list.InsertAtParticularPosition(2,30);
            list.Display();
        }
    }
}
