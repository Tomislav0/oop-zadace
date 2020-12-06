using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace class_library
{
    public class FilePrinter : IPrinter
    {
        string filename;
        public FilePrinter(string filename)
        {
            this.filename = filename;
        }
        public void Print(string toprint)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(toprint);
            }
        }
    }
}
