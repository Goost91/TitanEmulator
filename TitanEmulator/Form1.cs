using System;
using System.IO;
using System.Windows.Forms;
using TitanEmulator.instructions;

namespace TitanEmulator {
    public partial class Form1 : Form {
        Interpreter interpreter = new Interpreter();
        StackViewer sv;
        MemoryViewer mv;
        TerminalWindow tw;

        public Form1() {
            InitializeComponent();

            interpreter.loadAssembly();
            tbInput.Text = interpreter.assemblyString;

            sv = new StackViewer();
            mv = new MemoryViewer();
            tw = new TerminalWindow();
            sv.setMachineState(interpreter.ms);
            mv.setMachineState(interpreter.ms);
            tw.setMachineState(interpreter.ms);
            tw.Show();
            UpdateRegisterViews();
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
            // fetch and decode decode instruction
            Instruction ins = interpreter.fetchAndDecodeInstruction();
            // execute instruction
            interpreter.executeInstruction(ins);
            UpdateRegisterViews();
        }

        private void UpdateRegisterViews() {
            tbR0.Text = formatField(interpreter.ms.registers[0].value);
            tbR1.Text = formatField(interpreter.ms.registers[1].value);
            tbR2.Text = formatField(interpreter.ms.registers[2].value);
            tbR3.Text = formatField(interpreter.ms.registers[3].value);
            tbR4.Text = formatField(interpreter.ms.registers[4].value);
            tbR5.Text = formatField(interpreter.ms.registers[5].value);
            tbR6.Text = formatField(interpreter.ms.registers[6].value);
            tbR7.Text = formatField(interpreter.ms.registers[7].value);
            tbR8.Text = formatField(interpreter.ms.registers[8].value);
            tbR9.Text = formatField(interpreter.ms.registers[9].value);
            tbRA.Text = formatField(interpreter.ms.registers[10].value);
            tbRB.Text = formatField(interpreter.ms.registers[11].value);
            tbRC.Text = formatField(interpreter.ms.registers[12].value);
            tbRD.Text = formatField(interpreter.ms.registers[13].value);
            tbRE.Text = formatField(interpreter.ms.registers[14].value);
            tbRF.Text = formatField(interpreter.ms.registers[15].value);
            tbPC.Text = formatField(interpreter.programCounter);
            tbC.Text = string.Format("{0:X}", (interpreter.ms.flags["C"]));
            tbS.Text = string.Format("{0:X}", (interpreter.ms.flags["S"]));
            tbZ.Text = string.Format("{0:X}", (interpreter.ms.flags["Z"]));
            stackHeightLbl.Text = string.Format("Stack height: {0}", interpreter.ms.stack.Count);
            currentInstructionLbl.Text = string.Format("Current Instruction: {0}", interpreter.currentInstruction.name);
            mv.setMachineState(interpreter.ms);
        }

        private static string formatField(int value) {
            return string.Format("{0:X}", value).PadLeft(2, '0');
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
