using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TitanEmulator.instructions {
    public class Instruction {
        public int length = 1;
        public int opcode = 0x8; // Set opcode to unused, same with cond
        public int cond;
        public string name = "Nonexistant";

        public virtual void execute(MachineState ms, byte[] parameters) {

        }

        public virtual int execute(MachineState ms, byte[] parameters, int pc) {
            return 0;
        }

        public virtual bool accept(int opc, int cnd) {
            return opcode == opc && cond == cnd;
        }
    }
}
