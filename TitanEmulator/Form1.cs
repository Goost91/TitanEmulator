using System;
using System.IO;
using System.Windows.Forms;
using TitanEmulator.instructions;

namespace TitanEmulator {
    public partial class Form1 : Form {
        Interpreter interpreter = new Interpreter();
        StackViewer sv;
        MemoryViewer mv;

        public Form1() {
            InitializeComponent();
            interpreter.loadAssembly();
            tbInput.Text = interpreter.assemblyString;
            sv = new StackViewer();
            mv = new MemoryViewer();
            sv.setMachineState(interpreter.ms);
            mv.setMachineState(interpreter.ms);
            UpdateRegisterViews();
            openFileDialog1.Filter = "Titan Assemblies (*.hex)|*.hex";
        }


        private void timerClockSignal_Tick(object sender, EventArgs e) {
            doCycle();
        }

        private void doCycle() {
            if (interpreter.programCounter > interpreter.assembly.Length - 1) {
                timerClockSignal.Stop();
                btnRun.Text = "Run";
                return;
            }
            // fetch instruction
            interpreter.fetchNextInstruction();
            // decode instruction
            Instruction ins = interpreter.decodeInstruction();
            UpdateRegisterViews();
            // execute instruction
            interpreter.executeInstruction(ins);
            UpdateRegisterViews();
        }

        private void UpdateRegisterViews() {
            tbR0.Text = string.Format("{0:X}", interpreter.ms.registers[0].value).PadLeft(2, '0');
            tbR1.Text = string.Format("{0:X}", interpreter.ms.registers[1].value).PadLeft(2, '0');
            tbR2.Text = string.Format("{0:X}", interpreter.ms.registers[2].value).PadLeft(2, '0');
            tbR3.Text = string.Format("{0:X}", interpreter.ms.registers[3].value).PadLeft(2, '0');
            tbR4.Text = string.Format("{0:X}", interpreter.ms.registers[4].value).PadLeft(2, '0');
            tbR5.Text = string.Format("{0:X}", interpreter.ms.registers[5].value).PadLeft(2, '0');
            tbR6.Text = string.Format("{0:X}", interpreter.ms.registers[6].value).PadLeft(2, '0');
            tbR7.Text = string.Format("{0:X}", interpreter.ms.registers[7].value).PadLeft(2, '0');
            tbR8.Text = string.Format("{0:X}", interpreter.ms.registers[8].value).PadLeft(2, '0');
            tbR9.Text = string.Format("{0:X}", interpreter.ms.registers[9].value).PadLeft(2, '0');
            tbRA.Text = string.Format("{0:X}", interpreter.ms.registers[10].value).PadLeft(2, '0');
            tbRB.Text = string.Format("{0:X}", interpreter.ms.registers[11].value).PadLeft(2, '0');
            tbRC.Text = string.Format("{0:X}", interpreter.ms.registers[12].value).PadLeft(2, '0');
            tbRD.Text = string.Format("{0:X}", interpreter.ms.registers[13].value).PadLeft(2, '0');
            tbRE.Text = string.Format("{0:X}", interpreter.ms.registers[14].value).PadLeft(2, '0');
            tbRF.Text = string.Format("{0:X}", interpreter.ms.registers[15].value).PadLeft(2, '0');
            tbPC.Text = string.Format("{0:X}", (interpreter.programCounter)).PadLeft(2, '0');
            tbC.Text = string.Format("{0:X}", (interpreter.ms.flags["C"]));
            tbS.Text = string.Format("{0:X}", (interpreter.ms.flags["S"]));
            tbZ.Text = string.Format("{0:X}", (interpreter.ms.flags["Z"]));
            stackHeightLbl.Text = string.Format("Stack height: {0}", interpreter.ms.stack.Count);
            currentInstructionLbl.Text = string.Format("Current Instruction: {0}", interpreter.currentInstruction.name);
            mv.setMachineState(interpreter.ms);
        }

        private void btnReset_Click(object sender, EventArgs e) {
            interpreter.reset();
            timerClockSignal.Stop();
            sv.reset(interpreter.ms);
            UpdateRegisterViews();
        }

        private void btnStep_Click(object sender, EventArgs e) {
            if (!tbInput.Text.Equals(""))
                interpreter.loadAssembly(tbInput.Text);
            doCycle();
        }

        private void btnRun_Click(object sender, EventArgs e) {
            if (!tbInput.Text.Equals(""))
                interpreter.loadAssembly(tbInput.Text);
            if (btnRun.Text.Equals("Run")) {
                timerClockSignal.Start();
                sv.update(interpreter.ms);
                mv.setMachineState(interpreter.ms);
                btnRun.Text = "Stop";
                interpreter.ms.running = true;
            } else if (btnRun.Text.Equals("Stop")) {
                timerClockSignal.Stop();
                btnRun.Text = "Run";
                sv.timer1.Stop();
                interpreter.ms.running = false;
            }
        }

        private void stackViewerToolStripMenuItem_Click(object sender, EventArgs e) {
            sv.Show();
        }

        private static bool isValidAssemblyChar(char c) {
            return (c >= '0' && c <= '9') || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F') || c == ' ';
        }

        private void memoryViewerToolStripMenuItem_Click(object sender, EventArgs e) {
            mv.Show();
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(isValidAssemblyChar(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void tbInput_KeyDown(object sender, KeyEventArgs e) {
            if (!e.Control) return;
            Keys k = e.KeyCode;
            if (k != Keys.V && k != Keys.C && k != Keys.X)
                e.Handled = true;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK) {
                Stream fileStream = openFileDialog1.OpenFile();
                string result = "";

                foreach (byte b in ReadFully(fileStream)) {
                    result += string.Format("{0:X}", Interpreter.readHighNibble(b));
                    result += string.Format("{0:X}", Interpreter.readLowNibble(b));
                }

                tbInput.Text = result;
                fileStream.Close();
            }
        }

        public static byte[] ReadFully(Stream stream) {
            byte[] buffer = new byte[32768];
            using (MemoryStream ms = new MemoryStream()) {
                while (true) {
                    int read = stream.Read(buffer, 0, buffer.Length);
                    if (read <= 0)
                        return ms.ToArray();
                    ms.Write(buffer, 0, read);
                }
            }
        }
    }
}
