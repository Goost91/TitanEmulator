﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TitanEmulator.instructions {
    public class Instruction {
        public int length = 1;
        public int opcode = 0x8;
        public int cond = 0x0;
        public string name = "Nonexistant";

        public virtual void execute(MachineState ms, byte[] parameters) {
        }

        public virtual bool accept(int opc, int cnd) {
            return opcode == opc && cond == cnd;
        }
    }
}
