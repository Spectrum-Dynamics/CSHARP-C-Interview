//Implement Linked list of int by given interface, 
//implement reverse method without additional arrays or collections:

    public class Node
    {
        public int Data;
        public Node Next;
    }
    
    public interface IMyList
    {
        Node Head { get; set; }

        void Add(int elm );   // add new element
        void PrintAll();   //print all list
        void Reverse(); // reverse list, implement without using helpers collection\arrays  
    }

