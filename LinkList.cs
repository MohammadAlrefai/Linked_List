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
        public bool Includes(int value) {
            var current = Head;
            while (current!=null) {
                if (current.Data==value) {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public void Show () {
            var current = Head;
            while (current != null) {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public string To_String() {
            var data = ""; 
            var current = Head;
            while (current!=null) {
                data +=" { " +current.Data + " } -> ";
                current = current.Next;
            }
            data += " NULL";
            return data;
        }

    }
}
