namespace TitanEmulator.instructions
{
    class PshInstruction : Instruction {

        public PshInstruction() {
            opcode = 0x7;
            name = "PSH";
            length = 1;
        }

        public override void execute(MachineState ms, byte[] parameters) {
            ms.stack.Push(ms.registers[cond].value);
        }
        public override bool accept(int opc, int cnd) {
            cond = cnd;
            return opcode == opc;
        }
    }
}