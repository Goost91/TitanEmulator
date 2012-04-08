namespace TitanEmulator.instructions {
    class LdmInstruction : Instruction {

        public LdmInstruction() {
            opcode = 0xE;
            name = "LDM";
            length = 3;
        }

        public override void execute(MachineState ms, byte[] parameters) {
            int address = parameters[0] << 12 | parameters[1] << 8 | parameters[2] << 4 | parameters[3];
            ms.registers[cond].value = ms.memory[address];
        }
        public override bool accept(int opc, int cnd) {
            cond = cnd;
            return opcode == opc;
        }
    }
}