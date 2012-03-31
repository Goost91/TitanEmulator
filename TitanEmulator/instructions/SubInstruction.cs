namespace TitanEmulator.instructions {
    class SubInstruction : Instruction {

        public SubInstruction() {
            opcode = 0x1;
            cond = 0x2;
            name = "SUB";
            length = 2;
        }

        public override void execute(MachineState ms, byte[] parameters) {
            int res = ms.registers[parameters[1]].value - ms.registers[parameters[0]].value;
            ms.flags["C"] = res > 255 ? 1 : 0;
            ms.flags["S"] = res >> 4 > 0x8 ? 1 : 0;
            ms.flags["Z"] = res == 0 ? 1 : 0;
            if(res < 0) {
                //res = 0xFF - (res + 1) & 0xFF;
                ms.flags["C"] = 1;
            }
            ms.registers[parameters[1]].value = (byte) (res);
        }
    }
}