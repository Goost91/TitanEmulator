using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            textBox1.Text = interpreter.assemblyString;
            sv = new StackViewer();
            mv = new MemoryViewer();
            sv.setMachineState(interpreter.ms);
            mv.setMachineState(interpreter.ms);
            UpdateRegisterViews();
            openFileDialog1.Filter = "Titan Assemblies (*.hex)|*.hex";
        }


        private void timer1_Tick(object sender, EventArgs e) {
            doCycle();
        }

        private void doCycle() {
            if (interpreter.programCounter > interpreter.assembly.Length - 1) {
                timer1.Stop();
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

        private void button2_Click(object sender, EventArgs e) {
            if (!textBox1.Text.Equals(""))
                interpreter.loadAssembly(textBox1.Text);
            doCycle();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (!textBox1.Text.Equals(""))
                interpreter.loadAssembly(textBox1.Text);
            if (button1.Text.Equals("Run")) {
                timer1.Start();
                sv.update(interpreter.ms);
                mv.setMachineState(interpreter.ms);
                button1.Text = "Stop";
                interpreter.ms.running = true;
            } else if(button1.Text.Equals("Stop")) {
                timer1.Stop();
                button1.Text = "Run";
                sv.timer1.Stop();
                interpreter.ms.running = false;
                mv.timer1.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            interpreter.reset();
            timer1.Stop();
            sv.reset();
            UpdateRegisterViews();
        }

        private void UpdateRegisterViews() {
            tbR0.Text = string.Format("{0:X}",interpreter.ms.registers[0].value).PadLeft(2, '0');
            tbR1.Text = string.Format("{0:X}",interpreter.ms.registers[1].value).PadLeft(2, '0');
            tbR2.Text = string.Format("{0:X}",interpreter.ms.registers[2].value).PadLeft(2, '0');
            tbR3.Text = string.Format("{0:X}",interpreter.ms.registers[3].value).PadLeft(2, '0');
            tbR4.Text = string.Format("{0:X}",interpreter.ms.registers[4].value).PadLeft(2, '0');
            tbR5.Text = string.Format("{0:X}",interpreter.ms.registers[5].value).PadLeft(2, '0');
            tbR6.Text = string.Format("{0:X}",interpreter.ms.registers[6].value).PadLeft(2, '0');
            tbR7.Text = string.Format("{0:X}",interpreter.ms.registers[7].value).PadLeft(2, '0');
            tbR8.Text = string.Format("{0:X}",interpreter.ms.registers[8].value).PadLeft(2, '0');
            tbR9.Text = string.Format("{0:X}",interpreter.ms.registers[9].value).PadLeft(2, '0');
            tbRA.Text = string.Format("{0:X}",interpreter.ms.registers[10].value).PadLeft(2, '0');
            tbRB.Text = string.Format("{0:X}",interpreter.ms.registers[11].value).PadLeft(2, '0');
            tbRC.Text = string.Format("{0:X}",interpreter.ms.registers[12].value).PadLeft(2, '0');
            tbRD.Text = string.Format("{0:X}",interpreter.ms.registers[13].value).PadLeft(2, '0');
            tbRE.Text = string.Format("{0:X}",interpreter.ms.registers[14].value).PadLeft(2, '0');
            tbRF.Text = string.Format("{0:X}",interpreter.ms.registers[15].value).PadLeft(2, '0');
            tbPC.Text = string.Format("{0:X}",(interpreter.programCounter)).PadLeft(2, '0');
            tbC.Text = string.Format("{0:X}",(interpreter.ms.flags["C"]));
            tbS.Text = string.Format("{0:X}",(interpreter.ms.flags["S"]));
            tbZ.Text = string.Format("{0:X}", (interpreter.ms.flags["Z"]));
            stackHeightLbl.Text = string.Format("Stack height: {0}", interpreter.ms.stack.Count);
            currentInstructionLbl.Text = string.Format("Current Instruction: {0}", interpreter.currentInstruction.name);    
        }

        private void stackViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sv.Show();
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Resize(object sender, EventArgs e) {
            
        }

        private void menuStrip1_SizeChanged(object sender, EventArgs e) {
            
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if(res == DialogResult.OK)
            {
                System.IO.Stream fileStream = openFileDialog1.OpenFile();
                string result = "";
                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream)) {
                    // Read the first line from the file and write it the textbox.
                    while (!reader.EndOfStream) {
                        char inChar = (char) reader.Read();
                        if (isValidAssemblyChar(inChar))
                            result += inChar;
                    }
                }
                textBox1.Text = result;
                fileStream.Close();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
            if(e.Control) {
                Keys k = e.KeyCode;
                if (k != Keys.V && k != Keys.C && k != Keys.X)
                    e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            
            if (!isValidAssemblyChar(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        public static bool isValidAssemblyChar(char c) {
            return (c >= '0' && c <= '9') || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F') || c == ' ';
        }

        private void memoryViewerToolStripMenuItem_Click(object sender, EventArgs e) {
            mv.Show();
        }


    }
}
