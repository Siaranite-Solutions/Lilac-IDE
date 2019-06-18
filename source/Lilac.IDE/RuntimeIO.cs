﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apollo_IL;

namespace Lilac.IDE
{
    class RuntimeIO : Apollo_IL.Handlers.VConsole
    {
        public override void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
        public override void Write(char ch)
        {
            Console.Write(ch);
        }
        public override void Write(string text)
        {
            Console.Write(text);
        }
        public override byte Read()
        {
            char t = Console.ReadKey(false).KeyChar;
            byte[] b = { (byte)t };
            ASCIIEncoding.Convert(new UnicodeEncoding(), new ASCIIEncoding(), b);
            return b[0];
        }
        public override string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
