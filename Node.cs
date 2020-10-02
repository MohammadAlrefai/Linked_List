using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    public class Node {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node() {
            Data = 0;
            Next = null;
        }
        public Node(int value) {
            Data = value;
            Next = null;
        }
       
    }
}
