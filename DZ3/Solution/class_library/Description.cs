using System;
using System.Collections.Generic;
using System.Text;

namespace class_library
{
    public class Description
    {
        int ep;
        TimeSpan length;
        string title;
        public Description(int ep,TimeSpan length, string title)
        {
            this.ep = ep;
            this.length = length;
            this.title = title;
        }
        public override string ToString()
        {
            return $"{ep}, {length}, {title}";
        }
        public int Ep { get => ep; }
        public TimeSpan Length { get => length; }
        public string Title { get => title; }
    }
}
