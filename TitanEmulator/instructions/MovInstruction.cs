namespace TitanEmulator.instructions {
    class MovInstruction : Instruction {
        public MovInstruction() {
            opcode = 0x9;
            cond = 0x0;
            name = "MOV";
            length = 2;
        }

        public override void execute(MachineState ms, byte[] parameters) {
            ms.registers[parameters[1]].value = ms.registers[parameters[0]].value;
        }
    }
}
