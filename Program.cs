using System;
namespace Linked_List {
    class Program {
        static void Main(string[] args) {
            LinkList L = new LinkList();
            L.InsertAfter(12);
            L.InsertAfter(13);
            Console.WriteLine( L.Includes(12)==true? "found" : "Not found" );
            Console.WriteLine(L.To_String()); 
        }
    }
}
