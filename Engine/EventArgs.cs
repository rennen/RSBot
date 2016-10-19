using System;

namespace Engine
{
    public class EventArgs<T> : EventArgs
    {
        public T Content { get; set; }
    }
}