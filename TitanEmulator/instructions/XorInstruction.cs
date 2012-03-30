namespace TitanEmulator.instructions
{
    class XorInstruction : Instruction {

        public XorInstruction() {
            opcode = 0x1;
            cond = 0x5;
            name = "XOR";
            length = 2;
        }

        public override void execute(MachineState ms, byte[] parameters) {
            ms.registers[parameters[1]].value = ms.registers[parameters[0]].value ^ ms.registers[parameters[1]].value;
        }
    }
}