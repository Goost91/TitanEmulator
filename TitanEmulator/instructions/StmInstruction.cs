using System;

namespace TitanEmulator.instructions {
    class StmInstruction : Instruction {

        public StmInstruction() {
            opcode = 0xF;
            name = "STM";
            length = 3;
        }

        public override void execute(MachineState ms, byte[] parameters) {
            int address = parameters[0] << 12 | parameters[1] << 8 | parameters[2] << 4 | parameters[3];
            if (address == 0xFF00) {
                ms.outputBuffer += Convert.ToChar(ms.registers[cond].value);
                return;
            }
            ms.memory[address] = ms.registers[cond].value;
        }
        public override bool accept(int opc, int cnd) {
            cond = cnd;
            return opcode == opc;
        }
    }
}