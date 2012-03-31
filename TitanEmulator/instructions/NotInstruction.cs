namespace TitanEmulator.instructions {
    class NotInstruction : Instruction {

        public NotInstruction() {
            opcode = 0x1;
            cond = 0x6;
            name = "NOT";
            length = 2;
        }

        public override void execute(MachineState ms, byte[] parameters) {
            int res = ~ms.registers[parameters[0]].value & 0xFF;
            ms.registers[parameters[0]].value = (byte) (res);
            ms.flags["S"] = res >> 4 > 0x8 ? 1 : 0;
            ms.flags["Z"] = res == 0 ? 1 : 0;
        }
    }
}