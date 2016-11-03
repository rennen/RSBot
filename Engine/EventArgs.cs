using System;

namespace Engine
{
    public class EventArgs<T> : EventArgs
    {
        public EventArgs()
        {
        }

        public EventArgs(T content)
        {
            Content = content;
        }


        public T Content { get; set; }
    }
}