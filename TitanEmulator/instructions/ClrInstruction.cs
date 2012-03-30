namespace TitanEmulator.instructions
{
    class ClrInstruction : Instruction {

        public ClrInstruction() {
            opcode = 0x6;
            //cond = 0x1;
            //hello
            name = "CLR";
            length = 1;
        }

        public override void execute(MachineState ms, byte[] parameters) {
            ms.registers[cond].value = 0;
        }

        public override bool accept(int opc, int cnd)
        {
            cond = cnd;
            return opcode == opc;
        }
    }
}