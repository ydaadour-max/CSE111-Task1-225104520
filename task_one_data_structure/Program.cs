using System;

namespace CselllTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentList list = new StudentList();


            list.AddFront(20);
            list.AddFront(10);
            list.AddEnd(30);
            list.AddEnd(40);
            list.Reverse();
            list.Remove(20);


            list.Print();
        }
    }
}