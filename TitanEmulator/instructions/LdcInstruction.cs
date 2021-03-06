namespace TitanEmulator.instructions
{
    class LdcInstruction : Instruction {

        public LdcInstruction() {
            opcode = 0xD;
            name = "LDC";
            length = 2;
        }

        public override void execute(MachineState ms, byte[] parameters) {
            ms.registers[cond].value = (byte) (((parameters[0] & 0xF) << 4 | (parameters[1] & 0xF)) & 0xFF);
        }
        public override bool accept(int opc, int cnd) {
            cond = cnd;
            return opcode == opc;
        }
    }
}