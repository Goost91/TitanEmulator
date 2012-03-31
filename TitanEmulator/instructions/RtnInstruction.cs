namespace TitanEmulator.instructions {
    class RtnInstruction : Instruction {

        public RtnInstruction() {
            opcode = 0xA;
            cond = 0x6;
            name = "RTN";
            length = 3;
        }

        public override int execute(MachineState ms, byte[] parameters, int pc) {
            return ms.callStack.Pop() + 1;
        }
        public override bool accept(int opc, int cnd) {
            return opcode == opc && cond == cnd;
        }
    }
}