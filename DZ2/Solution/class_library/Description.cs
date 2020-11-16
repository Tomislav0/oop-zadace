using System;
using System.Collections.Generic;
using System.Text;

namespace class_library
{
    public class Description
    {
        int ep;
        TimeSpan lenght;
        string title;
        public Description(int ep,TimeSpan lenght, string title)
        {
            this.ep = ep;
            this.lenght = lenght;
            this.title = title;
        }
        public override string ToString()
        {
            return $"{ep}, {lenght}, {title}";
        }
        public int Ep { get => ep; }
        public TimeSpan Lenght { get => lenght; }
        public string Title { get => title; }
    }
}
