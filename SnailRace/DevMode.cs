using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailRace
{
    static class DevMode
    {
        public static bool Speed { get; set; } = false;//if true, all snails move 10x as fast
        public static int[] Win { get; set; } = {0,1};//{true(1)/false(0),which snail}
        public static bool Resize { get; set; } = false;//if true, form is resizable. This will effect race length
    }
}
