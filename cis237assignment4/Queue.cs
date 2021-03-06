﻿// Kyle Sherman
// Assignment 4
// Due 3/20/17
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Queue<T>
    {
        // new node class inside the queue class
        protected class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        protected Node _head;
        protected Node _tail;
        protected int _size;

        // chekc if there is any nodes to be found
        public bool IsEmpty
        {
            get { return _head == null; }
        }

        // find the size of the list
        public int Size
        {
            get { return _size; }
        }
        
        // add a new node to the back of the queue
        public void AddToBack(T Data) // queue
        {
            Node oldTail = _tail;   // set the old tail to the current tail 
            _tail = new Node(); // create a new tail node
            _tail.Data = Data;  // assign the new tail some data
            _tail.Next = null;  // set the next tail to null

            // if the list is empty then the tail and head are the same 
            if (IsEmpty)
                _head = _tail;
            else
                oldTail.Next = _tail;
        }

        // dequeue a node
        public T RemoveFromFront() // dequeue
        {
            // throw an exception if the list is empty
            if (IsEmpty)
                throw new Exception("List is empty");

            // return the head data
            T returnData = _head.Data;

            // the next head is the new head
            _head = _head.Next;
            _size--; // decrement the size

            // if it's empty then set the tail to null 
            if (IsEmpty)
                _tail = null;

            return returnData;
        }

        // display the node data
        public void Display()
        {
            Console.WriteLine("The list is: ");
            Node currentNode = _head;
            while(currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;
            }
        }
    } 
}
