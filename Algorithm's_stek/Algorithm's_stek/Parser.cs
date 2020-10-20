using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Algorithm_s_stek
{
    public class Parser
    {
        private Stack Stack = new Stack();
        public bool IsPrint;
        

        public string FindInput(int index, string command)
        {
            for (int i = index+2; i < command.Length; i++)
            {
                if (command[i] == ' ' || i+1 == command.Length)
                    return command.Substring(index + 2, i  - (index + 2));
            }
            throw new Exception();
        }


        //: 1 - Push(elem), 2 - Pop(), 3 - Top(), 4 - isEmpty(), 5 - Print(). 
        //Для операции push после единицы через запятую указывается значение помещаемого элемента (это может быть число либо слово).


        public void Parse(string command)
        {
            for(int i = 0; i< command.Length ; i++)
            {
                
                if (command.Length !=0 && command[i] -1 ==',') continue;

                switch (command[i])
                {
                    case ' ':
                        continue;
                    case ',':
                        continue;
                    case '1':
                        var input = FindInput(i, command);
                        Stack.Push(input);
                        if (IsPrint)
                            Console.WriteLine("Push: " + input);
                        break;
                    case '2':
                        if (IsPrint) Console.WriteLine("Pop: " + Stack.Pop());
                        else  Stack.Pop();
                        break;
                    case '3':
                        if (IsPrint)Console.WriteLine("Top: " + Stack.Top());
                        else Stack.Top();
                        break;
                    case '4':
                        if (IsPrint) Console.WriteLine("IsEmpty: " + Stack.IsEmpty());
                        else Stack.IsEmpty();
                        break;
                    case '5':
                        if (IsPrint) Stack.Print();
                        continue;
                }
            }
        }
    }
}
