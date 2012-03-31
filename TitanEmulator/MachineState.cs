using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TitanEmulator {
    public class MachineState {
        public List<Register> registers = new List<Register>(16);
        public Dictionary<string, int> flags = new Dictionary<string, int>();
        public Stack<int> stack = new Stack<int>();
        public int[] memory = new int[0xFFFF];

        public MachineState() {
            reset();
        }

        public void reset() {
            registers.Clear();
            flags.Clear();
            stack.Clear();
            for (int i = 0; i < 16; i++) {
                string reg = i.ToString("X");
                registers.Add(new Register("R" + reg, 0, i));
            }
            flags.Add("Z", 0);
            flags.Add("S", 0);
            flags.Add("C", 0);
        }
    }
}
