using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP.Labs.Lab8
{
    interface IStreamable
    {
        StreamWriter OutStream { get; }

        StreamReader InStream { get; }
    }
}
