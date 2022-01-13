using System;
using System.Collections.Generic;
using System.Text;

namespace StackConsole
{
    class Stack
    {
        public List<object> contents = new List<object>();


        public void Push(object obj)
        {
            contents.Add(obj);
        }
        public object Pop()
        {
            Object value;
            value = contents[contents.Count - 1];
            contents.RemoveAt(contents.Count - 1);
            return value;
        }
        public void Clear()
        {
            contents.Clear();
        }
    }
}
