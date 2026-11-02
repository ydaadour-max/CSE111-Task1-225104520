// Name: Yosssif Dadour
// Student ID: 225104520

using System;

namespace CselllTask1
{
    public class StudentList
    {
        public Student? First { get; private set; }
        public Student? Last { get; private set; }
        public int Count { get; private set; }

        public StudentList()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        public void AddFront(int id)
        {
            Student newStudent = new Student(id);
            if (Count == 0)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                newStudent.Next = First;
                First = newStudent;
            }
            Count++;
        }

        public void AddEnd(int id)
        {
            Student newStudent = new Student(id);
            if (Count == 0)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                if (Last != null)
                {
                    Last.Next = newStudent;
                }
                Last = newStudent;
            }
            Count++;
        }

        public bool Remove(int id)
        {
            if (Count == 0 || First == null)
            {
                return false;
            }


            if (First.Id == id)
            {
                First = First.Next;
                Count--;
                if (Count == 0)
                {
                    Last = null;
                }
                return true;
            }


            Student current = First;
            while (current.Next != null)
            {
                if (current.Next.Id == id)
                {
                    current.Next = current.Next.Next;
                    Count--;

                    if (current.Next == null)
                    {
                        Last = current;
                    }
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public void Reverse()
        {
            if (Count <= 1)
            {
                return;
            }

            Student? prev = null;
            Student? current = First;
            Student? nextNode = null;


            Last = First;

            while (current != null)
            {
                nextNode = current.Next;
                current.Next = prev;
                prev = current;
                current = nextNode;
            }

            First = prev;
        }

        public void Print()
        {
            Student? current = First;
            bool firstItem = true;
            while (current != null)
            {
                if (!firstItem)
                {
                    Console.Write(" ");
                }
                Console.Write(current.Id);
                firstItem = false;
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}