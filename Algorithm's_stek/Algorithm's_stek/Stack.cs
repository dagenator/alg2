using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_s_stek
{
    public class Stack
    {
        private List<String> StackStruct = new List<String>();

        //Push(elem), Pop(), Top(), isEmpty(), Print().

        public void Push(int elem)
        {
            StackStruct.Add(elem.ToString());
        }

        public void  Push(string elem)
        {
            StackStruct.Add(elem);
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return null;
            }
            string temp =  StackStruct[StackStruct.Count - 1];
            StackStruct.RemoveAt(StackStruct.Count - 1);
            return temp;
        }

        public string Top()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return null;
            }
            return StackStruct[StackStruct.Count-1];
        }

        public bool IsEmpty()
        {
            return StackStruct.Count == 0;
        }

        public void Print()
        {
            
            if (IsEmpty()) {
                Console.WriteLine("Stack is empty");
                return;
            }
                

            Console.Write("Stack: ");
            for (int i = 0; i < StackStruct.Count; i++) 
            {
                Console.Write(StackStruct[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
