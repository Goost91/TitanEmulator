namespace TitanEmulator.instructions
{
    class PopInstruction : Instruction {

        public PopInstruction() {
            opcode = 0x8;
            //cond = 0x1;
            name = "POP";
            length = 1;
        }

        public override void execute(MachineState ms, byte[] parameters) {
            ms.registers[cond].value = ms.stack.Pop();
        }
        public override bool accept(int opc, int cnd) {
            cond = cnd;
            return opcode == opc;
        }
    }
}