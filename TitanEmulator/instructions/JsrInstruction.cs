namespace TitanEmulator.instructions {
    class JsrInstruction : Instruction {

        public JsrInstruction() {
            opcode = 0xA;
            cond = 0x5;
            name = "JSR";
            length = 3;
        }

        public override int execute(MachineState ms, byte[] parameters, int pc) {
            if (ms.flags["C"] == 0) return pc + length; // return if C flag isn't set
            ms.stack.Push(pc);
            return parameters[0] << 12 | parameters[1] << 8 | parameters[2] << 4 | parameters[3];
        }
        public override bool accept(int opc, int cnd) {
            return opcode == opc && cond == cnd;
        }
    }
}