using System;
using System.Collections.Generic;
using System.Linq;
using TitanEmulator.instructions;

namespace TitanEmulator {
    class Interpreter {
        public byte[] assembly = { 0x00, 0x00, 0x90, 0x10, 0x10, 0x01, 0x14, 0x10, 0x10, 0x10, 0x10, 0xAB };
        public string assemblyString = "0000901010011410101010AB";
        public int programCounter = 0;
        public List<Instruction> instructions = new List<Instruction>();
        public Instruction currentInstruction;
        public MachineState ms = new MachineState();

        public void loadAssembly() {
            //currentInstruction = instructions.Where(i => i.opcode == readLowNibble(assembly[0]) && i.cond == readHighNibble(assembly[1])).First();
            currentInstruction =
                instructions.First(i => i.accept(readHighNibble(assembly[0]), readLowNibble(assembly[0])));
        }

        public void loadAssembly(string instructions) {
            if (instructions.Equals(assemblyString)) return;
            instructions = instructions.Replace(" ", string.Empty);
            List<byte> result = new List<byte>();
            for (int i = 0; i < instructions.Length - 1; i += 2) {
                string chr = instructions.Substring(i, 2);
                if (chr.IndexOf('\n') > 0 || chr.IndexOf('\r') > 0) continue;
                string substring = string.Format("{0:X}", chr);
                uint num = uint.Parse(substring, System.Globalization.NumberStyles.AllowHexSpecifier);

                byte[] floatVals = BitConverter.GetBytes(num);
                result.Add(floatVals[0]);
            }
            assemblyString = instructions;
            assembly = result.ToArray();
        }

        public void fetchNextInstruction() {
        }

        public Instruction decodeInstruction() {
            int high = readHighNibble(assembly[programCounter]);
            int low = readLowNibble(assembly[programCounter]);
            currentInstruction = instructions.FirstOrDefault(instr => instr.accept(high, low)) ?? new Instruction();
            return currentInstruction;
        }

        public static byte readHighNibble(byte n) {
            return (byte)((n >> 4) & 0xF);
        }

        public static byte readLowNibble(byte n) {
            return (byte)(n & 0xF);
        }

        public void executeInstruction(Instruction instr) {
            if (instr == null) {
                Console.WriteLine("Non-existant instruction; skipping");
                programCounter++;
                return;
            }
            List<byte> operands = new List<byte>();
            for (int i = 1; i < instr.length; i++) {
                operands.Add(readHighNibble(assembly[programCounter + i]));
                operands.Add(readLowNibble(assembly[programCounter + i]));
            }
            if (instr.opcode != 0xA) {
                instr.execute(ms, operands.ToArray());
                programCounter += currentInstruction.length;
            } else {
                programCounter = instr.execute(ms, operands.ToArray(), programCounter);
            }
        }

        public Interpreter() {
            instructions.Add(new AddInstruction());
            instructions.Add(new MovInstruction());
            instructions.Add(new SubInstruction());
            instructions.Add(new NotInstruction());
            instructions.Add(new ShrInstruction());
            instructions.Add(new LorInstruction());
            instructions.Add(new XorInstruction());
            instructions.Add(new AndInstruction());
            instructions.Add(new AdcInstruction());
            instructions.Add(new ClrInstruction());
            instructions.Add(new PopInstruction());
            instructions.Add(new PshInstruction());
            instructions.Add(new XchInstruction());
            instructions.Add(new LdcInstruction());
            instructions.Add(new NopInstruction());
            instructions.Add(new JmpInstruction());
            instructions.Add(new JpzInstruction());
            instructions.Add(new JpsInstruction());
            instructions.Add(new JpcInstruction());
            instructions.Add(new JpiInstruction());
            instructions.Add(new JsrInstruction());
            instructions.Add(new RtnInstruction());
            instructions.Add(new StmInstruction());
            instructions.Add(new LdmInstruction());
        }

        public void reset() {
            ms.reset();
            programCounter = 0;
        }
    }
}
