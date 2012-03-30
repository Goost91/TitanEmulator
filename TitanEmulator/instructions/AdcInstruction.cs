namespace TitanEmulator.instructions {
    class AdcInstruction : Instruction {

        public AdcInstruction() {
            opcode = 0x1;
            cond = 0x1;
            name = "ADC";
            length = 2;
        }

        public override void execute(MachineState ms, byte[] parameters) {
            ms.registers[parameters[0]].value = ms.registers[parameters[0]].value + ms.registers[parameters[1]].value + ms.flags["C"];
        }
    }
}