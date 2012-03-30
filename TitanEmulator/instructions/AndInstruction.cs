namespace TitanEmulator.instructions {
    class AndInstruction : Instruction {

        public AndInstruction() {
            opcode = 0x1;
            cond = 0x3;
            name = "AND";
            length = 2;
        }

        public override void execute(MachineState ms, byte[] parameters) {
            ms.registers[parameters[0]].value = ms.registers[parameters[0]].value + ms.registers[parameters[1]].value;
        }
    }
}