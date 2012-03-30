namespace TitanEmulator.instructions {
    class SubInstruction : Instruction {

        public SubInstruction() {
            opcode = 0x1;
            cond = 0x2;
            name = "SUB";
            length = 2;
        }

        public override void execute(MachineState ms, byte[] parameters) {
            int res = ms.registers[parameters[0]].value - ms.registers[parameters[1]].value;
            ms.registers[parameters[1]].value = res;
            ms.flags["Z"] = res == 0 ? 1 : 0;
        }
    }
}