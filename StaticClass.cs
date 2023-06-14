using System;
using System.ComponentModel;

namespace Fundamentals
{
    public static class StaticClass
    {
        /*
          Static methods can only have static datamembers
          Static class cannot be instantiated.
          Static class cannot contain instance constructors
        */


        public static float PI = 3.14f;
        public static int cube(int n) { return n * n * n; }
    }
}

