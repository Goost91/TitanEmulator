using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TitanEmulator {
    public class Register {
        public int value;
        public int index;

        public Register(int v, int i) {
            value = v;
            index = i;
        }
    }
}
