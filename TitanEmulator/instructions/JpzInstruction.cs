namespace TitanEmulator.instructions {
    class JpzInstruction : Instruction {

        public JpzInstruction() {
            opcode = 0xA;
            cond = 0x1;
            name = "JPZ";
            length = 3;
        }

        public override int execute(MachineState ms, byte[] parameters, int pc) {
            if (ms.flags["Z"] == 0) return pc + length; // return if Z flag isn't set
            ms.callStack.Push(pc);
            return parameters[0] << 12 | parameters[1] << 8 | parameters[2] << 4 | parameters[3];
        }
        public override bool accept(int opc, int cnd) {
            return opcode == opc && cond == cnd;
        }
    }
}