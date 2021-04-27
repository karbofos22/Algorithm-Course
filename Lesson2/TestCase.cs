using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class TestCase
    {
        public int[] MyArray { get; set; }
        public int SearchValue { get; set; }
        public int Expected { get; set; }
        public Node ExpectedNode { get; set; }
        public LinkedList LinkedList { get; set; }
        public Exception ExpectedException { get; set; }
    }
}
