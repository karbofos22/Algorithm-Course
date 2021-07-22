using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class HashSetThing
    {
        public string RandomString { get; set; }

        public override bool Equals(Object obj)
        {
            var word = obj as HashSetThing;

            if (word == null)
                return false;

            return RandomString == word.RandomString;
        }

        public override int GetHashCode()
        {
            int randomStringHashCode = RandomString?.GetHashCode() ?? 0;

            return randomStringHashCode;
        }
    }
}
