namespace TitanEmulator.instructions {
    class JpsInstruction : Instruction {

        public JpsInstruction() {
            opcode = 0xA;
            cond = 0x2;
            name = "JPS";
            length = 3;
        }

        public override int execute(MachineState ms, byte[] parameters, int pc) {
            if (ms.flags["S"] == 0) return pc + length; // return if S flag isn't set
            return parameters[0] << 12 | parameters[1] << 8 | parameters[2] << 4 | parameters[3];
        }
        public override bool accept(int opc, int cnd) {
            return opcode == opc && cond == cnd;
        }
    }
}