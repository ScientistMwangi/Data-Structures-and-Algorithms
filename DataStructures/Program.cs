using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> NumberArray = new List<int> { 79, 69, 9, 95, 65, 49, 65, 40, 27, 95 };

            //Sorted List elements
            foreach (int n in MergeSort.DivideSortList(NumberArray))
            {
                //Console.Write(n + " ");
            }
            //Console.WriteLine(MergeSort.DivideArray(NumberArray).LastOrDefault());

            /**************
             * 
             * START QUEUE
             * 
             * ************/
            CustomQueue q = new CustomQueue();
            CustomQueue.IsEmpty();
            CustomQueue.Dequeue();
            CustomQueue.Enqueue(10);
            CustomQueue.Enqueue(20);
            CustomQueue.Enqueue(30);
            CustomQueue.Enqueue(40);
            CustomQueue.Enqueue(50);
            CustomQueue.Enqueue(60);
            CustomQueue.Dequeue();
            CustomQueue.Dequeue();
            CustomQueue.Dequeue();
            CustomQueue.Dequeue();
            CustomQueue.Dequeue();
            CustomQueue.Dequeue();
            CustomQueue.Peek();

            Console.WriteLine(q.ToString());

            /**************
             * 
             * END OF QUEUE
             * 
             * ************/





            /***
             * Stack implementation
             */
            /*Stack MyStack = new Stack(5);
            MyStack.Push(20);
            MyStack.Push(10);
            MyStack.Push(1);
            MyStack.Push(6);
            MyStack.Push(12);
            MyStack.Push(76);
            Console.WriteLine(MyStack.ToString());
            //MyStack.Pop();
            //MyStack.Pop();
            //MyStack.Pop();
            Console.WriteLine(MyStack.ToString());*/
            /**************
             * 
             * END OF STACK
             * 
             * ************/

            /**************
             * 
             * PRIME NUMBERS
             * 
             * ************/
            //Console.WriteLine ("PRIME NUMBER OPERATIONS");
            //Console.WriteLine("Is 4567679111 a Prime Number " + PrimeNumbers.IsPrime(456767911));
            //PrimeNumbers.PrintPrimeNumberBtn100and500();

            /******
             * LINKEDLIST
             * 
             * ********/
            SingleLinkedList singleLinkedList = new SingleLinkedList("Initial Value");
            singleLinkedList.AddNodeFirst("Samuel1");
            singleLinkedList.AddNodeFirst("Samuel2");
            singleLinkedList.AddNodeFirst("Samuel3");
            singleLinkedList.AddNodeFirst("Samuel4");
            //singleLinkedList.PrintListValues();
            //singleLinkedList.RemoveFirst();
            singleLinkedList.RemoveLast();
            singleLinkedList.PrintListValues();
            Console.WriteLine("============================Before");
            Node matechedNode1 = singleLinkedList.FindNode("Samuel1");
            singleLinkedList.AddBefore(matechedNode1, "MaShalby", true);
            Console.WriteLine("============================After");
            singleLinkedList.AddAfter(matechedNode1, "MaShalby", true);
            //  Console.WriteLine("Matched Node= " + matechedNode1.ToString());
            Console.WriteLine("List size is: "+singleLinkedList.Size());
            Console.WriteLine("End of the first list");

            SingleLinkedList singleLinkedList2 = new SingleLinkedList("Initial last value ");
            Console.WriteLine("AddNodeLast.............: "+singleLinkedList2.Size());
            singleLinkedList2.AddNodeLast("last Samuel 2");
            singleLinkedList2.AddNodeLast("last Samuel3");
            singleLinkedList2.AddNodeLast("last Samuel4");

            //singleLinkedList2.AddNodeLast("last AddNodeLast");
            //singleLinkedList.Remove("Sam");
            Console.WriteLine("AddNodeLast......SIZE.......: " + singleLinkedList2.Size());
            //singleLinkedList2.PrintListValues();
            //singleLinkedList2.Remove("last Samuel4");
            //singleLinkedList2.PrintListValues();
            Node matechedNode = singleLinkedList2.FindNode("last Samuel3");
            Console.WriteLine("Matched Node= " + matechedNode.ToString());
            //Console.WriteLine("Remove Node Above Node:  ");
            singleLinkedList2.PrintListValues();
            singleLinkedList2.AddAfter(matechedNode, "SHALBY", true);
            //singleLinkedList2.PrintListValues();
            //singleLinkedList2.removeNode(matechedNode,true);
            singleLinkedList2.Find("last Samuel3");
            //singleLinkedList2.Find("SHALBY");



            /*******
             * BINARY TREE OPERATIONS
             * 
             * *****/
            Console.WriteLine("ADVANCE DATASTRUCTURE");
            Console.WriteLine("BINARY TREE");
            TreeNode BinaryTree = new TreeNode(19);
            BinaryTree.Insert(33);
            BinaryTree.Insert(3);
            BinaryTree.Insert(9);
            BinaryTree.Insert(0);
            BinaryTree.Insert(-1);
            BinaryTree.Insert(20);
            //INORDER 
            BinaryTree.PrintInorder();
            // Search 
            string IsFound=BinaryTree.Contain(20)==true?"Found":"Not Found";
            Console.WriteLine(IsFound);

            /*********
             * 
             * Graph Datastructure
             * 
             * ********/
            Console.WriteLine("Graph Opertations");
            Graph g = new Graph(4);
            g.AddEdge(0,1);
            g.AddEdge(1, 2);
            g.AddEdge(2, 3);
            g.AddEdge(3, 0);
            // Print Graph Values
            g.DisplayGraph();
           

            Console.ReadKey();
        }
    }

    public static class MergeSort
    {
        public static List<int> DivideSortList(List<int> UnsortedList)
        {
            int Size = UnsortedList.Count;
            int Mid = Size / 2;
            List<int> Left = new List<int>();
            List<int> Right = new List<int>();
            if (Size > 1)
            {
                for (int i = 0; i < Mid; i++)
                {
                    Left.Add(UnsortedList[i]);
                }

                for (int j = Mid; j < Size; j++)
                {
                    Right.Add(UnsortedList[j]);
                }

                Left = DivideSortList(Left);
                Right = DivideSortList(Right);
                return Merged(Left, Right);
            }
            else
            {
                // empty/or already sorted
                return UnsortedList;
            }
        }

        public static List<int> Merged(List<int> Left, List<int> Right)
        {
            List<int> Result = new List<int>();
            while (Left.Count > 0 || Right.Count > 0)
            {
                if (Left.Count > 0 && Right.Count > 0)
                {
                    if (Left.First() < Right.First())
                    {
                        Result.Add(Left.First());
                        Left.Remove(Left.First());
                    }
                    else
                    {
                        Result.Add(Right.First());
                        Right.Remove(Right.First());
                    }
                } else if (Left.Count > 0)
                {
                    Result.Add(Left.First());
                    Left.Remove(Left.First());
                } else if (Right.Count > 0)
                {
                    Result.Add(Right.First());
                    Right.Remove(Right.First());
                }
            }
            return Result;
        }
    }

    public  class CustomQueue
    {
         static int SIZE = 5;
         public static int front =-1;
         public static int count = 0;
         static int[] MyQueue = new int[SIZE];

        public static int Size()
        {
            return SIZE;
        }

        public static bool IsFull()
        {

            if (SIZE == count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsEmpty()
        {
            if (front == -1 && count==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Enqueue(int value)
        {
            if (!IsFull())
            {
                MyQueue[++front] = value;
                ++count;
            }
            else
            {
                Console.WriteLine("Queue is full!");
            }
        }

        public static void Peek()
        {
            if (!IsEmpty())
            {
                Console.WriteLine(" QUEUE VALUE: "+MyQueue[front]);
            }
            else
            {
                Console.WriteLine(" QUEUE IS EMPTY");
            }
            
        }
        
        public static void Dequeue()
        {
            if (!IsEmpty())
            {
                Console.WriteLine(" QUEUE VALUE: " + MyQueue[front]);
                --count;
                --front;
            }
            else
            {
                Console.WriteLine("Queue is Empty");
            }
        }

        public override string ToString()
        {
            return String.Join(",",MyQueue);
        }


    }

    public class Stack
    {
        public  int[] array;
        public  int top = -1;
        //public const int SIZE = 4;

        public Stack(int Size)
        {
            array = new int[Size];
        }

        public  void Push(int value)
        {
            if (top == 4)
            {
                Console.WriteLine("Stack overflow");
            }
            else
            {
                ++top;
                array[top] = value;
                Console.WriteLine("Value added: "+value +" stack size "+array.Count());
            }
        }

        public  void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack underflow");
            }
            else
            {
                Console.WriteLine(array[top]);
                --top;
            }
        }

        public override string ToString()
        {
            return String.Join(",",array);
        }
    }

    public static class PrimeNumbers
    {
        public static void PrintPrimeNumberBtn100and500()
        {
            
            // Print all prime numbers between 100-500
            for (int i = 100; i <= 500; i++)
            {
                bool IsPrime = true;
                if (i % 2 == 0 || i % 3 == 0 || i%5==0|| i % 7== 0)
                {
                    IsPrime = false;
                }
                else
                {
                    for(int j = 8; j * j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            IsPrime = false;
                            break;

                        }
                    }
                }

                if (IsPrime)
                {
                    Console.WriteLine(i+": Is a Prime Number.");
                }
            }
        }
        public static bool IsPrime(long n)
        {
            Boolean Prime = true;
            if (n == 2)
            {
                return Prime;
            }
            else
            {
                for (long i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        Prime = false;
                        break;
                    }

                }
                return Prime;
            }

        }
    }

    public class Node
    {
        public Object data;
        public Node next;
        public Node(Object ob)
        {
            data = ob;
            next = null;
        }

        public override string ToString()
        {
            return data.ToString();

        }
    }

    public class SingleLinkedList
    {
        private Node head;
        private static int size = 0;

        public SingleLinkedList(Object ob)
        {
            head = new Node(ob);
            size = 1;
        }

        /*public Node Last
        {
            get
            {
                Node p = head;
                while (p.next != null)
                {
                    p = p.next;
                }
                return p;
            }
            set { 
                Last.next = value.next;
                Last.data = value.data;
            }
        }*/

        public void AddNodeFirst(Object ob)
        {
            Node newNode = new Node(ob);
            newNode.next = head;
            head = newNode;
            ++size;
        }

        public void AddNodeLast(Object ob)
        {
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node(ob);
            ++size;

        }
        public void PrintListValues()
        {
            Node current = head;
            int number = size;
            while (current != null)
            {
                Console.WriteLine(size+": list value: "+current.data);
                --number;
                current = current.next;
            }
        }

        public int Size()
        {
            return size;
        }
        public void Find(Object ob)
        {
            Node current = head;
            bool isFound = false;
            string valueFound = ob.ToString()+": Value NOT FOUND! ";
            while (current != null)
            {
                if (current.data == ob)
                {
                    isFound = true;
                }
                current = current.next;
            }
           
            if(isFound)
            {
                valueFound = ob.ToString()+":The Value is Found " ;
            }
            Console.WriteLine(valueFound);
        }

        public Node FindNode(Object ob)
        {
            Node current = head;
            Node matchedNode = null;
            while (current != null)
            {
                if (current.data == ob)
                {
                    matchedNode= current;
                }
                current = current.next;
            }
            return matchedNode;
        }

        // Need the use of node to remove it
        public void Remove(Object ob)
        {
            Node current = head;
            while (current!=null)
            {
                if (current.data == ob)
                {
                    current = current.next;
                    break;
                }
                current = current.next;
            }
        }
        
        // Remove Nodes,first,last,any

        public void removeNode(Node node,bool verbose=false)
        {
            Node current = head;
            while (current.next != node)
             {
                current = current.next;
             }
            current.next = node.next;
            --size;
            if (verbose)
                 PrintListValues();

            
        }

        public void RemoveFirst()
        {
            
            Node first = head.next;
            head= first;
            --size;
        }

        public void RemoveLast()
        {
            Node current = head;
            Node current2 = head;
            Node lastNode;
             while (current.next != null)
             {
                 current=current.next;
             }
             lastNode = current;
             Console.WriteLine("Last Node "+lastNode.ToString());
             Node temp = lastNode;
             while (current2.next != lastNode)
             {
                 current2 = current2.next;

             }
             current2.next = null;
        }

        public void AddAfter(Node nodeAfter,object ob,bool verbose = false)
        {
            Node current = head;
            Node newNode = new Node(ob);
      
            while (current!=nodeAfter)
            {
                current = current.next;
            }
            newNode.next = current.next;
            current.next = newNode;

            if (verbose)
               PrintListValues();

        }
        public void AddBefore(Node nodeAfter, object ob, bool verbose = false)
        {
            Node current = head;
            Node newNode = new Node(ob);

            while (current.next != nodeAfter)
            {
                current = current.next;
            }
            newNode.next = current.next;
            current.next = newNode;

            if (verbose)
                PrintListValues();

        }

        public void ReplaceNodeData(Node nodeAfter,object ob,bool verbose = false)
        {
            Node current = head;
            while (current != null)
            {
                if (current == nodeAfter)
                {
                    Node newNode = new Node(ob);
                    nodeAfter.data = newNode.data;
                    nodeAfter.next = newNode.next;
                    current = newNode;
                 }
                current = current.next;
            }
            if (verbose)
                PrintListValues();
        }
     }

    // Advanced Data stracture Tree and Graph---non renear data stract...hierarchical data st
    // Tree Binary Tree Implementation
    // Inorder print 1234...good for sorting out insert O(logn) insert delete
    // AVL tree make the binary tree balance to maintain the operations O(logn)
    // Uses of tree... file strac,decision tree
    // Min and Max Heap priority queue

    public class TreeNode {
        public TreeNode Left, Right;
        public int Data;

        public TreeNode(int data)
        {
            Data = data;
        }
        // Insert ,find, delete,inorder
        public void Insert(int value)
        {
            if (Data > value)
            {
                if (Left == null)
                {
                    Left = new TreeNode(value);
                }
                else
                {
                    Left.Insert(value);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new TreeNode(value);
                }
                else
                {
                    Right.Insert(value);
                }
            }
        }

        public bool Contain(int SearchValue)
        {

            if (Data == SearchValue)
            {
                return true;
            }else if (Data > SearchValue)
            {
                if (Left == null)
                {
                    return false;
                }
                else
                {
                    return Left.Contain(SearchValue);
                }
            }
            else
            {
                if (Right == null)
                {
                    return false;
                }
                else
                {
                   return Right.Contain(SearchValue);
                }
            }
        }

        // Inorder value insorted way left root right
        public void PrintInorder()
        {
            if (Left != null)
            {
                Left.PrintInorder();
            }
            Console.WriteLine(Data);
            if(Right != null)
            {
                Right.PrintInorder();
            }

        }

        // Postorder Left,Right,Root
        public void PostOrder()
        {
            if (Left != null)
            {
                Left.PostOrder();
            }
            if (Right != null)
            {
                Right.PostOrder();
            }
            Console.WriteLine(Data);
        }
        // Preorder Root,Left,Right
        public void PreOrder()
        {
            Console.WriteLine(Data);
            if (Left != null)
            {
                Left.PreOrder();
            }
            if (Right != null)
            {
                Right.PreOrder();
            }
        }
        // Delete and update in a binary tree
    }
    // Add Tries
    // Graph BFS and DFS solving problems with graph
    /**Graph Implementation using LinkedList**/

    public class Graph
    {
        int Nodes;
        public LinkedList<int>[] AddjacencyList;

        public Graph(int Vertices)
        {
            Nodes = Vertices;
            AddjacencyList  = new LinkedList<int>[Nodes];
            for(int i = 0; i < Vertices; i++)
            { 
                AddjacencyList[i] = new LinkedList<int>();
            }
                       
        }

        public void AddEdge(int Source, int Destination)
        {
            AddjacencyList[Source].AddLast(Destination);
            AddjacencyList[Destination].AddLast(Source);
        }

        public void DisplayGraph()
        {
            for(int v = 0; v < Nodes; v++)
            {
                Console.WriteLine("Vertex/Node: "+v+" is connected to:-");

                for(int e = 0; e < AddjacencyList[v].Count; e++)
                {
                    Console.WriteLine(" Edge: "+ AddjacencyList[v].ElementAt(e));
                    
                }
                Console.WriteLine();
            }
        }

    }

}
