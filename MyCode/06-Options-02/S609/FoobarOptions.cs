﻿namespace App
{
    public class FoobarOptions
    {
        public int Foo { get; set; }
        public int Bar { get; set; }
        public override string ToString() => $"Foo:{Foo}, Bar:{Bar}";
    }
}