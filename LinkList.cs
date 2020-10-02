using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    public class LinkList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public LinkList() {
            Head = Tail = null;
        }

        public void InsertAfter(int value) {
            Node Item = new Node(value);
            if (Head==null) {
                Head = Tail = Item;
            }
            else {
                Tail.Next = Item;
                Tail =Item;
            }


        }

        public void Includes()
        {

        }


    }
}
