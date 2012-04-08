using System.Collections.Generic;

namespace TitanEmulator {
    public class MachineState {
        public List<Register> registers = new List<Register>(16);
        public Dictionary<string, int> flags = new Dictionary<string, int>();
        public Stack<int> stack = new Stack<int>();
        public byte[] memory = new byte[0xFFFF];
        public bool running = false;

        public MachineState() {
            reset();
        }

        public void reset() {
            registers.Clear();
            flags.Clear();
            stack.Clear();

            for (int i = 0; i < 16; i++) {
                registers.Add(new Register(i, i));
            }

            flags.Add("Z", 0);
            flags.Add("S", 0);
            flags.Add("C", 0);
            for(int i = 0; i< memory.Length; i++ )
            {
                memory[i] = (byte)i;
            }
        }
    }
}
