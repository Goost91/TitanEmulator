namespace TitanEmulator.instructions {
    class AddInstruction : Instruction {

        public AddInstruction() {
            opcode = 0x1;
            cond = 0x0;
            name = "ADD";
            length = 2;
        }

        public override void execute(MachineState ms, byte[] parameters) {
            ms.flags["C"] = (ms.registers[parameters[0]].value + ms.registers[parameters[1]].value) > 255 ? 1 : 0;
            ms.flags["S"] = (ms.registers[parameters[0]].value + ms.registers[parameters[1]].value) >> 4 > 0x8 ? 1 : 0;
            int res = (ms.registers[parameters[0]].value + ms.registers[parameters[1]].value) & 0xFF;
            ms.registers[parameters[1]].value = (byte) res;

            ms.flags["Z"] = res == 0 ? 1 : 0;
        }
    }
}
