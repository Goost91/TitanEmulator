namespace TitanEmulator.instructions {
    class JpiInstruction : Instruction {

        public JpiInstruction() {
            opcode = 0xA;
            cond = 0x4;
            name = "JPI";
            length = 3;
        }

        public override int execute(MachineState ms, byte[] parameters, int pc) {
            int address = parameters[0] << 12 | parameters[1] << 8 | parameters[2] << 4 | parameters[3];
            int value = ms.memory[address];
            return value;
        }
        public override bool accept(int opc, int cnd) {
            return opcode == opc && cond == cnd;
        }
    }
}