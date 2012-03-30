namespace TitanEmulator.instructions {
    class NotInstruction : Instruction {

        public NotInstruction() {
            opcode = 0x1;
            cond = 0x6;
            name = "NOT";
            length = 2;
        }

        public override void execute(MachineState ms, byte[] parameters) {
           ms.registers[parameters[0]].value = ~ms.registers[parameters[0]].value & 0xFF;
        }
    }
}