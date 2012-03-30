namespace TitanEmulator.instructions {
    class JmpInstruction : Instruction {

        public JmpInstruction() {
            opcode = 0xA;
            cond = 0x0;
            name = "JMP";
            length = 3;
        }

        public override int execute(MachineState ms, byte[] parameters, int pc) {
            ms.callStack.Push(pc);
            return parameters[0] << 12 | parameters[1] << 8 | parameters[2] << 4 | parameters[3];
        }
        public override bool accept(int opc, int cnd) {
            return opcode == opc && cond == cnd;
        }
    }
}