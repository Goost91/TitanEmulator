using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TitanEmulator {
    public class Register {
        public string name;
        public int value;
        public int index;

        public Register(string s, int v, int i) {
            name = s;
            value = v;
            index = i;
        }
    }
}
