using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace CSTest
{

    class DLinkedList
    {

        private int data;

        private DLinkedList next;

        private DLinkedList prev;

        public DLinkedList()
        {

            data = 0;

            next = null;

            prev = null;

        }

        public DLinkedList(int value)
        {

            data = value;

            next = null;

            prev = null;

        }



        public DLinkedList InsertNext(int value)
        {

            DLinkedList node = new DLinkedList(value);

            if (this.next == null)
            {

                node.prev = this;

                node.next = null; 

                this.next = node;

            }

            else
            {


                DLinkedList temp = this.next;

                node.prev = this;
                    
                node.next = temp;

                this.next = node;

                temp.prev = node;

            }

            return node;

        }

        public DLinkedList InsertPrev(int value)
        {

            DLinkedList node = new DLinkedList(value);

            if (this.prev == null)
            {

                node.prev = null; 

                node.next = this;

                this.prev = node;

            }

            else
            {

                DLinkedList temp = this.prev;

                node.prev = temp;

                node.next = this;

                this.prev = node;

                temp.next = node;

            }

            return node;

        }



        public void TraverseFront()
        {

            TraverseFront(this);

        }



        public void TraverseFront(DLinkedList node)
        {

            if (node == null)

                node = this;

            System.Console.WriteLine("Traversing in Forward Direction\n\n");



            while (node != null)
            {

                System.Console.WriteLine(node.data);

                node = node.next;

            }

        }

        static void Main(string[] args)
        {

            DLinkedList node1 = new DLinkedList(1);

            DLinkedList node3 = node1.InsertNext(3);

            DLinkedList node2 = node3.InsertPrev(2);

            DLinkedList node5 = node3.InsertNext(5);

            DLinkedList node4 = node5.InsertPrev(4);



            node1.TraverseFront();


        }

    }

}
