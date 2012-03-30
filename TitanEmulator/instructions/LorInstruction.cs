using System;

namespace TitanEmulator.instructions {
    class LorInstruction : Instruction {

        public LorInstruction() {
            opcode = 0x1;
            cond = 0x4;
            name = "LOR";
            length = 2;
        }

        public override void execute(MachineState ms, byte[] parameters) {
            ms.registers[parameters[1]].value = ms.registers[parameters[0]].value | ms.registers[parameters[1]].value;
        }
    }
}