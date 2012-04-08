namespace TitanEmulator.instructions
{
    class NopInstruction : Instruction {
        public NopInstruction() {
            opcode = 0x0;
            cond = 0x0;
            name = "NOP";
            length = 1;
        }
    }
}