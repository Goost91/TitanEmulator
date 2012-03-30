namespace TitanEmulator.instructions
{
    class ShrInstruction : Instruction {

        public ShrInstruction() {
            opcode = 0x1;
            cond = 0x8;
            name = "SHR";
            length = 2;
        }

        public override void execute(MachineState ms, byte[] parameters) {
            ms.registers[ms.registers[parameters[0]].index].value = ms.registers[parameters[0]].value >> 1;
        }
    }
}