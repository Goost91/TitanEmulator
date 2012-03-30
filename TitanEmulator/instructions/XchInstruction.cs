namespace TitanEmulator.instructions
{
    class XchInstruction : Instruction {
        public XchInstruction() {
            opcode = 0x9;
            cond = 0x1;
            name = "XCH";
            length = 2;
        }

        public override void execute(MachineState ms, byte[] parameters) {
            int temp = ms.registers[parameters[1]].value;
            ms.registers[parameters[1]].value = ms.registers[parameters[0]].value;
            ms.registers[parameters[0]].value = temp;
        }
    }
}