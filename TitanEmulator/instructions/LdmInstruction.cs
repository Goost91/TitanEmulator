using System;

namespace TitanEmulator.instructions {
    class LdmInstruction : Instruction {

        public LdmInstruction() {
            opcode = 0xE;
            name = "LDM";
            length = 3;
        }

        public override void execute(MachineState ms, byte[] parameters) {
            int address = parameters[0] << 12 | parameters[1] << 8 | parameters[2] << 4 | parameters[3];
            if(address == 0xFF00)
            {
                if (ms.inputBuffer.Length > 0)
                {
                    ms.registers[cond].value = Convert.ToByte(ms.inputBuffer.ToCharArray()[0]);
                    ms.inputBuffer = ms.inputBuffer.Remove(0, 1);
                }
                return;
            }
            ms.registers[cond].value = ms.memory[address];
        }
        public override bool accept(int opc, int cnd) {
            cond = cnd;
            return opcode == opc;
        }
    }
}